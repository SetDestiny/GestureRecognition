using GestureRecognition.DAL.Models;
using MetroFramework.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace GestureRecognition.BLL.AForgeHelper
{
    public class FrameHelper
    {
        byte[,] processedImage;
        private byte[,] processedImageHelperA = new byte[480, 640];
        private byte[,] processedImageHelperB = new byte[480, 640];

        ArrayList borderX = new ArrayList();
        ArrayList borderY = new ArrayList();

        double objectArea, objectCompactness, objectPx, objectPy;
        double xCOG, yCOG, borderLength;
        double xMax, xMin, yMax, yMin;

        public FrameHelper()
        {
        }

        public Image ProcessFrame(int threshold, Bitmap frame)
        {
            Bitmap temp = new Bitmap(frame);
            BitmapData bmData = temp.LockBits(new Rectangle(0, 0, temp.Width, temp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                int width = temp.Width;
                byte* p = (byte*)Scan0;
                int nOffset = stride - temp.Width * 3;

                int finished;

                Task[] t = new Task[Environment.ProcessorCount];
                for (int x = 0; x < Environment.ProcessorCount; x++)
                {
                    int xTemp = x;
                    byte* pTemp = p;
                    t[x] = Task.Factory.StartNew(() => BinarizeImage(pTemp, xTemp, width, threshold));
                    p += stride;
                }
                for (int x = Environment.ProcessorCount; x < temp.Height; x++)
                {
                    int xTemp = x;
                    byte* pTemp = p;

                    finished = Task.WaitAny(t);
                    t[finished] = Task.Factory.StartNew(() => BinarizeImage(pTemp, xTemp, width, threshold));

                    p += stride;
                }

                Task.WaitAll(t);

                processedImageHelperB[0, 0] = processedImageHelperB[temp.Height - 1, 0] = processedImageHelperB[0, temp.Width - 1] = processedImageHelperB[temp.Height - 1, temp.Width - 1] = 0;

                for (int x = 0; x < Environment.ProcessorCount; x++)
                {
                    processedImageHelperB[x + 1, 0] = processedImageHelperB[x + 1, temp.Width - 1] = 0;
                    int xTemp = x;
                    t[x] = Task.Factory.StartNew(() => ApplyFilter(xTemp + 1, width));
                }

                for (int x = Environment.ProcessorCount + 1; x < temp.Height - 1; x++)
                {
                    processedImageHelperB[x, 0] = processedImageHelperB[x, temp.Width - 1] = 0;
                    finished = Task.WaitAny(t);
                    int xTemp = x;
                    t[finished] = Task.Factory.StartNew(() => ApplyFilter(xTemp, width));

                }
                Task.WaitAll(t);

                p = (byte*)Scan0;

                for (int x = 0; x < temp.Height; x++)
                {
                    for (int y = 0; y < temp.Width; y++)
                    {
                        p[0] = p[1] = p[2] = processedImageHelperB[x, y];

                        p += 3;
                    }
                    p += nOffset;
                }

            }
            temp.UnlockBits(bmData);

            return temp.Clone() as Image;
        }

        private void ApplyFilter(int x, int width)
        {
            for (int y = 1; y < width - 1; y++)
            {
                processedImageHelperB[0, y] = processedImageHelperB[480 - 1, y] = 0;
                if (processedImageHelperA[x - 1, y - 1] + processedImageHelperA[x - 1, y] + processedImageHelperA[x - 1, y + 1] + processedImageHelperA[x, y - 1] + processedImageHelperA[x, y + 1] +
                    processedImageHelperA[x + 1, y - 1] + processedImageHelperA[x + 1, y] + processedImageHelperA[x + 1, y + 1] <= 510)
                {
                    processedImageHelperB[x, y] = 0;
                }
                if (processedImageHelperA[x - 1, y - 1] + processedImageHelperA[x - 1, y] + processedImageHelperA[x - 1, y + 1] + processedImageHelperA[x, y - 1] + processedImageHelperA[x, y + 1] +
                    processedImageHelperA[x + 1, y - 1] + processedImageHelperA[x + 1, y] + processedImageHelperA[x + 1, y + 1] >= 1785)
                {
                    processedImageHelperB[x, y] = 255;
                }
            }
        }

        // By green channel
        unsafe private void BinarizeImage(byte* q, int x, int width, int threshold)
        {
            for (int y = 0; y < width; y++)
            {
                if (q[1] > threshold)
                    processedImageHelperA[x, y] = 0;
                else
                    processedImageHelperA[x, y] = 255;

                q += 3;
            }
        }

        public Image CaptureAndProcces(ref System.Windows.Forms.PictureBox webcamImage, ref MetroTextBox textBox)
        {
            processedImage = new byte[480, 640];
            int[,] position = new int[8, 2] { { -1, -1 }, { 0, -1 }, { 1, -1 }, { 1, 0 }, { 1, 1 }, { 0, 1 }, { -1, 1 }, { -1, 0 } };
            byte indexPos;
            int count;
            bool stopVar;

            borderX.Clear();
            borderY.Clear();

            while (webcamImage.Image == null) ;

            Bitmap temp = new Bitmap(webcamImage.Image as Bitmap);
            BitmapData bmData = temp.LockBits(new Rectangle(0, 0, temp.Width, temp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            // First pixel address
            IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)Scan0;
                int nOffset = stride - temp.Width * 3;

                for (int x = 0; x < temp.Height; x++)
                {
                    for (int y = 0; y < temp.Width; y++)
                    {
                        processedImage[x, y] = p[0];

                        p += 3;
                    }
                    p += nOffset;
                }
            }

            stopVar = false;
            
            for (int i = 50; i < temp.Height; i++)
            {
                for (int j = 50; j < temp.Width; j++)
                {
                    if (processedImage[i, j] == 255)
                    {
                        borderX.Add(i);
                        borderY.Add(j);
                        stopVar = true;
                        break;
                    }
                }
                if (stopVar)
                    break;
            }

            indexPos = 0;
            count = 0;

            if (stopVar == true)
            {
                do
                {
                    while (processedImage[(int)borderX[count] + position[indexPos % 8, 0], (int)borderY[count] + position[indexPos % 8, 1]] != 255 && indexPos < 18)
                    {
                        indexPos++;
                    }
                    if (indexPos >= 18)
                        break;

                    count++;
                    borderX.Add((int)borderX[count - 1] + position[indexPos % 8, 0]);
                    borderY.Add((int)borderY[count - 1] + position[indexPos % 8, 1]);

                    if ((int)borderX[count - 1] - (int)borderX[count] == -1 && (int)borderY[count - 1] - (int)borderY[count] == 0)
                    {
                        indexPos = 0;
                    }
                    else if ((int)borderX[count - 1] - (int)borderX[count] == -1 && (int)borderY[count - 1] - (int)borderY[count] == -1)
                    {
                        indexPos = 1;
                    }
                    else if ((int)borderX[count - 1] - (int)borderX[count] == 0 && (int)borderY[count - 1] - (int)borderY[count] == -1)
                    {
                        indexPos = 2;
                    }
                    else if ((int)borderX[count - 1] - (int)borderX[count] == 1 && (int)borderY[count - 1] - (int)borderY[count] == -1)
                    {
                        indexPos = 3;
                    }
                    else if ((int)borderX[count - 1] - (int)borderX[count] == 1 && (int)borderY[count - 1] - (int)borderY[count] == 0)
                    {
                        indexPos = 4;
                    }
                    else if ((int)borderX[count - 1] - (int)borderX[count] == 1 && (int)borderY[count - 1] - (int)borderY[count] == 1)
                    {
                        indexPos = 5;
                    }
                    else if ((int)borderX[count - 1] - (int)borderX[count] == 0 && (int)borderY[count - 1] - (int)borderY[count] == 1)
                    {
                        indexPos = 6;
                    }
                    else if ((int)borderX[count - 1] - (int)borderX[count] == -1 && (int)borderY[count - 1] - (int)borderY[count] == 1)
                    {
                        indexPos = 7;
                    }
                    if (count > 3000)
                    {
                        break;
                    }
                } while (((int)borderX[0] != (int)borderX[count]) || ((int)borderY[0] != (int)borderY[count]));
            }

            if (count > 100 && count <= 3000)
            {

                borderX.RemoveAt(count);
                borderY.RemoveAt(count);
                textBox.AppendText("\nBorder count=" + count.ToString() + "\n");

                borderLength = 0;
                objectArea = 0;
                xCOG = 0;
                yCOG = 0;
                xMax = 0;
                xMin = temp.Height;
                yMax = 0;
                yMin = temp.Width;

                Parallel.Invoke(() => GetFeatureSet(count), () => GetFeatureSetEdge(count));

                objectArea /= 2;
                xCOG /= 6 * objectArea;
                yCOG /= 6 * objectArea;
                objectPx = (xMax - xCOG) / (xCOG - xMin);
                objectPy = (yMax - yCOG) / (yCOG - yMin);
                objectCompactness = 4 * Math.PI * objectArea / (borderLength * borderLength);
                objectArea /= temp.Height * temp.Width;

                textBox.AppendText(string.Format("Compactness= {0} ;" + "\n", objectCompactness));
                textBox.AppendText(string.Format("Area= {0} ;\n", objectArea));
                textBox.AppendText(string.Format("\nPx= {0} ; Py= {1} ;\n", objectPx, objectPy));
                textBox.AppendText(new String('-', 58));
            }
            else
            {
                textBox.AppendText("Object detection error...\n");
                objectArea = 0;
                objectCompactness = 0;
                objectPx = 0;
                objectPy = 0;
            }

            unsafe
            {
                int width = temp.Width;
                byte* p = (byte*)Scan0;
                int nOffset = stride - temp.Width * 3;

                int finished;
                Task[] t = new Task[Environment.ProcessorCount];
                for (int x = 0; x < Environment.ProcessorCount; x++)
                {
                    int xTemp = x;
                    byte* pTemp = p;
                    t[x] = Task.Factory.StartNew(() => CopyImageBack(pTemp, xTemp, width));
                    p += stride;
                }
                for (int x = Environment.ProcessorCount; x < temp.Height; x++)
                {
                    int xTemp = x;
                    byte* pTemp = p;
                    finished = Task.WaitAny(t);
                    t[finished] = Task.Factory.StartNew(() => CopyImageBack(pTemp, xTemp, width));

                    p += stride;
                }
                Task.WaitAll(t);
            }
            temp.UnlockBits(bmData);
            return temp.Clone() as Image;
        }

        private void GetFeatureSet(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if ((int)borderX[i] > xMax)
                    xMax = (int)borderX[i];
                if ((int)borderX[i] < xMin)
                    xMin = (int)borderX[i];
                if (i == 0)
                {
                    borderLength += Math.Sqrt(((int)borderX[count - 1] - (int)borderX[i]) * ((int)borderX[count - 1] - (int)borderX[i])
                        + ((int)borderY[count - 1] - (int)borderY[i]) * ((int)borderY[count - 1] - (int)borderY[i]));                   
                    objectArea += (int)borderX[count - 1] * (int)borderY[i] - (int)borderX[i] * (int)borderY[count - 1];
                }
                else
                {
                    borderLength += Math.Sqrt(((int)borderX[i - 1] - (int)borderX[i]) * ((int)borderX[i - 1] - (int)borderX[i])
                        + ((int)borderY[i - 1] - (int)borderY[i]) * ((int)borderY[i - 1] - (int)borderY[i]));
                    objectArea += (int)borderX[i - 1] * (int)borderY[i] - (int)borderX[i] * (int)borderY[i - 1];
                }
                processedImage[(int)borderX[i], (int)borderY[i]] = 128;
            }
        }

        private void GetFeatureSetEdge(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if ((int)borderY[i] > yMax)
                    yMax = (int)borderY[i];
                if ((int)borderY[i] < yMin)
                    yMin = (int)borderY[i];

                if (i == 0)
                {
                    xCOG += ((int)borderX[count - 1] * (int)borderY[i] - (int)borderX[i] * (int)borderY[count - 1]) * ((int)borderX[count - 1] + (int)borderX[i]);
                    yCOG += ((int)borderX[count - 1] * (int)borderY[i] - (int)borderX[i] * (int)borderY[count - 1]) * ((int)borderY[count - 1] + (int)borderY[i]);
                }
                else
                {
                    xCOG += ((int)borderX[i - 1] * (int)borderY[i] - (int)borderX[i] * (int)borderY[i - 1]) * ((int)borderX[i - 1] + (int)borderX[i]);
                    yCOG += ((int)borderX[i - 1] * (int)borderY[i] - (int)borderX[i] * (int)borderY[i - 1]) * ((int)borderY[i - 1] + (int)borderY[i]);
                }
            }
        }

        unsafe private void CopyImageBack(byte* q, int x, int width)
        {
            for (int y = 0; y < width; y++)
            {
                if (processedImage[x, y] == 128)
                {
                    q[1] = 220;
                    q[0] = q[2] = 0;
                }
                else
                {
                    q[0] = q[1] = q[2] = processedImage[x, y];
                }
                q += 3;
            }
        }

        public string GetGesture(List<Gesture> dictionary)
        {
            if (dictionary.Count <= 0) return Constants.Messages.DictEmpty;
            foreach (var item in dictionary)
            {
                if (objectCompactness <= item.Compactness + Constants.Accuracy && objectCompactness >= item.Compactness - Constants.Accuracy)
                {
                    if (objectArea <= item.Area + Constants.Accuracy && objectArea >= item.Area - Constants.Accuracy)
                    {
                        if (objectPx <= item.Px + Constants.Accuracy && objectPx >= item.Px - Constants.Accuracy)
                        {
                            if (objectPy <= item.Py + Constants.Accuracy && objectPy >= item.Py - Constants.Accuracy)
                            {
                                return item.Name.ToString();
                            }
                        }
                    }
                }
            }       
            return Constants.Messages.Unknown;
        }

        public Gesture CaptureGesture()
        {
            Gesture gesture = new Gesture();
            gesture.Area = objectArea;
            gesture.Compactness = objectCompactness;
            gesture.Px = objectPx;
            gesture.Py = objectPy;
            return gesture;
        }
    }
}
