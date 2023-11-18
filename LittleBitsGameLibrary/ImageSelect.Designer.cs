namespace LittleBitsGameLibrary
{
    partial class ImageSelect
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
            label1 = new Label();
            textBox1 = new TextBox();
            OpenFileButton = new Button();
            OKButton = new Button();
            CancelButton = new Button();
            imageOpenDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Image Link / File Path:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 23);
            textBox1.TabIndex = 1;
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new Point(440, 42);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(98, 23);
            OpenFileButton.TabIndex = 2;
            OpenFileButton.Text = "Open File";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(463, 74);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 3;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(382, 74);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // imageOpenDialog
            // 
            imageOpenDialog.Title = "Select image file";
            imageOpenDialog.FileOk += imageOpenDialog_FileOk;
            // 
            // ImageSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 114);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(OpenFileButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ImageSelect";
            Text = "ImageSelect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button OpenFileButton;
        private Button OKButton;
        private Button CancelButton;
        private OpenFileDialog imageOpenDialog;
        public TextBox textBox1;
    }
}