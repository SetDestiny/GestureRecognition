namespace GestureRecognition
{
    partial class GestureCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestureCreationForm));
            this.captureGestureButton = new MetroFramework.Controls.MetroButton();
            this.gestureNameLabel = new MetroFramework.Controls.MetroLabel();
            this.gestureNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.gestureAreaLabel = new MetroFramework.Controls.MetroLabel();
            this.gestureAreaTextBox = new MetroFramework.Controls.MetroTextBox();
            this.gestureCompactnessTextBox = new MetroFramework.Controls.MetroTextBox();
            this.gestureCompactnessLabel = new MetroFramework.Controls.MetroLabel();
            this.gesturePxTextBox = new MetroFramework.Controls.MetroTextBox();
            this.gesturePxLabel = new MetroFramework.Controls.MetroLabel();
            this.gesturePyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.gesturePyLabel = new MetroFramework.Controls.MetroLabel();
            this.gestureSaveButton = new MetroFramework.Controls.MetroButton();
            this.gestureTestButton = new MetroFramework.Controls.MetroButton();
            this.gestureCancelButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // captureGestureButton
            // 
            this.captureGestureButton.Location = new System.Drawing.Point(266, 82);
            this.captureGestureButton.Name = "captureGestureButton";
            this.captureGestureButton.Size = new System.Drawing.Size(174, 20);
            this.captureGestureButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.captureGestureButton.TabIndex = 0;
            this.captureGestureButton.Text = "Capture";
            this.captureGestureButton.UseSelectable = true;
            this.captureGestureButton.Click += new System.EventHandler(this.captureGestureButton_Click);
            // 
            // gestureNameLabel
            // 
            this.gestureNameLabel.AutoSize = true;
            this.gestureNameLabel.Location = new System.Drawing.Point(23, 60);
            this.gestureNameLabel.Name = "gestureNameLabel";
            this.gestureNameLabel.Size = new System.Drawing.Size(45, 19);
            this.gestureNameLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.gestureNameLabel.TabIndex = 1;
            this.gestureNameLabel.Text = "Name";
            // 
            // gestureNameTextBox
            // 
            // 
            // 
            // 
            this.gestureNameTextBox.CustomButton.Image = null;
            this.gestureNameTextBox.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.gestureNameTextBox.CustomButton.Name = "";
            this.gestureNameTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.gestureNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gestureNameTextBox.CustomButton.TabIndex = 1;
            this.gestureNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gestureNameTextBox.CustomButton.UseSelectable = true;
            this.gestureNameTextBox.CustomButton.Visible = false;
            this.gestureNameTextBox.Lines = new string[0];
            this.gestureNameTextBox.Location = new System.Drawing.Point(23, 82);
            this.gestureNameTextBox.MaxLength = 32767;
            this.gestureNameTextBox.Name = "gestureNameTextBox";
            this.gestureNameTextBox.PasswordChar = '\0';
            this.gestureNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gestureNameTextBox.SelectedText = "";
            this.gestureNameTextBox.SelectionLength = 0;
            this.gestureNameTextBox.SelectionStart = 0;
            this.gestureNameTextBox.ShortcutsEnabled = true;
            this.gestureNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.gestureNameTextBox.TabIndex = 2;
            this.gestureNameTextBox.UseSelectable = true;
            this.gestureNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gestureNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gestureAreaLabel
            // 
            this.gestureAreaLabel.AutoSize = true;
            this.gestureAreaLabel.Location = new System.Drawing.Point(23, 105);
            this.gestureAreaLabel.Name = "gestureAreaLabel";
            this.gestureAreaLabel.Size = new System.Drawing.Size(37, 19);
            this.gestureAreaLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.gestureAreaLabel.TabIndex = 3;
            this.gestureAreaLabel.Text = "Area";
            // 
            // gestureAreaTextBox
            // 
            // 
            // 
            // 
            this.gestureAreaTextBox.CustomButton.Image = null;
            this.gestureAreaTextBox.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.gestureAreaTextBox.CustomButton.Name = "";
            this.gestureAreaTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.gestureAreaTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gestureAreaTextBox.CustomButton.TabIndex = 1;
            this.gestureAreaTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gestureAreaTextBox.CustomButton.UseSelectable = true;
            this.gestureAreaTextBox.CustomButton.Visible = false;
            this.gestureAreaTextBox.Enabled = false;
            this.gestureAreaTextBox.Lines = new string[0];
            this.gestureAreaTextBox.Location = new System.Drawing.Point(23, 127);
            this.gestureAreaTextBox.MaxLength = 32767;
            this.gestureAreaTextBox.Name = "gestureAreaTextBox";
            this.gestureAreaTextBox.PasswordChar = '\0';
            this.gestureAreaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gestureAreaTextBox.SelectedText = "";
            this.gestureAreaTextBox.SelectionLength = 0;
            this.gestureAreaTextBox.SelectionStart = 0;
            this.gestureAreaTextBox.ShortcutsEnabled = true;
            this.gestureAreaTextBox.Size = new System.Drawing.Size(209, 20);
            this.gestureAreaTextBox.TabIndex = 4;
            this.gestureAreaTextBox.UseSelectable = true;
            this.gestureAreaTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gestureAreaTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gestureCompactnessTextBox
            // 
            // 
            // 
            // 
            this.gestureCompactnessTextBox.CustomButton.Image = null;
            this.gestureCompactnessTextBox.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.gestureCompactnessTextBox.CustomButton.Name = "";
            this.gestureCompactnessTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.gestureCompactnessTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gestureCompactnessTextBox.CustomButton.TabIndex = 1;
            this.gestureCompactnessTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gestureCompactnessTextBox.CustomButton.UseSelectable = true;
            this.gestureCompactnessTextBox.CustomButton.Visible = false;
            this.gestureCompactnessTextBox.Enabled = false;
            this.gestureCompactnessTextBox.Lines = new string[0];
            this.gestureCompactnessTextBox.Location = new System.Drawing.Point(23, 172);
            this.gestureCompactnessTextBox.MaxLength = 32767;
            this.gestureCompactnessTextBox.Name = "gestureCompactnessTextBox";
            this.gestureCompactnessTextBox.PasswordChar = '\0';
            this.gestureCompactnessTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gestureCompactnessTextBox.SelectedText = "";
            this.gestureCompactnessTextBox.SelectionLength = 0;
            this.gestureCompactnessTextBox.SelectionStart = 0;
            this.gestureCompactnessTextBox.ShortcutsEnabled = true;
            this.gestureCompactnessTextBox.Size = new System.Drawing.Size(209, 20);
            this.gestureCompactnessTextBox.TabIndex = 6;
            this.gestureCompactnessTextBox.UseSelectable = true;
            this.gestureCompactnessTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gestureCompactnessTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gestureCompactnessLabel
            // 
            this.gestureCompactnessLabel.AutoSize = true;
            this.gestureCompactnessLabel.Location = new System.Drawing.Point(23, 150);
            this.gestureCompactnessLabel.Name = "gestureCompactnessLabel";
            this.gestureCompactnessLabel.Size = new System.Drawing.Size(87, 19);
            this.gestureCompactnessLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.gestureCompactnessLabel.TabIndex = 5;
            this.gestureCompactnessLabel.Text = "Compactness";
            // 
            // gesturePxTextBox
            // 
            // 
            // 
            // 
            this.gesturePxTextBox.CustomButton.Image = null;
            this.gesturePxTextBox.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.gesturePxTextBox.CustomButton.Name = "";
            this.gesturePxTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.gesturePxTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gesturePxTextBox.CustomButton.TabIndex = 1;
            this.gesturePxTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gesturePxTextBox.CustomButton.UseSelectable = true;
            this.gesturePxTextBox.CustomButton.Visible = false;
            this.gesturePxTextBox.Enabled = false;
            this.gesturePxTextBox.Lines = new string[0];
            this.gesturePxTextBox.Location = new System.Drawing.Point(23, 217);
            this.gesturePxTextBox.MaxLength = 32767;
            this.gesturePxTextBox.Name = "gesturePxTextBox";
            this.gesturePxTextBox.PasswordChar = '\0';
            this.gesturePxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gesturePxTextBox.SelectedText = "";
            this.gesturePxTextBox.SelectionLength = 0;
            this.gesturePxTextBox.SelectionStart = 0;
            this.gesturePxTextBox.ShortcutsEnabled = true;
            this.gesturePxTextBox.Size = new System.Drawing.Size(209, 20);
            this.gesturePxTextBox.TabIndex = 8;
            this.gesturePxTextBox.UseSelectable = true;
            this.gesturePxTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gesturePxTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gesturePxLabel
            // 
            this.gesturePxLabel.AutoSize = true;
            this.gesturePxLabel.Location = new System.Drawing.Point(23, 195);
            this.gesturePxLabel.Name = "gesturePxLabel";
            this.gesturePxLabel.Size = new System.Drawing.Size(23, 19);
            this.gesturePxLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.gesturePxLabel.TabIndex = 7;
            this.gesturePxLabel.Text = "Px";
            // 
            // gesturePyTextBox
            // 
            // 
            // 
            // 
            this.gesturePyTextBox.CustomButton.Image = null;
            this.gesturePyTextBox.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.gesturePyTextBox.CustomButton.Name = "";
            this.gesturePyTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.gesturePyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gesturePyTextBox.CustomButton.TabIndex = 1;
            this.gesturePyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gesturePyTextBox.CustomButton.UseSelectable = true;
            this.gesturePyTextBox.CustomButton.Visible = false;
            this.gesturePyTextBox.Enabled = false;
            this.gesturePyTextBox.Lines = new string[0];
            this.gesturePyTextBox.Location = new System.Drawing.Point(23, 262);
            this.gesturePyTextBox.MaxLength = 32767;
            this.gesturePyTextBox.Name = "gesturePyTextBox";
            this.gesturePyTextBox.PasswordChar = '\0';
            this.gesturePyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gesturePyTextBox.SelectedText = "";
            this.gesturePyTextBox.SelectionLength = 0;
            this.gesturePyTextBox.SelectionStart = 0;
            this.gesturePyTextBox.ShortcutsEnabled = true;
            this.gesturePyTextBox.Size = new System.Drawing.Size(209, 20);
            this.gesturePyTextBox.TabIndex = 10;
            this.gesturePyTextBox.UseSelectable = true;
            this.gesturePyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gesturePyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gesturePyLabel
            // 
            this.gesturePyLabel.AutoSize = true;
            this.gesturePyLabel.Location = new System.Drawing.Point(23, 240);
            this.gesturePyLabel.Name = "gesturePyLabel";
            this.gesturePyLabel.Size = new System.Drawing.Size(23, 19);
            this.gesturePyLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.gesturePyLabel.TabIndex = 9;
            this.gesturePyLabel.Text = "Px";
            // 
            // gestureSaveButton
            // 
            this.gestureSaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gestureSaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.gestureSaveButton.Location = new System.Drawing.Point(266, 108);
            this.gestureSaveButton.Name = "gestureSaveButton";
            this.gestureSaveButton.Size = new System.Drawing.Size(174, 20);
            this.gestureSaveButton.TabIndex = 11;
            this.gestureSaveButton.Text = "Save";
            this.gestureSaveButton.UseSelectable = true;
            this.gestureSaveButton.Click += new System.EventHandler(this.gestureSaveButton_Click);
            // 
            // gestureTestButton
            // 
            this.gestureTestButton.Location = new System.Drawing.Point(266, 134);
            this.gestureTestButton.Name = "gestureTestButton";
            this.gestureTestButton.Size = new System.Drawing.Size(174, 20);
            this.gestureTestButton.TabIndex = 12;
            this.gestureTestButton.Text = "Test";
            this.gestureTestButton.UseSelectable = true;
            this.gestureTestButton.Click += new System.EventHandler(this.gestureTestButton_Click);
            // 
            // gestureCancelButton
            // 
            this.gestureCancelButton.Location = new System.Drawing.Point(266, 160);
            this.gestureCancelButton.Name = "gestureCancelButton";
            this.gestureCancelButton.Size = new System.Drawing.Size(174, 20);
            this.gestureCancelButton.TabIndex = 13;
            this.gestureCancelButton.Text = "Cancel";
            this.gestureCancelButton.UseSelectable = true;
            this.gestureCancelButton.Click += new System.EventHandler(this.gestureCancelButton_Click);
            // 
            // GestureCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 308);
            this.Controls.Add(this.gestureCancelButton);
            this.Controls.Add(this.gestureTestButton);
            this.Controls.Add(this.gestureSaveButton);
            this.Controls.Add(this.gesturePyTextBox);
            this.Controls.Add(this.gesturePyLabel);
            this.Controls.Add(this.gesturePxTextBox);
            this.Controls.Add(this.gesturePxLabel);
            this.Controls.Add(this.gestureCompactnessTextBox);
            this.Controls.Add(this.gestureCompactnessLabel);
            this.Controls.Add(this.gestureAreaTextBox);
            this.Controls.Add(this.gestureAreaLabel);
            this.Controls.Add(this.gestureNameTextBox);
            this.Controls.Add(this.gestureNameLabel);
            this.Controls.Add(this.captureGestureButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestureCreationForm";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Gesture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestureCreationForm_FormClosing);
            this.Load += new System.EventHandler(this.GestureCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox gestureNameTextBox;
        private MetroFramework.Controls.MetroTextBox gestureAreaTextBox;
        private MetroFramework.Controls.MetroTextBox gestureCompactnessTextBox;
        private MetroFramework.Controls.MetroTextBox gesturePxTextBox;
        private MetroFramework.Controls.MetroTextBox gesturePyTextBox;
        private MetroFramework.Controls.MetroButton captureGestureButton;
        private MetroFramework.Controls.MetroLabel gestureNameLabel;
        private MetroFramework.Controls.MetroLabel gestureAreaLabel;
        private MetroFramework.Controls.MetroLabel gestureCompactnessLabel;
        private MetroFramework.Controls.MetroLabel gesturePxLabel;
        private MetroFramework.Controls.MetroLabel gesturePyLabel;
        private MetroFramework.Controls.MetroButton gestureSaveButton;
        private MetroFramework.Controls.MetroButton gestureTestButton;
        private MetroFramework.Controls.MetroButton gestureCancelButton;
    }
}