namespace ImageCompressor
{
    partial class ImageCompressorForm
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
            CompressButton = new Button();
            Finalart = new PictureBox();
            Address = new TextBox();
            progressBar = new ProgressBar();
            Please = new Label();
            SaveImageButton = new Button();
            FolderButton = new Button();
            rBrigTextBox = new TextBox();
            gBrigTextBox = new TextBox();
            bBrigTextbox = new TextBox();
            ForegroundColorTextBox = new TextBox();
            rBrigLabel = new Label();
            gBrigLabel = new Label();
            bBrigLabel = new Label();
            BackgroundColorTextBox = new TextBox();
            Foregroundcolor = new Label();
            Backgroundcolor = new Label();
            RforegroundTrackBar = new TrackBar();
            GforegroundTrackBar = new TrackBar();
            BforegroundTrackBar = new TrackBar();
            RbackgroundTrackBar = new TrackBar();
            GbackgroundTrackBar = new TrackBar();
            BbackgroundTrackBar = new TrackBar();
            Rforeground = new Label();
            Gforeground = new Label();
            Bforeground = new Label();
            Bbackground = new Label();
            Gbackground = new Label();
            Rbackground = new Label();
            rfore_count = new Label();
            gfore_count = new Label();
            bfore_count = new Label();
            rback_count = new Label();
            gback_count = new Label();
            bback_count = new Label();
            ClearButton = new Button();
            BackGroundTestColor = new PictureBox();
            ForeGroundTestColor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Finalart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RforegroundTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GforegroundTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BforegroundTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RbackgroundTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GbackgroundTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BbackgroundTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackGroundTestColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ForeGroundTestColor).BeginInit();
            SuspendLayout();
            // 
            // CompressButton
            // 
            CompressButton.Location = new Point(14, 167);
            CompressButton.Name = "CompressButton";
            CompressButton.Size = new Size(86, 31);
            CompressButton.TabIndex = 0;
            CompressButton.Text = "Compress";
            CompressButton.UseVisualStyleBackColor = true;
            CompressButton.Click += CompressButton_Click;
            // 
            // Finalart
            // 
            Finalart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Finalart.BackgroundImageLayout = ImageLayout.Stretch;
            Finalart.Location = new Point(367, 12);
            Finalart.Name = "Finalart";
            Finalart.Size = new Size(421, 426);
            Finalart.TabIndex = 1;
            Finalart.TabStop = false;
            // 
            // Address
            // 
            Address.Location = new Point(49, 39);
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Size = new Size(312, 23);
            Address.TabIndex = 2;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(8, 150);
            progressBar.Maximum = 10;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(349, 11);
            progressBar.TabIndex = 3;
            // 
            // Please
            // 
            Please.AutoSize = true;
            Please.Location = new Point(12, 12);
            Please.Name = "Please";
            Please.Size = new Size(219, 15);
            Please.TabIndex = 4;
            Please.Text = "Please, send a path of the image  further";
            // 
            // SaveImageButton
            // 
            SaveImageButton.Location = new Point(232, 167);
            SaveImageButton.Name = "SaveImageButton";
            SaveImageButton.Size = new Size(86, 31);
            SaveImageButton.TabIndex = 5;
            SaveImageButton.Text = "Save image";
            SaveImageButton.UseVisualStyleBackColor = true;
            SaveImageButton.Click += SaveImageButton_Click;
            // 
            // FolderButton
            // 
            FolderButton.BackgroundImage = Properties.Resources.folder;
            FolderButton.BackgroundImageLayout = ImageLayout.Zoom;
            FolderButton.Location = new Point(12, 35);
            FolderButton.Name = "FolderButton";
            FolderButton.Size = new Size(32, 28);
            FolderButton.TabIndex = 6;
            FolderButton.UseVisualStyleBackColor = true;
            FolderButton.Click += button3_Click;
            // 
            // rBrigTextBox
            // 
            rBrigTextBox.Location = new Point(49, 68);
            rBrigTextBox.Name = "rBrigTextBox";
            rBrigTextBox.Size = new Size(100, 23);
            rBrigTextBox.TabIndex = 7;
            // 
            // gBrigTextBox
            // 
            gBrigTextBox.Location = new Point(49, 97);
            gBrigTextBox.Name = "gBrigTextBox";
            gBrigTextBox.Size = new Size(100, 23);
            gBrigTextBox.TabIndex = 8;
            // 
            // bBrigTextbox
            // 
            bBrigTextbox.Location = new Point(49, 126);
            bBrigTextbox.Name = "bBrigTextbox";
            bBrigTextbox.Size = new Size(100, 23);
            bBrigTextbox.TabIndex = 9;
            // 
            // ForegroundColorTextBox
            // 
            ForegroundColorTextBox.Location = new Point(261, 68);
            ForegroundColorTextBox.Name = "ForegroundColorTextBox";
            ForegroundColorTextBox.ReadOnly = true;
            ForegroundColorTextBox.Size = new Size(100, 23);
            ForegroundColorTextBox.TabIndex = 10;
            // 
            // rBrigLabel
            // 
            rBrigLabel.AutoSize = true;
            rBrigLabel.Location = new Point(8, 71);
            rBrigLabel.Name = "rBrigLabel";
            rBrigLabel.Size = new Size(38, 15);
            rBrigLabel.TabIndex = 11;
            rBrigLabel.Text = "R brig";
            // 
            // gBrigLabel
            // 
            gBrigLabel.AutoSize = true;
            gBrigLabel.Location = new Point(8, 100);
            gBrigLabel.Name = "gBrigLabel";
            gBrigLabel.Size = new Size(39, 15);
            gBrigLabel.TabIndex = 12;
            gBrigLabel.Text = "G brig";
            // 
            // bBrigLabel
            // 
            bBrigLabel.AutoSize = true;
            bBrigLabel.Location = new Point(8, 132);
            bBrigLabel.Name = "bBrigLabel";
            bBrigLabel.Size = new Size(38, 15);
            bBrigLabel.TabIndex = 13;
            bBrigLabel.Text = "B brig";
            // 
            // BackgroundColorTextBox
            // 
            BackgroundColorTextBox.Location = new Point(261, 97);
            BackgroundColorTextBox.Name = "BackgroundColorTextBox";
            BackgroundColorTextBox.ReadOnly = true;
            BackgroundColorTextBox.Size = new Size(100, 23);
            BackgroundColorTextBox.TabIndex = 14;
            // 
            // Foregroundcolor
            // 
            Foregroundcolor.AutoSize = true;
            Foregroundcolor.Location = new Point(158, 76);
            Foregroundcolor.Name = "Foregroundcolor";
            Foregroundcolor.Size = new Size(99, 15);
            Foregroundcolor.TabIndex = 15;
            Foregroundcolor.Text = "Foreground color";
            // 
            // Backgroundcolor
            // 
            Backgroundcolor.AutoSize = true;
            Backgroundcolor.Location = new Point(156, 100);
            Backgroundcolor.Name = "Backgroundcolor";
            Backgroundcolor.Size = new Size(101, 15);
            Backgroundcolor.TabIndex = 16;
            Backgroundcolor.Text = "Background color";
            // 
            // RforegroundTrackBar
            // 
            RforegroundTrackBar.Location = new Point(12, 227);
            RforegroundTrackBar.Maximum = 255;
            RforegroundTrackBar.Name = "RforegroundTrackBar";
            RforegroundTrackBar.Size = new Size(104, 45);
            RforegroundTrackBar.TabIndex = 0;
            // 
            // GforegroundTrackBar
            // 
            GforegroundTrackBar.Location = new Point(127, 227);
            GforegroundTrackBar.Maximum = 255;
            GforegroundTrackBar.Name = "GforegroundTrackBar";
            GforegroundTrackBar.Size = new Size(104, 45);
            GforegroundTrackBar.TabIndex = 0;
            // 
            // BforegroundTrackBar
            // 
            BforegroundTrackBar.Location = new Point(232, 227);
            BforegroundTrackBar.Maximum = 255;
            BforegroundTrackBar.Name = "BforegroundTrackBar";
            BforegroundTrackBar.Size = new Size(104, 45);
            BforegroundTrackBar.TabIndex = 0;
            // 
            // RbackgroundTrackBar
            // 
            RbackgroundTrackBar.Location = new Point(12, 337);
            RbackgroundTrackBar.Maximum = 255;
            RbackgroundTrackBar.Name = "RbackgroundTrackBar";
            RbackgroundTrackBar.Size = new Size(104, 45);
            RbackgroundTrackBar.TabIndex = 20;
            // 
            // GbackgroundTrackBar
            // 
            GbackgroundTrackBar.Location = new Point(122, 337);
            GbackgroundTrackBar.Maximum = 255;
            GbackgroundTrackBar.Name = "GbackgroundTrackBar";
            GbackgroundTrackBar.Size = new Size(104, 45);
            GbackgroundTrackBar.TabIndex = 21;
            // 
            // BbackgroundTrackBar
            // 
            BbackgroundTrackBar.Location = new Point(232, 337);
            BbackgroundTrackBar.Maximum = 255;
            BbackgroundTrackBar.Name = "BbackgroundTrackBar";
            BbackgroundTrackBar.Size = new Size(104, 45);
            BbackgroundTrackBar.TabIndex = 22;
            // 
            // Rforeground
            // 
            Rforeground.AutoSize = true;
            Rforeground.Location = new Point(14, 209);
            Rforeground.Name = "Rforeground";
            Rforeground.Size = new Size(80, 15);
            Rforeground.TabIndex = 23;
            Rforeground.Text = " R foreground";
            // 
            // Gforeground
            // 
            Gforeground.AutoSize = true;
            Gforeground.Location = new Point(127, 209);
            Gforeground.Name = "Gforeground";
            Gforeground.Size = new Size(78, 15);
            Gforeground.TabIndex = 24;
            Gforeground.Text = "G foreground";
            // 
            // Bforeground
            // 
            Bforeground.AutoSize = true;
            Bforeground.Location = new Point(232, 209);
            Bforeground.Name = "Bforeground";
            Bforeground.Size = new Size(77, 15);
            Bforeground.TabIndex = 25;
            Bforeground.Text = "B foreground";
            // 
            // Bbackground
            // 
            Bbackground.AutoSize = true;
            Bbackground.Location = new Point(232, 319);
            Bbackground.Name = "Bbackground";
            Bbackground.Size = new Size(81, 15);
            Bbackground.TabIndex = 26;
            Bbackground.Text = "B background";
            Bbackground.Click += label2_Click;
            // 
            // Gbackground
            // 
            Gbackground.AutoSize = true;
            Gbackground.Location = new Point(127, 319);
            Gbackground.Name = "Gbackground";
            Gbackground.Size = new Size(82, 15);
            Gbackground.TabIndex = 27;
            Gbackground.Text = "G background";
            // 
            // Rbackground
            // 
            Rbackground.AutoSize = true;
            Rbackground.Location = new Point(14, 319);
            Rbackground.Name = "Rbackground";
            Rbackground.Size = new Size(81, 15);
            Rbackground.TabIndex = 28;
            Rbackground.Text = "R background";
            // 
            // rfore_count
            // 
            rfore_count.AutoSize = true;
            rfore_count.Location = new Point(39, 257);
            rfore_count.Name = "rfore_count";
            rfore_count.Size = new Size(0, 15);
            rfore_count.TabIndex = 29;
            // 
            // gfore_count
            // 
            gfore_count.AutoSize = true;
            gfore_count.Location = new Point(156, 257);
            gfore_count.Name = "gfore_count";
            gfore_count.Size = new Size(0, 15);
            gfore_count.TabIndex = 30;
            // 
            // bfore_count
            // 
            bfore_count.AutoSize = true;
            bfore_count.Location = new Point(261, 257);
            bfore_count.Name = "bfore_count";
            bfore_count.Size = new Size(0, 15);
            bfore_count.TabIndex = 31;
            // 
            // rback_count
            // 
            rback_count.AutoSize = true;
            rback_count.Location = new Point(39, 367);
            rback_count.Name = "rback_count";
            rback_count.Size = new Size(0, 15);
            rback_count.TabIndex = 32;
            // 
            // gback_count
            // 
            gback_count.AutoSize = true;
            gback_count.Location = new Point(156, 367);
            gback_count.Name = "gback_count";
            gback_count.Size = new Size(0, 15);
            gback_count.TabIndex = 33;
            // 
            // bback_count
            // 
            bback_count.AutoSize = true;
            bback_count.Location = new Point(261, 367);
            bback_count.Name = "bback_count";
            bback_count.Size = new Size(0, 15);
            bback_count.TabIndex = 34;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(127, 167);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(86, 31);
            ClearButton.TabIndex = 35;
            ClearButton.Text = "Clear image";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // BackGroundTestColor
            // 
            BackGroundTestColor.Location = new Point(156, 406);
            BackGroundTestColor.Name = "BackGroundTestColor";
            BackGroundTestColor.Size = new Size(35, 32);
            BackGroundTestColor.TabIndex = 36;
            BackGroundTestColor.TabStop = false;
            // 
            // ForeGroundTestColor
            // 
            ForeGroundTestColor.Location = new Point(156, 278);
            ForeGroundTestColor.Name = "ForeGroundTestColor";
            ForeGroundTestColor.Size = new Size(35, 32);
            ForeGroundTestColor.TabIndex = 37;
            ForeGroundTestColor.TabStop = false;
            // 
            // ImageCompressorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ForeGroundTestColor);
            Controls.Add(BackGroundTestColor);
            Controls.Add(ClearButton);
            Controls.Add(bback_count);
            Controls.Add(gback_count);
            Controls.Add(rback_count);
            Controls.Add(bfore_count);
            Controls.Add(gfore_count);
            Controls.Add(rfore_count);
            Controls.Add(Rbackground);
            Controls.Add(Gbackground);
            Controls.Add(Bbackground);
            Controls.Add(Bforeground);
            Controls.Add(Gforeground);
            Controls.Add(Rforeground);
            Controls.Add(BbackgroundTrackBar);
            Controls.Add(GbackgroundTrackBar);
            Controls.Add(RbackgroundTrackBar);
            Controls.Add(BforegroundTrackBar);
            Controls.Add(GforegroundTrackBar);
            Controls.Add(RforegroundTrackBar);
            Controls.Add(Backgroundcolor);
            Controls.Add(Foregroundcolor);
            Controls.Add(BackgroundColorTextBox);
            Controls.Add(bBrigLabel);
            Controls.Add(gBrigLabel);
            Controls.Add(rBrigLabel);
            Controls.Add(ForegroundColorTextBox);
            Controls.Add(bBrigTextbox);
            Controls.Add(gBrigTextBox);
            Controls.Add(rBrigTextBox);
            Controls.Add(FolderButton);
            Controls.Add(SaveImageButton);
            Controls.Add(Please);
            Controls.Add(progressBar);
            Controls.Add(Address);
            Controls.Add(Finalart);
            Controls.Add(CompressButton);
            Name = "ImageCompressorForm";
            Text = "Image Compressor";
            Click += label2_Click;
            ((System.ComponentModel.ISupportInitialize)Finalart).EndInit();
            ((System.ComponentModel.ISupportInitialize)RforegroundTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GforegroundTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BforegroundTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)RbackgroundTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GbackgroundTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BbackgroundTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackGroundTestColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)ForeGroundTestColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CompressButton;
        private PictureBox Finalart;
        private TextBox Address;
        private ProgressBar progressBar;
        private Label Please;
        private Button SaveImageButton;
        private Button FolderButton;
        private TextBox rBrigTextBox;
        private TextBox gBrigTextBox;
        private TextBox bBrigTextbox;
        private TextBox ForegroundColorTextBox;
        private Label rBrigLabel;
        private Label gBrigLabel;
        private Label bBrigLabel;
        private TextBox BackgroundColorTextBox;
        private Label Foregroundcolor;
        private Label Backgroundcolor;
        private TrackBar RforegroundTrackBar;
        private TrackBar GforegroundTrackBar;
        private TrackBar BforegroundTrackBar;
        private TrackBar RbackgroundTrackBar;
        private TrackBar GbackgroundTrackBar;
        private TrackBar BbackgroundTrackBar;
        private Label Rforeground;
        private Label Gforeground;
        private Label Bforeground;
        private Label Bbackground;
        private Label Gbackground;
        private Label Rbackground;
        private Label rfore_count;
        private Label gfore_count;
        private Label bfore_count;
        private Label rback_count;
        private Label gback_count;
        private Label bback_count;
        private Button ClearButton;
        private PictureBox BackGroundTestColor;
        private PictureBox ForeGroundTestColor;
    }
}
