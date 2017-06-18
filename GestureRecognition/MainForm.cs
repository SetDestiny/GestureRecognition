using AForge.Video;
using AForge.Video.DirectShow;
using GestureRecognition.BLL.AForgeHelper;
using GestureRecognition.DAL.DataAccess;
using GestureRecognition.DAL.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GestureRecognition
{
    public partial class MainForm : MetroForm
    {
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        Bitmap newFrame;
        FrameHelper frameHelper;
        List<Gesture> dictionary;
        SQLiteDA da;

        public MainForm()
        {
            InitializeComponent();
            frameHelper = new FrameHelper();
            this.da = new SQLiteDA();
            dictionary = this.da.GetGestures();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                stopButton.Enabled = false;
                thresholdValueLabel.Text = thresholdMetroTrackBar.Value.ToString();

                if (videoDevices.Count == 0)
                {
                    throw new Exception();
                }

                for (int i = 0; i < videoDevices.Count; i++)
                {
                    string cameraName = i + " : " + videoDevices[i].Name;

                    cameraComboBox.Items.Add(cameraName);
                }
                cameraComboBox.SelectedIndex = 0;
            }
            catch
            {
                startButton.Enabled = false;
                cameraComboBox.Items.Add("No video devices...");
                cameraComboBox.SelectedIndex = 0;
                cameraComboBox.Enabled = false;
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            newFrame = (Bitmap)eventArgs.Frame.Clone();
            ProcessFrame();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
            }
        }

        private void ProcessFrame()
        {
            int threshold = Convert.ToInt16(thresholdMetroTrackBar.Value);
            Bitmap temp = new Bitmap(newFrame);
            webcamImage.Image = frameHelper.ProcessFrame(threshold, temp);
        }

        private void CaptureAndProcces()
        {
            capturedImage.Image = frameHelper.CaptureAndProcces(ref webcamImage, ref textBox);
        }

        private void GetGesture()
        {
            var gestureName = frameHelper.GetGesture(dictionary);
            recognizedGesture.Text = gestureName;

            if (gestureName != Constants.Messages.DictEmpty && gestureName != Constants.Messages.Unknown)
            {
                gestureLogTextBox.AppendText(string.Format("{0}; ", gestureName));
            }
            gestureName = Constants.Messages.Unknown;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GetGesture();
            videoSource = new VideoCaptureDevice(videoDevices[cameraComboBox.SelectedIndex].MonikerString);
            videoSource.DesiredFrameRate = 30;
            videoSource.DesiredFrameSize = new Size(480, 640);

            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();

            newGestureButton.Enabled = true;
            startButton.Enabled = false;
            stopButton.Enabled = true;
            gestureRecognitionTimer.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            newGestureButton.Enabled = false;
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            CaptureAndProcces();
            GetGesture();
        }

        private void gestureRecognitionTimer_Tick(object sender, EventArgs e)
        {
            if (stopButton.Enabled == true)
            {
                CaptureAndProcces();
                GetGesture();
            }
        }

        private void newGestureButton_Click(object sender, EventArgs e)
        {
            GestureCreationForm gestureCreationForm = new GestureCreationForm(ref frameHelper, ref dictionary);
            gestureCreationForm.ShowDialog();
        }

        private void thresholdMetroTrackBar_ValueChanged(object sender, EventArgs e)
        {
            thresholdValueLabel.Text = thresholdMetroTrackBar.Value.ToString();
        }
    }
}
