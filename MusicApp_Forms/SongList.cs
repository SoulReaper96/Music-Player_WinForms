using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp_Forms
{
    public partial class SongList : Form
    {
        public ListBox _lstSongs { get; private set; }
        public event EventHandler _songSelected;

        public SongList()
        {
            InitializeComponent();

            this._lstSongs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _lstSongs
            // 
            this._lstSongs.FormattingEnabled = true;
            this._lstSongs.Location = new System.Drawing.Point(12, 12);
            this._lstSongs.Name = "LstSongs";
            this._lstSongs.Size = new System.Drawing.Size(317, 510);
            this._lstSongs.TabIndex = 0;
            this._lstSongs.Dock = DockStyle.Fill;
            this._lstSongs.BackColor = Color.LightGray;
            this._lstSongs.ForeColor = Color.DarkOrange;
            this._lstSongs.SelectedIndexChanged += new System.EventHandler(this._lstSongs_SelectedIndexChanged);
            // 
            // MusicListForm
            // 
            this.ClientSize = new System.Drawing.Size(317, 510);
            this.BringToFront();
            this.Controls.Add(this._lstSongs);
            this.Name = "MusicListForm";
            this.Text = "Music List";
            this.ResumeLayout(false);
        }

        private void _lstSongs_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_songSelected != null)
            {
                _songSelected?.Invoke(this, EventArgs.Empty);
            }
        }

        private void SongList_Load(object sender, EventArgs e)
        {

        }
    }
}
