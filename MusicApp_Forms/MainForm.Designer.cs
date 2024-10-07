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
            btnOpen = new Button();
            lblStatus = new Label();
            btnNext = new Button();
            btnStop = new Button();
            btnPause = new Button();
            btnPlay = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            VolumeTrackbar = new TrackBar();
            panel1 = new Panel();
            btnRemove = new Button();
            btnSettings = new Button();
            btnRepeatOnce = new Button();
            btnMenu = new Button();
            btnShuffle = new Button();
            btnRepeat = new Button();
            btnAddtoList = new Button();
            btnShowList = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            toolStripDropDownButton4 = new ToolStripDropDownButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            panel2 = new Panel();
            songList_dgv = new DataGridView();
            TrackTitle = new DataGridViewTextBoxColumn();
            TrackArtist = new DataGridViewTextBoxColumn();
            TrackAlbum = new DataGridViewTextBoxColumn();
            TrackGenre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VolumeTrackbar).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)songList_dgv).BeginInit();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.BackgroundImage = (Image)resources.GetObject("btnPrevious.BackgroundImage");
            btnPrevious.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Location = new Point(120, 32);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(40, 40);
            btnPrevious.TabIndex = 2;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // pbarSong
            // 
            pbarSong.ForeColor = Color.Green;
            pbarSong.Location = new Point(12, 11);
            pbarSong.Name = "pbarSong";
            pbarSong.Size = new Size(986, 15);
            pbarSong.TabIndex = 3;
            pbarSong.MouseDown += pbarSong_MouseDown;
            // 
            // lblElapsed
            // 
            lblElapsed.AutoSize = true;
            lblElapsed.Font = new Font("Arial", 14F);
            lblElapsed.Location = new Point(1010, 4);
            lblElapsed.Name = "lblElapsed";
            lblElapsed.Size = new Size(123, 22);
            lblElapsed.TabIndex = 4;
            lblElapsed.Text = "00:00 / 00:00";
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Yellow;
            btnOpen.BackgroundImage = (Image)resources.GetObject("btnOpen.BackgroundImage");
            btnOpen.BackgroundImageLayout = ImageLayout.Stretch;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Location = new Point(654, 32);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(60, 47);
            btnOpen.TabIndex = 7;
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(1010, 35);
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
            btnNext.Location = new Point(212, 32);
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
            btnStop.Location = new Point(166, 32);
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
            btnPause.Location = new Point(58, 32);
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
            btnPlay.Location = new Point(12, 32);
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
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // VolumeTrackbar
            // 
            VolumeTrackbar.AutoSize = false;
            VolumeTrackbar.Location = new Point(798, 35);
            VolumeTrackbar.Maximum = 100;
            VolumeTrackbar.Name = "VolumeTrackbar";
            VolumeTrackbar.Size = new Size(200, 22);
            VolumeTrackbar.TabIndex = 10;
            VolumeTrackbar.TickStyle = TickStyle.None;
            VolumeTrackbar.Value = 50;
            VolumeTrackbar.Scroll += VolumeTrackbar_Scroll;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(pbarSong);
            panel1.Controls.Add(lblElapsed);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(VolumeTrackbar);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnRepeatOnce);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnShuffle);
            panel1.Controls.Add(btnRepeat);
            panel1.Controls.Add(btnAddtoList);
            panel1.Controls.Add(btnShowList);
            panel1.Controls.Add(btnOpen);
            panel1.Controls.Add(btnPlay);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(btnPause);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 561);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 88);
            panel1.TabIndex = 11;
            // 
            // btnRemove
            // 
            btnRemove.BackgroundImage = (Image)resources.GetObject("btnRemove.BackgroundImage");
            btnRemove.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Location = new Point(720, 32);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(40, 40);
            btnRemove.TabIndex = 15;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackgroundImage = (Image)resources.GetObject("btnSettings.BackgroundImage");
            btnSettings.BackgroundImageLayout = ImageLayout.Stretch;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Location = new Point(609, 32);
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
            btnRepeatOnce.Location = new Point(365, 32);
            btnRepeatOnce.Name = "btnRepeatOnce";
            btnRepeatOnce.Size = new Size(40, 40);
            btnRepeatOnce.TabIndex = 12;
            btnRepeatOnce.UseVisualStyleBackColor = true;
            btnRepeatOnce.Click += btnRepeatOnce_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImage = (Image)resources.GetObject("btnMenu.BackgroundImage");
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(563, 32);
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
            btnShuffle.Location = new Point(273, 32);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(40, 40);
            btnShuffle.TabIndex = 11;
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += btnShuffle_Click;
            // 
            // btnRepeat
            // 
            btnRepeat.BackgroundImage = (Image)resources.GetObject("btnRepeat.BackgroundImage");
            btnRepeat.BackgroundImageLayout = ImageLayout.Stretch;
            btnRepeat.FlatStyle = FlatStyle.Flat;
            btnRepeat.Location = new Point(319, 32);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Size = new Size(40, 40);
            btnRepeat.TabIndex = 10;
            btnRepeat.UseVisualStyleBackColor = true;
            btnRepeat.Click += btnRepeat_Click;
            // 
            // btnAddtoList
            // 
            btnAddtoList.BackgroundImage = (Image)resources.GetObject("btnAddtoList.BackgroundImage");
            btnAddtoList.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddtoList.FlatStyle = FlatStyle.Flat;
            btnAddtoList.Location = new Point(495, 32);
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
            btnShowList.Location = new Point(449, 32);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(40, 40);
            btnShowList.TabIndex = 8;
            btnShowList.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Yellow;
            toolStrip1.Font = new Font("Arial", 10F, FontStyle.Bold);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton3, toolStripDropDownButton4, toolStripDropDownButton1, toolStripDropDownButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1145, 25);
            toolStrip1.TabIndex = 18;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(63, 22);
            toolStripDropDownButton3.Text = "Media";
            // 
            // toolStripDropDownButton4
            // 
            toolStripDropDownButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton4.Image = (Image)resources.GetObject("toolStripDropDownButton4.Image");
            toolStripDropDownButton4.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            toolStripDropDownButton4.Size = new Size(81, 22);
            toolStripDropDownButton4.Text = "Playback";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(60, 22);
            toolStripDropDownButton1.Text = "Audio";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(57, 22);
            toolStripDropDownButton2.Text = "Tools";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 536);
            panel2.TabIndex = 15;
            // 
            // songList_dgv
            // 
            songList_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            songList_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            songList_dgv.BackgroundColor = Color.WhiteSmoke;
            songList_dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            songList_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            songList_dgv.Columns.AddRange(new DataGridViewColumn[] { TrackTitle, TrackArtist, TrackAlbum, TrackGenre });
            songList_dgv.Dock = DockStyle.Fill;
            songList_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            songList_dgv.EnableHeadersVisualStyles = false;
            songList_dgv.GridColor = Color.WhiteSmoke;
            songList_dgv.Location = new Point(178, 25);
            songList_dgv.Name = "songList_dgv";
            songList_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            songList_dgv.RowHeadersVisible = false;
            songList_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            songList_dgv.Size = new Size(967, 536);
            songList_dgv.TabIndex = 19;
            songList_dgv.CellDoubleClick += songList_dgv_CellDoubleClick;
            songList_dgv.SelectionChanged += songList_dgv_SelectionChanged;
            // 
            // TrackTitle
            // 
            TrackTitle.HeaderText = "Title";
            TrackTitle.Name = "TrackTitle";
            // 
            // TrackArtist
            // 
            TrackArtist.HeaderText = "Artist";
            TrackArtist.Name = "TrackArtist";
            // 
            // TrackAlbum
            // 
            TrackAlbum.HeaderText = "Album";
            TrackAlbum.Name = "TrackAlbum";
            // 
            // TrackGenre
            // 
            TrackGenre.HeaderText = "Genre";
            TrackGenre.Name = "TrackGenre";
            // 
            // MusicPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1145, 649);
            Controls.Add(songList_dgv);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Font = new Font("Arial", 9F);
            ForeColor = Color.RoyalBlue;
            Name = "MusicPlayer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Player";
            FormClosing += OnFormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)VolumeTrackbar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)songList_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnShowList;
        private Button btnAddtoList;
        private Button btnRepeatOnce;
        private Button btnShuffle;
        private Button btnRepeat;
        private Button btnSettings;
        private Button btnMenu;
        private TrackBar VolumeTrackbar;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private Panel panel2;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripDropDownButton toolStripDropDownButton4;
        private DataGridView songList_dgv;
        private DataGridViewTextBoxColumn TrackTitle;
        private DataGridViewTextBoxColumn TrackArtist;
        private DataGridViewTextBoxColumn TrackAlbum;
        private DataGridViewTextBoxColumn TrackGenre;
        private Button btnRemove;
    }
}
