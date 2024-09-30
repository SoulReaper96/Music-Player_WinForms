using NAudio.Wave;
using NAudio.Gui;
using System.Windows.Forms;

namespace MusicApp_Forms
{
    public partial class MusicPlayer : Form
    {
        private IWavePlayer _waveOutDevice;
        private AudioFileReader _audioFileReader;
        private List<string> _musicFiles;
        private int _currentIndex = -1;
        private System.Windows.Forms.Timer _timer;

        private bool _isRepeatingSong = false;
        private bool _isRepeatingPlaylist = false;

        public MusicPlayer()
        {
            InitializeComponent();
            InitializeFormOptions();
            _musicFiles = new List<string>();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer1_Tick;
        }

        private void InitializeFormOptions()
        {
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(MusicForm_DragEnter);
            this.DragDrop += new DragEventHandler(MusicForm_DragDrop);
        }

        private void MusicForm_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void MusicForm_DragDrop(object? sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (Path.GetExtension(file) == ".mp3" || Path.GetExtension(file) == ".wav" || Path.GetExtension(file) == ".m4a")
                    {
                        string fileName = Path.GetFileName(file);
                        songList_dgv.Rows.Add(fileName, file); // Add to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing dropped files: {ex.Message}");
            }
        }

        private void songList_dgv_SelectionChanged(object sender, EventArgs e)
        {
            _currentIndex = songList_dgv.SelectedRows.Count;
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
                        songList_dgv.Rows.Add(System.IO.Path.GetFileName(file));
                    }

                    lblStatus.Text = "Status: Loaded " + openFileDialog.FileNames.Length + " file(s)";
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
            if (_musicFiles.Count > 0 && _currentIndex < songList_dgv.Rows.Count - 1)
            {
                _currentIndex++;
                PlaySelectedFile();
                lblStatus.Text = "Status: Playing Next";
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_musicFiles.Count > 0 && _currentIndex > 0)
            {
                _currentIndex--;
                PlaySelectedFile();
                lblStatus.Text = "Status: Playing Previous";
            }
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

        private void PlaySelectedFile()
        {
            if (_currentIndex >= 0 && _currentIndex < songList_dgv.Rows.Count)
            {
                try
                {
                    var cellValue = songList_dgv.Rows[_currentIndex].Cells[1].Value;
                    if (cellValue != null)
                    {
                        string songPath = cellValue.ToString();
                        PlaySong(songPath); // Play the song
                        songList_dgv.ClearSelection();
                        songList_dgv.Rows[_currentIndex].Selected = true; // Highlight the current song
                    }
                    else
                    {
                        MessageBox.Show("Selected song path is empty.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing selected file: {ex.Message}");
                }
            }
        }

        private void PlaySong(string filePath)
        {
            try
            {
                _waveOutDevice?.Stop();
                _audioFileReader?.Dispose();

                _waveOutDevice = new WaveOutEvent();
                _audioFileReader = new AudioFileReader(filePath);

                _waveOutDevice.Init(_audioFileReader);
                _waveOutDevice.Volume = VolumeTrackbar.Value / 100f;
                _waveOutDevice.Play();
                lblStatus.Text = "Status: Playing";
                lblCurrentSong.Text = System.IO.Path.GetFileName(filePath);
                _timer.Start();

                _waveOutDevice.PlaybackStopped += OnPlaybackStopped;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing song: {ex.Message}");
            }
        }

        private void PlayTrackByIndex(int Index)
        {
            if (Index < 0 || Index >= _musicFiles.Count)
            {
                return;
            }

            string _track = _musicFiles[Index];
            PlaySong(_track);
        }

        private void OnPlaybackStopped(object? sender, StoppedEventArgs e)
        {
            try
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
                else if (_audioFileReader.Position == _audioFileReader.Length)
                {
                    btnNext_Click(null, null); // Auto-play the next track
                }
                else
                {
                    _waveOutDevice?.Stop();
                    _timer.Stop();
                    lblStatus.Text = "Status: Stopped";
                    lblElapsed.Text = "00:00 / 00:00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during playback stopped handling: {ex.Message}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _waveOutDevice?.Stop();
            _audioFileReader?.Dispose();
            _waveOutDevice?.Dispose();
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

            if (songList_dgv.Rows.Count > 0)
            {
                _currentIndex = random.Next(songList_dgv.Rows.Count);
                PlaySelectedFile();
            }
        }

        private void pbarSong_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (_audioFileReader != null)
                {
                    int mouseX = e.X;
                    int progressBarWidth = pbarSong.Width;
                    double newPosition = (double)mouseX / progressBarWidth * _audioFileReader.TotalTime.TotalSeconds;

                    _audioFileReader.CurrentTime = TimeSpan.FromSeconds(newPosition);
                    pbarSong.Value = (int)((_audioFileReader.CurrentTime.TotalSeconds / _audioFileReader.TotalTime.TotalSeconds) * pbarSong.Maximum);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error seeking through the song: {ex.Message}");
            }
        }

        private void songList_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var cellValue = songList_dgv.Rows[e.RowIndex].Cells[0].Value;
                    if (cellValue != null)
                    {
                        string songPath = cellValue.ToString();
                        PlaySong(songPath);
                    }
                    else
                    {
                        MessageBox.Show("Selected song path is empty.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred: {ex.Message}");
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (songList_dgv.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in songList_dgv.SelectedRows)
                    {
                        songList_dgv.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing selected song(s): {ex.Message}");
            }
        }
    }
}
