using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NAudio.Wave;

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

            _timer = new System.Windows.Forms.Timer { Interval = 1000 };
            _timer.Tick += Timer1_Tick;

            _songList = new SongList();
            _songList._lstSongs.SelectedIndexChanged += _lstSongs_SelectedIndexChanged;
        }

        private void _lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentIndex = _songList._lstSongs.SelectedIndex;
            PlaySelectedFile();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (_audioFileReader != null)
            {
                lblElapsed.Text = $"{_audioFileReader.CurrentTime:mm\\:ss} / {_audioFileReader.TotalTime:mm\\:ss}";
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

                    lblStatus.Text = $"Status: Loaded {openFileDialog.FileNames.Length} file(s)";
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
            StopPlayback();
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

        private void PlaySelectedFile()
        {
            if (_currentIndex >= 0)
            {
                string selectedFile = _musicFiles[_currentIndex];
                StopPlayback();

                _waveOutDevice = new WaveOutEvent();
                _audioFileReader = new AudioFileReader(selectedFile);

                _waveOutDevice.Init(_audioFileReader);
                _waveOutDevice.Play();
                lblStatus.Text = $"Status: Playing {System.IO.Path.GetFileName(selectedFile)}";
                _timer.Start();
            }
        }

        private void StopPlayback()
        {
            _waveOutDevice?.Stop();
            _audioFileReader?.Dispose();
            _waveOutDevice?.Dispose();
            _audioFileReader = null;
            _waveOutDevice = null;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopPlayback();
            base.OnFormClosing(e);
        }

        private void CloseApp_pb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxApp_pb_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void RestApp_pb_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void MinApp_pb_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            _songList.Show();
        }
    }
}
