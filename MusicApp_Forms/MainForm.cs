using NAudio.Wave;
using NAudio.Gui;

namespace MusicApp_Forms
{
    public partial class MusicPlayer : Form
    {
        private IWavePlayer _waveOutDevice;
        private AudioFileReader _audioFileReader;
        private VolumeSlider _volumeSlider;
        private List<string> _musicFiles;
        private int _currentIndex = -1;
        private System.Windows.Forms.Timer _timer;

        private bool _isRepeatingSong = false;
        private bool _isRepeatingPlaylist = false;

        public MusicPlayer()
        {
            InitializeComponent();
            _musicFiles = new List<string>();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer1_Tick;

            songList.SelectedIndexChanged += new EventHandler(_lstSongs_SelectedIndexChanged);
        }

        private void _lstSongs_SelectedIndexChanged(object? sender, EventArgs e)
        {
            _currentIndex = songList.SelectedIndex;
            //PlaySelectedFile();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            if (_audioFileReader != null && _audioFileReader.TotalTime.TotalSeconds > 0)
            {
                pbarSong.Value = (int)((_audioFileReader.CurrentTime.TotalSeconds / _audioFileReader.TotalTime.TotalSeconds) * pbarSong.Maximum);
                lblElapsed.Text = $"{_audioFileReader.CurrentTime.ToString(@"mm\:ss")} / {_audioFileReader.TotalTime.ToString(@"mm\:ss")}";
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        _musicFiles.Add(file);
                        //_songList._lstSongs.Items.Add(System.IO.Path.GetFileName(file));
                        songList.Items.Add(System.IO.Path.GetFileName(file));
                    }

                    lblStatus.Text = "Status: Loaded " + openFileDialog.FileNames.Length + " file(s)";
                    //_songList.Show();
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlaySelectedFile();
            lblStatus.Text = "Status: Playing";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _waveOutDevice?.Pause();
            _timer.Stop();
            lblStatus.Text = "Status: Paused";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _waveOutDevice?.Stop();
            _timer.Stop();
            lblStatus.Text = "Status: Stopped";
            lblElapsed.Text = "00:00 / 00:00";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_musicFiles.Count > 0)
            {
                _currentIndex = (_currentIndex + 1) % _musicFiles.Count;
                songList.SelectedIndex = _currentIndex;
                PlaySelectedFile();
                lblStatus.Text = "Status: Playing Next";
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_musicFiles.Count > 0)
            {
                _currentIndex = (_currentIndex - 1 + _musicFiles.Count) % _musicFiles.Count;
                songList.SelectedIndex = _currentIndex;
                PlaySelectedFile();
                lblStatus.Text = "Status: Playing Previous";
            }
        }

        private void CloseApp_pb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxApp_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void RestApp_pb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void MinApp_pb_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            songList.Show();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            ShuffleTracks();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            _isRepeatingSong = !_isRepeatingSong;
            lblStatus.Text = "Status: " + (_isRepeatingSong ? "Repeat: On" : "Repeat: Off");
        }

        private void btnRepeatOnce_Click(object sender, EventArgs e)
        {
            _isRepeatingPlaylist = !_isRepeatingPlaylist;
            lblStatus.Text = "Status: " + (_isRepeatingPlaylist ? "Repeat Playlist: On" : "Repeat Playlist: Off");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PlaySelectedFile()
        {
            if (_currentIndex >= 0)
            {
                string _selectedFile = _musicFiles[_currentIndex];
                if (_waveOutDevice != null)
                {
                    _waveOutDevice.Stop();
                    _audioFileReader.Dispose();
                }

                _waveOutDevice = new WaveOutEvent();
                _audioFileReader = new AudioFileReader(_selectedFile);

                _waveOutDevice.Init(_audioFileReader);
                _waveOutDevice.Volume = VolumeTrackbar.Value / 100f;
                _waveOutDevice.Play();
                lblStatus.Text = "Status: Playing";
                lblCurrentSong.Text = System.IO.Path.GetFileName(_selectedFile);
                _timer.Start();

                _waveOutDevice.PlaybackStopped += OnPlaybackStopped;
            }
        }

        private void PlayTrackByIndex(int Index)
        {
            if (Index < 0 || Index >= _musicFiles.Count)
            {
                return;
            }

            string _track = _musicFiles[Index];
            if (_waveOutDevice != null)
            {
                _waveOutDevice?.Stop();
                _waveOutDevice = new WaveOutEvent();
                _audioFileReader = new AudioFileReader(_track);
                _waveOutDevice.Init(_audioFileReader);
                _waveOutDevice.Play();
                lblStatus.Text = "Status: Playing";
                _timer.Start();
                lblCurrentSong.Text = System.IO.Path.GetFileName(_track);
                _waveOutDevice.PlaybackStopped += OnPlaybackStopped;
            }

        }

        private void OnPlaybackStopped(object? sender, StoppedEventArgs e)
        {
            if (_isRepeatingSong)
            {
                _waveOutDevice?.Stop();
                _timer.Stop();
                _waveOutDevice = new WaveOutEvent();
                _audioFileReader.Position = 0;
                _waveOutDevice.Init(_audioFileReader);
                _waveOutDevice.Play();
                _timer.Start();
                lblStatus.Text = "Status: Playing";
            }
            else if (_isRepeatingPlaylist)
            {
                _currentIndex++;
                if (_currentIndex >= _musicFiles.Count)
                {
                    _currentIndex = 0;
                }
                PlayTrackByIndex(_currentIndex);
            }
            else
            {
                _waveOutDevice?.Stop();
                _timer.Stop();
                lblStatus.Text = "Status: Stopped";
                lblElapsed.Text = "00:00 / 00:00";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _waveOutDevice?.Stop();
            _audioFileReader?.Dispose();
            _waveOutDevice?.Dispose();
            base.OnFormClosing(e);
            base.OnFormClosing(e);
        }

        private void VolumeTrackbar_Scroll(object sender, EventArgs e)
        {
            if (_audioFileReader != null)
            {
                _audioFileReader.Volume = VolumeTrackbar.Value / 100f;
            }
        }

        private void ShuffleTracks()
        {
            Random random = new Random();
            List<string> tracks = songList.Items.Cast<string>().ToList();
            List<string> shuffledTracks = tracks.OrderBy(x => random.Next()).ToList();

            // Debugging: Print the original and shuffled lists
            Console.WriteLine("Original List:");
            foreach (var track in tracks)
            {
                Console.WriteLine(track);
            }

            Console.WriteLine("Shuffled List:");
            foreach (var track in shuffledTracks)
            {
                Console.WriteLine(track);
            }

            songList.Items.Clear();
            foreach (var track in shuffledTracks)
            {
                songList.Items.Add(track);
            }
        }

        private void pbarSong_MouseDown(object sender, MouseEventArgs e)
        {

            // Calculate the new position
            int mouseX = e.X;
            int progressBarWidth = pbarSong.Width;
            double newPosition = (double)mouseX / progressBarWidth * _audioFileReader.TotalTime.TotalSeconds;

            // Set the new position
            _audioFileReader.CurrentTime = TimeSpan.FromSeconds(newPosition);
            pbarSong.Value = (int)((_audioFileReader.CurrentTime.TotalSeconds / _audioFileReader.TotalTime.TotalSeconds) * pbarSong.Maximum);
        }
    }
}
