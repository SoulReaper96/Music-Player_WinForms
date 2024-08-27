namespace MusicApp_Forms
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            btnPrevious = new Button();
            pbarSong = new ProgressBar();
            lblElapsed = new Label();
            lblCurrentSong = new Label();
            btnOpen = new Button();
            lblStatus = new Label();
            btnNext = new Button();
            btnStop = new Button();
            btnPause = new Button();
            btnPlay = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            volumeSlider = new NAudio.Gui.VolumeSlider();
            panel2 = new Panel();
            label1 = new Label();
            MinApp_pb = new PictureBox();
            MaxApp_pb = new PictureBox();
            RestApp_pb = new PictureBox();
            CloseApp_pb = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1 = new Panel();
            btnSettings = new Button();
            btnRepeatOnce = new Button();
            btnMenu = new Button();
            btnShuffle = new Button();
            btnRepeat = new Button();
            btnAddtoList = new Button();
            btnShowList = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinApp_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxApp_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestApp_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseApp_pb).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.BackgroundImage = (Image)resources.GetObject("btnPrevious.BackgroundImage");
            btnPrevious.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Location = new Point(156, 16);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(40, 40);
            btnPrevious.TabIndex = 2;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // pbarSong
            // 
            pbarSong.ForeColor = Color.Green;
            pbarSong.Location = new Point(12, 66);
            pbarSong.Name = "pbarSong";
            pbarSong.Size = new Size(555, 10);
            pbarSong.TabIndex = 3;
            // 
            // lblElapsed
            // 
            lblElapsed.AutoSize = true;
            lblElapsed.Font = new Font("Arial", 14F);
            lblElapsed.Location = new Point(12, 3);
            lblElapsed.Name = "lblElapsed";
            lblElapsed.Size = new Size(123, 22);
            lblElapsed.TabIndex = 4;
            lblElapsed.Text = "00:00 / 00:00";
            // 
            // lblCurrentSong
            // 
            lblCurrentSong.AutoSize = true;
            lblCurrentSong.Location = new Point(340, 6);
            lblCurrentSong.Name = "lblCurrentSong";
            lblCurrentSong.Size = new Size(48, 15);
            lblCurrentSong.TabIndex = 8;
            lblCurrentSong.Text = "Current";
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Yellow;
            btnOpen.BackgroundImage = (Image)resources.GetObject("btnOpen.BackgroundImage");
            btnOpen.BackgroundImageLayout = ImageLayout.Stretch;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Location = new Point(600, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(60, 60);
            btnOpen.TabIndex = 7;
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(151, 6);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:";
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(340, 16);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 40);
            btnNext.TabIndex = 6;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnStop
            // 
            btnStop.BackgroundImage = (Image)resources.GetObject("btnStop.BackgroundImage");
            btnStop.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Location = new Point(294, 16);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(40, 40);
            btnStop.TabIndex = 5;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnPause
            // 
            btnPause.BackgroundImage = (Image)resources.GetObject("btnPause.BackgroundImage");
            btnPause.BackgroundImageLayout = ImageLayout.Stretch;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Location = new Point(248, 16);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(40, 40);
            btnPause.TabIndex = 4;
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackgroundImage = (Image)resources.GetObject("btnPlay.BackgroundImage");
            btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Location = new Point(202, 16);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(40, 40);
            btnPlay.TabIndex = 3;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCoral;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(151, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 259);
            panel3.TabIndex = 13;
            // 
            // volumeSlider
            // 
            volumeSlider.Location = new Point(513, 6);
            volumeSlider.Name = "volumeSlider";
            volumeSlider.Size = new Size(96, 16);
            volumeSlider.TabIndex = 10;
            volumeSlider.VolumeChanged += volumeSlider_VolumeChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(MinApp_pb);
            panel2.Controls.Add(MaxApp_pb);
            panel2.Controls.Add(RestApp_pb);
            panel2.Controls.Add(CloseApp_pb);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 35);
            panel2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 17;
            label1.Text = "Music Player";
            // 
            // MinApp_pb
            // 
            MinApp_pb.BackColor = Color.Yellow;
            MinApp_pb.BackgroundImage = (Image)resources.GetObject("MinApp_pb.BackgroundImage");
            MinApp_pb.BackgroundImageLayout = ImageLayout.Stretch;
            MinApp_pb.Location = new Point(530, 2);
            MinApp_pb.Name = "MinApp_pb";
            MinApp_pb.Size = new Size(30, 30);
            MinApp_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            MinApp_pb.TabIndex = 13;
            MinApp_pb.TabStop = false;
            MinApp_pb.Click += MinApp_pb_Click_1;
            // 
            // MaxApp_pb
            // 
            MaxApp_pb.BackColor = Color.Yellow;
            MaxApp_pb.BackgroundImage = (Image)resources.GetObject("MaxApp_pb.BackgroundImage");
            MaxApp_pb.BackgroundImageLayout = ImageLayout.Stretch;
            MaxApp_pb.Location = new Point(602, 2);
            MaxApp_pb.Name = "MaxApp_pb";
            MaxApp_pb.Size = new Size(30, 30);
            MaxApp_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            MaxApp_pb.TabIndex = 12;
            MaxApp_pb.TabStop = false;
            MaxApp_pb.Click += MaxApp_pb_Click;
            // 
            // RestApp_pb
            // 
            RestApp_pb.BackColor = Color.Yellow;
            RestApp_pb.BackgroundImage = (Image)resources.GetObject("RestApp_pb.BackgroundImage");
            RestApp_pb.BackgroundImageLayout = ImageLayout.Stretch;
            RestApp_pb.Location = new Point(566, 2);
            RestApp_pb.Name = "RestApp_pb";
            RestApp_pb.Size = new Size(30, 30);
            RestApp_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            RestApp_pb.TabIndex = 11;
            RestApp_pb.TabStop = false;
            RestApp_pb.Click += RestApp_pb_Click;
            // 
            // CloseApp_pb
            // 
            CloseApp_pb.BackColor = Color.Yellow;
            CloseApp_pb.BackgroundImage = (Image)resources.GetObject("CloseApp_pb.BackgroundImage");
            CloseApp_pb.BackgroundImageLayout = ImageLayout.Stretch;
            CloseApp_pb.Location = new Point(638, 2);
            CloseApp_pb.Name = "CloseApp_pb";
            CloseApp_pb.Size = new Size(30, 30);
            CloseApp_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseApp_pb.TabIndex = 10;
            CloseApp_pb.TabStop = false;
            CloseApp_pb.Click += CloseApp_pb_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Controls.Add(volumeSlider);
            panel4.Controls.Add(lblCurrentSong);
            panel4.Controls.Add(lblElapsed);
            panel4.Controls.Add(lblStatus);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 470);
            panel4.Name = "panel4";
            panel4.Size = new Size(672, 30);
            panel4.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Yellow;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(642, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(30, 347);
            panel5.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 35);
            panel6.Name = "panel6";
            panel6.Size = new Size(30, 347);
            panel6.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnRepeatOnce);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnShuffle);
            panel1.Controls.Add(btnRepeat);
            panel1.Controls.Add(btnAddtoList);
            panel1.Controls.Add(btnShowList);
            panel1.Controls.Add(btnOpen);
            panel1.Controls.Add(pbarSong);
            panel1.Controls.Add(btnPlay);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnPause);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 382);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 88);
            panel1.TabIndex = 11;
            // 
            // btnSettings
            // 
            btnSettings.BackgroundImage = (Image)resources.GetObject("btnSettings.BackgroundImage");
            btnSettings.BackgroundImageLayout = ImageLayout.Stretch;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Location = new Point(546, 16);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(40, 40);
            btnSettings.TabIndex = 14;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnRepeatOnce
            // 
            btnRepeatOnce.BackgroundImage = (Image)resources.GetObject("btnRepeatOnce.BackgroundImage");
            btnRepeatOnce.BackgroundImageLayout = ImageLayout.Stretch;
            btnRepeatOnce.FlatStyle = FlatStyle.Flat;
            btnRepeatOnce.Location = new Point(104, 16);
            btnRepeatOnce.Name = "btnRepeatOnce";
            btnRepeatOnce.Size = new Size(40, 40);
            btnRepeatOnce.TabIndex = 12;
            btnRepeatOnce.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImage = (Image)resources.GetObject("btnMenu.BackgroundImage");
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(500, 16);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(40, 40);
            btnMenu.TabIndex = 13;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnShuffle
            // 
            btnShuffle.BackgroundImage = (Image)resources.GetObject("btnShuffle.BackgroundImage");
            btnShuffle.BackgroundImageLayout = ImageLayout.Stretch;
            btnShuffle.FlatStyle = FlatStyle.Flat;
            btnShuffle.Location = new Point(12, 16);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(40, 40);
            btnShuffle.TabIndex = 11;
            btnShuffle.UseVisualStyleBackColor = true;
            // 
            // btnRepeat
            // 
            btnRepeat.BackgroundImage = (Image)resources.GetObject("btnRepeat.BackgroundImage");
            btnRepeat.BackgroundImageLayout = ImageLayout.Stretch;
            btnRepeat.FlatStyle = FlatStyle.Flat;
            btnRepeat.Location = new Point(58, 16);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Size = new Size(40, 40);
            btnRepeat.TabIndex = 10;
            btnRepeat.UseVisualStyleBackColor = true;
            // 
            // btnAddtoList
            // 
            btnAddtoList.BackgroundImage = (Image)resources.GetObject("btnAddtoList.BackgroundImage");
            btnAddtoList.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddtoList.FlatStyle = FlatStyle.Flat;
            btnAddtoList.Location = new Point(432, 16);
            btnAddtoList.Name = "btnAddtoList";
            btnAddtoList.Size = new Size(40, 40);
            btnAddtoList.TabIndex = 9;
            btnAddtoList.UseVisualStyleBackColor = true;
            // 
            // btnShowList
            // 
            btnShowList.BackgroundImage = (Image)resources.GetObject("btnShowList.BackgroundImage");
            btnShowList.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowList.FlatStyle = FlatStyle.Flat;
            btnShowList.Location = new Point(386, 16);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(40, 40);
            btnShowList.TabIndex = 8;
            btnShowList.UseVisualStyleBackColor = true;
            btnShowList.Click += btnShowList_Click;
            // 
            // MusicPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(672, 500);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Font = new Font("Arial", 9F);
            ForeColor = Color.RoyalBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusicPlayer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinApp_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxApp_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestApp_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseApp_pb).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnPrevious;
        private ProgressBar pbarSong;
        private Label lblElapsed;
        private Button btnStop;
        private Button btnPause;
        private Button btnPlay;
        private Button btnNext;
        private Button btnOpen;
        private Label lblStatus;
        private Label lblCurrentSong;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel1;
        private NAudio.Gui.VolumeSlider volumeSlider;
        private PictureBox RestApp_pb;
        private PictureBox CloseApp_pb;
        private PictureBox MaxApp_pb;
        private Button btnShowList;
        private PictureBox MinApp_pb;
        private Button btnAddtoList;
        private Label label1;
        private Button btnRepeatOnce;
        private Button btnShuffle;
        private Button btnRepeat;
        private Button btnSettings;
        private Button btnMenu;
    }
}
