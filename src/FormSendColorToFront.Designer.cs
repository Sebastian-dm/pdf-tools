namespace pdf_tools {
    partial class FormSendColorToFront {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            buttonColorPicker = new Button();
            textBoxColor = new TextBox();
            buttonFolderPicker = new Button();
            textBoxPath = new TextBox();
            checkBoxCopyFile = new CheckBox();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // buttonColorPicker
            // 
            buttonColorPicker.Location = new Point(33, 25);
            buttonColorPicker.Name = "buttonColorPicker";
            buttonColorPicker.Size = new Size(75, 23);
            buttonColorPicker.TabIndex = 0;
            buttonColorPicker.Text = "Pick color";
            buttonColorPicker.UseVisualStyleBackColor = true;
            buttonColorPicker.Click += button1_Click;
            // 
            // textBoxColor
            // 
            textBoxColor.BackColor = Color.Magenta;
            textBoxColor.BorderStyle = BorderStyle.FixedSingle;
            textBoxColor.Enabled = false;
            textBoxColor.ForeColor = Color.Black;
            textBoxColor.Location = new Point(124, 25);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.ReadOnly = true;
            textBoxColor.Size = new Size(32, 23);
            textBoxColor.TabIndex = 1;
            // 
            // buttonFolderPicker
            // 
            buttonFolderPicker.Location = new Point(33, 54);
            buttonFolderPicker.Name = "buttonFolderPicker";
            buttonFolderPicker.Size = new Size(75, 23);
            buttonFolderPicker.TabIndex = 2;
            buttonFolderPicker.Text = "Pick folder";
            buttonFolderPicker.UseVisualStyleBackColor = true;
            buttonFolderPicker.Click += buttonFolderPicker_Click;
            // 
            // textBoxFolder
            // 
            textBoxPath.Location = new Point(124, 55);
            textBoxPath.Name = "textBoxFolder";
            textBoxPath.Size = new Size(315, 23);
            textBoxPath.TabIndex = 3;
            textBoxPath.Text = "...";
            // 
            // checkBoxCopyFile
            // 
            checkBoxCopyFile.AutoSize = true;
            checkBoxCopyFile.Checked = true;
            checkBoxCopyFile.CheckState = CheckState.Checked;
            checkBoxCopyFile.Location = new Point(33, 83);
            checkBoxCopyFile.Name = "checkBoxCopyFile";
            checkBoxCopyFile.Size = new Size(187, 19);
            checkBoxCopyFile.TabIndex = 4;
            checkBoxCopyFile.Text = "Save file as a copy in subfolder";
            checkBoxCopyFile.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(33, 127);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // FormSendColorToFront
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 162);
            Controls.Add(buttonStart);
            Controls.Add(checkBoxCopyFile);
            Controls.Add(textBoxPath);
            Controls.Add(buttonFolderPicker);
            Controls.Add(textBoxColor);
            Controls.Add(buttonColorPicker);
            Name = "FormSendColorToFront";
            Text = "Send color to front";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonColorPicker;
        private TextBox textBoxColor;
        private Button buttonFolderPicker;
        private TextBox textBoxPath;
        private CheckBox checkBoxCopyFile;
        private Button buttonStart;
    }
}
