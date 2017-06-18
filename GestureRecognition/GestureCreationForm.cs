using GestureRecognition.BLL.AForgeHelper;
using GestureRecognition.DAL.DataAccess;
using GestureRecognition.DAL.Models;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestureRecognition
{
    public partial class GestureCreationForm : MetroForm
    {
        Gesture gesture;
        FrameHelper frameHelper;
        List<Gesture> dictionary;

        private void GestureCreationForm_Load(object sender, EventArgs e)
        {
            gestureTestButton.Enabled = false;
            gestureSaveButton.Enabled = false;
        }

        public GestureCreationForm(ref FrameHelper _frameHelper, ref List<Gesture> _dictionary)
        {
            InitializeComponent();
            this.frameHelper = _frameHelper;
            this.dictionary = _dictionary;
        }

        private void captureGestureButton_Click(object sender, EventArgs e)
        {
            gesture = frameHelper.CaptureGesture();
            gestureAreaTextBox.Text = gesture.Area.ToString();
            gestureCompactnessTextBox.Text = gesture.Compactness.ToString();
            gesturePxTextBox.Text = gesture.Px.ToString();
            gesturePyTextBox.Text = gesture.Py.ToString();

            gestureTestButton.Enabled = true;
            gestureSaveButton.Enabled = true;
        }

        private void gestureTestButton_Click(object sender, EventArgs e)
        {
            if (gestureNameTextBox.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Gesture name is required. Please fill it, and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if ((dictionary.Where(i => i.Id == -1)).ToList().Count <= 0)
                {
                    gesture.Name = gestureNameTextBox.Text;
                    gesture.Id = -1;
                    dictionary.Add(gesture);
                }
                else
                {
                    var item = dictionary.Where(i => i.Id == -1).First();
                    item = gesture;
                    item.Name = gestureNameTextBox.Text;
                }
                MetroMessageBox.Show(this, "Test data has been successfully added to dictionary. You can test your gesture before save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MetroMessageBox.Show(this, "Oops! Something went wrong. Failed to add test data to dictionary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gestureCancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                gesture.Name = gestureNameTextBox.Text;
                dictionary.Remove(gesture);
                MetroMessageBox.Show(this, "Test data has been removed from dictionary.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MetroMessageBox.Show(this, "Dictionary has no test data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            gestureNameTextBox.Text = string.Empty;
            gestureAreaTextBox.Text = string.Empty;
            gestureCompactnessTextBox.Text = string.Empty;
            gesturePxTextBox.Text = string.Empty;
            gesturePyTextBox.Text = string.Empty;

            gestureSaveButton.Enabled = false;
            gestureTestButton.Enabled = false;

        }

        private void gestureSaveButton_Click(object sender, EventArgs e)
        {
            if (gestureNameTextBox.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Gesture name is required. Please fill it, and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SQLiteDA da = new SQLiteDA();

            try
            {
                gesture.Name = gestureNameTextBox.Text;
                da.InsertGesture(gesture);
                MetroMessageBox.Show(this, "Data has been successfully added to database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Oops! Something went wrong. Gesture insert to database failed." + ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var gesturesList = da.GetGestures();
            dictionary.Clear();
            dictionary.AddRange(gesturesList);
        }

        private void GestureCreationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gesture.Name = gestureNameTextBox.Text;
                dictionary.Remove(gesture);
            }
            catch
            {

            }
        }
    }
}
