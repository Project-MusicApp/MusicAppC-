using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJMp3
{
    public partial class MusicPlay : Form
    {
        public MusicPlay()
        {
            InitializeComponent();
        }

        string[] paths, files;
        int Startindex = 0;
        string[] FileName, FilePath;
        Boolean playnext = false;

        bool _playing = false;

        //set play , pause button in previous and next song
        public bool isplaying
        {
            get
            {
                return _playing;
            }
            set
            {
                _playing = value;
                if(_playing)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    btnPlay.Image = play.Image;
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    btnPlay.Image = pause.Image;
                }
            }
        }
        
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MusicPlay_Load(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            StopPlayer();
        }

        private void listBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            //click music and play
            Startindex = listBoxMusic.SelectedIndex;
            playfile(Startindex);
            lblNameSong.Text = listBoxMusic.Text;
        }

        private void btnBrowseSong_Click(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            OpenFileDialog opnFileDig = new OpenFileDialog();
            opnFileDig.Multiselect = true;
            opnFileDig.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg;*.avi;*.3gp;*.flv|all files|*.*";
            if (opnFileDig.ShowDialog()==DialogResult.OK)
            {
                FileName = opnFileDig.SafeFileNames;
                FilePath = opnFileDig.FileNames;
                for (int i = 0; i <= FileName.Length -1; i++)
                {
                    listBoxMusic.Items.Add(FileName[i]);
                }
                Startindex = 0;
                playfile(0);
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            listBoxMusic.BringToFront();
        }

        private void btnPlaySong_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.BringToFront();
        }

        private void SliderVolum_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = SliderVolum.Value;
            lblValueSound.Text = SliderVolum.Value.ToString();
        }

        private void play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        //event play song
        public EventHandler onAction = null;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            isplaying = !isplaying;
            if (onAction != null)
            {
                onAction.Invoke(this, e);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopPlayer();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Startindex == listBoxMusic.Items.Count - 1)
            {
                Startindex = listBoxMusic.Items.Count - 1;
            }
            else if (Startindex < listBoxMusic.Items.Count)
            {
                Startindex = Startindex + 1;
            }
            playfile(Startindex);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Startindex > 0)
            {
                Startindex = Startindex - 1;
            }
            playfile(Startindex);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblValueStart.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            lblValueEnd.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timeSong.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timeSong.MaximumValue = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                timeSong.Value = 0;
            }
        }

        public void StopPlayer()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        public void playfile(int playlistindex)
        {
            if (listBoxMusic.Items.Count <= 0)
            {
                return;
            }
            if (playlistindex < 0)
            {
                return;
            }
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL = FilePath[playlistindex];
            axWindowsMediaPlayer1.Ctlcontrols.next();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
