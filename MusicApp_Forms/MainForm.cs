using NAudio.Wave;
using NAudio.Gui;

namespace MusicApp_Forms
{
    public partial class MusicPlayer : Form
    {
        private IWavePlayer _waveOutDevice;
        private AudioFileReader _audioFileReader;
        private List<string> _musicFiles;
        private int _currentIndex = -1;
        private System.Windows.Forms.Timer _timer;
        private SongList _songList;

        public MusicPlayer()
        {
            InitializeComponent();
            _musicFiles = new List<string>();
            volumeSlider.Volume = 0.5f;

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer1_Tick;

            _songList = new SongList();
            _songList._lstSongs.SelectedIndexChanged += new EventHandler(_lstSongs_SelectedIndexChanged);
        }

        private void _lstSongs_SelectedIndexChanged(object? sender, EventArgs e)
        {
            _currentIndex = _songList._lstSongs.SelectedIndex;
            PlaySelectedFile();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            if (_audioFileReader != null)
            {
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
                        _songList._lstSongs.Items.Add(System.IO.Path.GetFileName(file));
                    }

                    lblStatus.Text = "Status: Loaded " + openFileDialog.FileNames.Length + " file(s)";
                    _songList.Show();
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
                _songList._lstSongs.SelectedIndex = _currentIndex;
                PlaySelectedFile();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_musicFiles.Count > 0)
            {
                _currentIndex = (_currentIndex - 1 + _musicFiles.Count) % _musicFiles.Count;
                _songList._lstSongs.SelectedIndex = _currentIndex;
                PlaySelectedFile();
            }
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
                _waveOutDevice.Volume = volumeSlider.Volume;
                _waveOutDevice.Play();
                lblStatus.Text = "Status: Playing " + System.IO.Path.GetFileName(_selectedFile);
                _timer.Start();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _waveOutDevice?.Stop();
            _audioFileReader?.Dispose();
            _waveOutDevice?.Dispose();
            base.OnFormClosing(e);
        }

        private void volumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            if (volumeSlider.Volume > 0.0f)
            {
                if (_waveOutDevice != null)
                {
                    _waveOutDevice.Volume = volumeSlider.Volume;
                }
            }
            else
            {
                MessageBox.Show("Volume cannot be set to zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _songList.Show();
        }
    }
}
