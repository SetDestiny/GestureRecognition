namespace GestureRecognition
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cameraComboBox = new MetroFramework.Controls.MetroComboBox();
            this.startButton = new MetroFramework.Controls.MetroButton();
            this.capturedImage = new System.Windows.Forms.PictureBox();
            this.stopButton = new MetroFramework.Controls.MetroButton();
            this.webcamImage = new System.Windows.Forms.PictureBox();
            this.textBox = new MetroFramework.Controls.MetroTextBox();
            this.detectedWebCamsLabel = new MetroFramework.Controls.MetroLabel();
            this.recognizedGesture = new MetroFramework.Controls.MetroTextBox();
            this.gestureRecognitionTimer = new System.Windows.Forms.Timer(this.components);
            this.thresholdLabel = new MetroFramework.Controls.MetroLabel();
            this.sourceLabel = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.newGestureButton = new MetroFramework.Controls.MetroButton();
            this.thresholdMetroTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.thresholdValueLabel = new MetroFramework.Controls.MetroLabel();
            this.gestureLogTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.capturedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcamImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.ItemHeight = 23;
            this.cameraComboBox.Location = new System.Drawing.Point(16, 84);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(360, 29);
            this.cameraComboBox.TabIndex = 0;
            this.cameraComboBox.UseSelectable = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(382, 84);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(140, 29);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseSelectable = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // capturedImage
            // 
            this.capturedImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.capturedImage.Location = new System.Drawing.Point(16, 182);
            this.capturedImage.Name = "capturedImage";
            this.capturedImage.Size = new System.Drawing.Size(640, 480);
            this.capturedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capturedImage.TabIndex = 2;
            this.capturedImage.TabStop = false;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(528, 84);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(140, 29);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseSelectable = true;
            this.stopButton.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // webcamImage
            // 
            this.webcamImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.webcamImage.Location = new System.Drawing.Point(662, 182);
            this.webcamImage.Name = "webcamImage";
            this.webcamImage.Size = new System.Drawing.Size(320, 240);
            this.webcamImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.webcamImage.TabIndex = 7;
            this.webcamImage.TabStop = false;
            // 
            // textBox
            // 
            // 
            // 
            // 
            this.textBox.CustomButton.Image = null;
            this.textBox.CustomButton.Location = new System.Drawing.Point(-158, 2);
            this.textBox.CustomButton.Name = "";
            this.textBox.CustomButton.Size = new System.Drawing.Size(475, 475);
            this.textBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox.CustomButton.TabIndex = 1;
            this.textBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox.CustomButton.UseSelectable = true;
            this.textBox.CustomButton.Visible = false;
            this.textBox.Lines = new string[0];
            this.textBox.Location = new System.Drawing.Point(988, 182);
            this.textBox.MaxLength = 32767;
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.SelectedText = "";
            this.textBox.SelectionLength = 0;
            this.textBox.SelectionStart = 0;
            this.textBox.ShortcutsEnabled = true;
            this.textBox.Size = new System.Drawing.Size(320, 480);
            this.textBox.TabIndex = 9;
            this.textBox.UseSelectable = true;
            this.textBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // detectedWebCamsLabel
            // 
            this.detectedWebCamsLabel.AutoSize = true;
            this.detectedWebCamsLabel.Location = new System.Drawing.Point(16, 60);
            this.detectedWebCamsLabel.Name = "detectedWebCamsLabel";
            this.detectedWebCamsLabel.Size = new System.Drawing.Size(132, 19);
            this.detectedWebCamsLabel.TabIndex = 13;
            this.detectedWebCamsLabel.Text = "Detected Web-Cams";
            // 
            // recognizedGesture
            // 
            this.recognizedGesture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            this.recognizedGesture.CustomButton.Image = null;
            this.recognizedGesture.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.recognizedGesture.CustomButton.Name = "";
            this.recognizedGesture.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.recognizedGesture.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.recognizedGesture.CustomButton.TabIndex = 1;
            this.recognizedGesture.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.recognizedGesture.CustomButton.UseSelectable = true;
            this.recognizedGesture.CustomButton.Visible = false;
            this.recognizedGesture.Lines = new string[0];
            this.recognizedGesture.Location = new System.Drawing.Point(674, 84);
            this.recognizedGesture.MaxLength = 32767;
            this.recognizedGesture.Name = "recognizedGesture";
            this.recognizedGesture.PasswordChar = '\0';
            this.recognizedGesture.ReadOnly = true;
            this.recognizedGesture.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.recognizedGesture.SelectedText = "";
            this.recognizedGesture.SelectionLength = 0;
            this.recognizedGesture.SelectionStart = 0;
            this.recognizedGesture.ShortcutsEnabled = true;
            this.recognizedGesture.Size = new System.Drawing.Size(300, 29);
            this.recognizedGesture.TabIndex = 14;
            this.recognizedGesture.UseSelectable = true;
            this.recognizedGesture.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.recognizedGesture.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gestureRecognitionTimer
            // 
            this.gestureRecognitionTimer.Interval = 1000;
            this.gestureRecognitionTimer.Tick += new System.EventHandler(this.gestureRecognitionTimer_Tick);
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(23, 116);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(69, 19);
            this.thresholdLabel.TabIndex = 15;
            this.thresholdLabel.Text = "Threshold:";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(662, 157);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(88, 19);
            this.sourceLabel.TabIndex = 16;
            this.sourceLabel.Text = "Source steam";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Proccesed steam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Last recognized gesture";
            // 
            // newGestureButton
            // 
            this.newGestureButton.Enabled = false;
            this.newGestureButton.Location = new System.Drawing.Point(980, 84);
            this.newGestureButton.Name = "newGestureButton";
            this.newGestureButton.Size = new System.Drawing.Size(320, 29);
            this.newGestureButton.TabIndex = 18;
            this.newGestureButton.Text = "Create Gesture";
            this.newGestureButton.UseSelectable = true;
            this.newGestureButton.Click += new System.EventHandler(this.newGestureButton_Click);
            // 
            // thresholdMetroTrackBar
            // 
            this.thresholdMetroTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.thresholdMetroTrackBar.LargeChange = 1;
            this.thresholdMetroTrackBar.Location = new System.Drawing.Point(16, 131);
            this.thresholdMetroTrackBar.Maximum = 255;
            this.thresholdMetroTrackBar.Name = "thresholdMetroTrackBar";
            this.thresholdMetroTrackBar.Size = new System.Drawing.Size(360, 23);
            this.thresholdMetroTrackBar.TabIndex = 19;
            this.thresholdMetroTrackBar.Text = "metroTrackBar1";
            this.thresholdMetroTrackBar.Value = 125;
            this.thresholdMetroTrackBar.ValueChanged += new System.EventHandler(this.thresholdMetroTrackBar_ValueChanged);
            // 
            // thresholdValueLabel
            // 
            this.thresholdValueLabel.Location = new System.Drawing.Point(98, 116);
            this.thresholdValueLabel.Name = "thresholdValueLabel";
            this.thresholdValueLabel.Size = new System.Drawing.Size(150, 22);
            this.thresholdValueLabel.TabIndex = 20;
            this.thresholdValueLabel.Text = "0";
            // 
            // gestureLogTextBox
            // 
            // 
            // 
            // 
            this.gestureLogTextBox.CustomButton.Image = null;
            this.gestureLogTextBox.CustomButton.Location = new System.Drawing.Point(88, 2);
            this.gestureLogTextBox.CustomButton.Name = "";
            this.gestureLogTextBox.CustomButton.Size = new System.Drawing.Size(229, 229);
            this.gestureLogTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gestureLogTextBox.CustomButton.TabIndex = 1;
            this.gestureLogTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gestureLogTextBox.CustomButton.UseSelectable = true;
            this.gestureLogTextBox.CustomButton.Visible = false;
            this.gestureLogTextBox.Lines = new string[0];
            this.gestureLogTextBox.Location = new System.Drawing.Point(662, 428);
            this.gestureLogTextBox.MaxLength = 32767;
            this.gestureLogTextBox.Multiline = true;
            this.gestureLogTextBox.Name = "gestureLogTextBox";
            this.gestureLogTextBox.PasswordChar = '\0';
            this.gestureLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gestureLogTextBox.SelectedText = "";
            this.gestureLogTextBox.SelectionLength = 0;
            this.gestureLogTextBox.SelectionStart = 0;
            this.gestureLogTextBox.ShortcutsEnabled = true;
            this.gestureLogTextBox.Size = new System.Drawing.Size(320, 234);
            this.gestureLogTextBox.TabIndex = 21;
            this.gestureLogTextBox.UseSelectable = true;
            this.gestureLogTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gestureLogTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 680);
            this.Controls.Add(this.gestureLogTextBox);
            this.Controls.Add(this.thresholdValueLabel);
            this.Controls.Add(this.thresholdMetroTrackBar);
            this.Controls.Add(this.newGestureButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.thresholdLabel);
            this.Controls.Add(this.recognizedGesture);
            this.Controls.Add(this.detectedWebCamsLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.webcamImage);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.capturedImage);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cameraComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Gesture Recognition App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capturedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcamImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox capturedImage;
        private System.Windows.Forms.PictureBox webcamImage;
        private MetroFramework.Controls.MetroTextBox textBox;
        private MetroFramework.Controls.MetroTextBox recognizedGesture;
        private System.Windows.Forms.Timer gestureRecognitionTimer;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cameraComboBox;
        private MetroFramework.Controls.MetroTrackBar thresholdMetroTrackBar;
        private MetroFramework.Controls.MetroButton startButton;
        private MetroFramework.Controls.MetroButton stopButton;
        private MetroFramework.Controls.MetroButton newGestureButton;
        private MetroFramework.Controls.MetroLabel thresholdLabel;
        private MetroFramework.Controls.MetroLabel thresholdValueLabel;
        private MetroFramework.Controls.MetroLabel detectedWebCamsLabel;
        private MetroFramework.Controls.MetroLabel sourceLabel;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroTextBox gestureLogTextBox;
    }
}

