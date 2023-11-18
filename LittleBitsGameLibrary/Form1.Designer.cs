namespace LittleBitsGameLibrary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            aboutThisAppToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            loadGameYAMLFileToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            GameSelect = new ComboBox();
            GamePicture = new PictureBox();
            label2 = new Label();
            GameName = new TextBox();
            GameDev = new TextBox();
            label3 = new Label();
            GameDesc = new TextBox();
            button1 = new Button();
            label4 = new Label();
            GameGenre = new TextBox();
            FileName = new TextBox();
            label5 = new Label();
            ReloadButton = new Button();
            ClearButton = new Button();
            toolTip1 = new ToolTip(components);
            gameFileDialog = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GamePicture).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(664, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem, aboutThisAppToolStripMenuItem, toolStripSeparator1, loadGameYAMLFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(189, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // aboutThisAppToolStripMenuItem
            // 
            aboutThisAppToolStripMenuItem.Name = "aboutThisAppToolStripMenuItem";
            aboutThisAppToolStripMenuItem.Size = new Size(189, 22);
            aboutThisAppToolStripMenuItem.Text = "About This App";
            aboutThisAppToolStripMenuItem.Click += aboutThisAppToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(186, 6);
            // 
            // loadGameYAMLFileToolStripMenuItem
            // 
            loadGameYAMLFileToolStripMenuItem.Name = "loadGameYAMLFileToolStripMenuItem";
            loadGameYAMLFileToolStripMenuItem.Size = new Size(189, 22);
            loadGameYAMLFileToolStripMenuItem.Text = "Load Game YAML File";
            loadGameYAMLFileToolStripMenuItem.Click += loadGameYAMLFileToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 34);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Game: ";
            // 
            // GameSelect
            // 
            GameSelect.FormattingEnabled = true;
            GameSelect.Location = new Point(71, 31);
            GameSelect.Name = "GameSelect";
            GameSelect.Size = new Size(482, 23);
            GameSelect.TabIndex = 2;
            GameSelect.SelectedIndexChanged += GameSelect_SelectedIndexChanged;
            // 
            // GamePicture
            // 
            GamePicture.Location = new Point(18, 65);
            GamePicture.Name = "GamePicture";
            GamePicture.Size = new Size(137, 132);
            GamePicture.SizeMode = PictureBoxSizeMode.Zoom;
            GamePicture.TabIndex = 3;
            GamePicture.TabStop = false;
            toolTip1.SetToolTip(GamePicture, "Click to add/change image");
            GamePicture.Click += GamePicture_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 201);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 4;
            label2.Text = "click above to change image";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameName
            // 
            GameName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            GameName.Location = new Point(164, 88);
            GameName.Name = "GameName";
            GameName.PlaceholderText = "Game Name";
            GameName.Size = new Size(488, 39);
            GameName.TabIndex = 5;
            // 
            // GameDev
            // 
            GameDev.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GameDev.Location = new Point(164, 133);
            GameDev.Name = "GameDev";
            GameDev.PlaceholderText = "Developer";
            GameDev.Size = new Size(488, 23);
            GameDev.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 115);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // GameDesc
            // 
            GameDesc.AcceptsReturn = true;
            GameDesc.AcceptsTab = true;
            GameDesc.Location = new Point(18, 233);
            GameDesc.Multiline = true;
            GameDesc.Name = "GameDesc";
            GameDesc.PlaceholderText = "Description";
            GameDesc.Size = new Size(627, 170);
            GameDesc.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(573, 409);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 167);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 10;
            label4.Text = "Genre:";
            // 
            // GameGenre
            // 
            GameGenre.Location = new Point(218, 164);
            GameGenre.Name = "GameGenre";
            GameGenre.Size = new Size(207, 23);
            GameGenre.TabIndex = 11;
            // 
            // FileName
            // 
            FileName.Location = new Point(500, 164);
            FileName.Name = "FileName";
            FileName.Size = new Size(148, 23);
            FileName.TabIndex = 13;
            FileName.TextChanged += FileName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 168);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 12;
            label5.Text = "File Name:";
            label5.Click += label5_Click;
            // 
            // ReloadButton
            // 
            ReloadButton.Location = new Point(559, 31);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.Size = new Size(93, 23);
            ReloadButton.TabIndex = 14;
            ReloadButton.Text = "Reload List";
            ReloadButton.UseVisualStyleBackColor = true;
            ReloadButton.Click += ReloadButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(476, 409);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(91, 23);
            ClearButton.TabIndex = 15;
            ClearButton.Text = "Clear Fields";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += button2_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // gameFileDialog
            // 
            gameFileDialog.Filter = "YAML file|*.yaml";
            gameFileDialog.FileOk += gameFileDialog_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 444);
            Controls.Add(ClearButton);
            Controls.Add(ReloadButton);
            Controls.Add(FileName);
            Controls.Add(label5);
            Controls.Add(GameGenre);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(GameDesc);
            Controls.Add(label3);
            Controls.Add(GameDev);
            Controls.Add(GameName);
            Controls.Add(label2);
            Controls.Add(GamePicture);
            Controls.Add(GameSelect);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "LittleBit Game Library";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GamePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem aboutThisAppToolStripMenuItem;
        private Label label1;
        private ComboBox GameSelect;
        private Label label2;
        private TextBox GameName;
        private TextBox GameDev;
        private Label label3;
        private TextBox GameDesc;
        private Button button1;
        private Label label4;
        private TextBox GameGenre;
        private TextBox FileName;
        private Label label5;
        private Button ReloadButton;
        private Button ClearButton;
        private ToolTip toolTip1;
        public PictureBox GamePicture;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem loadGameYAMLFileToolStripMenuItem;
        private OpenFileDialog gameFileDialog;
    }
}