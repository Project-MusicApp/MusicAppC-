
namespace PJMp3
{
    partial class MusicPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlay));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPlaySong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBrowseSong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlaylist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameSong = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblValueEnd = new System.Windows.Forms.Label();
            this.lblValueStart = new System.Windows.Forms.Label();
            this.btnStop = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblValueSound = new Bunifu.UI.WinForms.BunifuLabel();
            this.SliderVolum = new Bunifu.Framework.UI.BunifuSlider();
            this.timeSong = new Bunifu.Framework.UI.BunifuProgressBar();
            this.play = new Bunifu.Framework.UI.BunifuImageButton();
            this.pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.AutoSize = true;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnMinimize);
            this.bunifuGradientPanel1.Controls.Add(this.btnMax);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Controls.Add(this.btnPlaySong);
            this.bunifuGradientPanel1.Controls.Add(this.btnBrowseSong);
            this.bunifuGradientPanel1.Controls.Add(this.btnPlaylist);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(242, 437);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(73, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 29);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMax
            // 
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.ImageActive = null;
            this.btnMax.Location = new System.Drawing.Point(38, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(29, 29);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 5;
            this.btnMax.TabStop = false;
            this.btnMax.Zoom = 10;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.Active = false;
            this.btnPlaySong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlaySong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlaySong.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaySong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlaySong.BorderRadius = 0;
            this.btnPlaySong.ButtonText = "Now Playing";
            this.btnPlaySong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaySong.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlaySong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlaySong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlaySong.Iconimage")));
            this.btnPlaySong.Iconimage_right = null;
            this.btnPlaySong.Iconimage_right_Selected = null;
            this.btnPlaySong.Iconimage_Selected = null;
            this.btnPlaySong.IconMarginLeft = 0;
            this.btnPlaySong.IconMarginRight = 0;
            this.btnPlaySong.IconRightVisible = true;
            this.btnPlaySong.IconRightZoom = 0D;
            this.btnPlaySong.IconVisible = true;
            this.btnPlaySong.IconZoom = 90D;
            this.btnPlaySong.IsTab = true;
            this.btnPlaySong.Location = new System.Drawing.Point(0, 310);
            this.btnPlaySong.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPlaySong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlaySong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlaySong.selected = false;
            this.btnPlaySong.Size = new System.Drawing.Size(238, 48);
            this.btnPlaySong.TabIndex = 3;
            this.btnPlaySong.Text = "Now Playing";
            this.btnPlaySong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlaySong.Textcolor = System.Drawing.Color.Black;
            this.btnPlaySong.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaySong.Click += new System.EventHandler(this.btnPlaySong_Click);
            // 
            // btnBrowseSong
            // 
            this.btnBrowseSong.Active = false;
            this.btnBrowseSong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBrowseSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowseSong.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseSong.BorderRadius = 0;
            this.btnBrowseSong.ButtonText = "Browse Songs";
            this.btnBrowseSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseSong.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowseSong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowseSong.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBrowseSong.Iconimage")));
            this.btnBrowseSong.Iconimage_right = null;
            this.btnBrowseSong.Iconimage_right_Selected = null;
            this.btnBrowseSong.Iconimage_Selected = null;
            this.btnBrowseSong.IconMarginLeft = 0;
            this.btnBrowseSong.IconMarginRight = 0;
            this.btnBrowseSong.IconRightVisible = true;
            this.btnBrowseSong.IconRightZoom = 0D;
            this.btnBrowseSong.IconVisible = true;
            this.btnBrowseSong.IconZoom = 90D;
            this.btnBrowseSong.IsTab = true;
            this.btnBrowseSong.Location = new System.Drawing.Point(0, 379);
            this.btnBrowseSong.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseSong.Name = "btnBrowseSong";
            this.btnBrowseSong.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBrowseSong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBrowseSong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowseSong.selected = false;
            this.btnBrowseSong.Size = new System.Drawing.Size(238, 48);
            this.btnBrowseSong.TabIndex = 2;
            this.btnBrowseSong.Text = "Browse Songs";
            this.btnBrowseSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowseSong.Textcolor = System.Drawing.Color.Black;
            this.btnBrowseSong.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseSong.Click += new System.EventHandler(this.btnBrowseSong_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Active = false;
            this.btnPlaylist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlaylist.BorderRadius = 0;
            this.btnPlaylist.ButtonText = "Playlist";
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlaylist.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlaylist.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Iconimage")));
            this.btnPlaylist.Iconimage_right = null;
            this.btnPlaylist.Iconimage_right_Selected = null;
            this.btnPlaylist.Iconimage_Selected = null;
            this.btnPlaylist.IconMarginLeft = 0;
            this.btnPlaylist.IconMarginRight = 0;
            this.btnPlaylist.IconRightVisible = true;
            this.btnPlaylist.IconRightZoom = 0D;
            this.btnPlaylist.IconVisible = true;
            this.btnPlaylist.IconZoom = 90D;
            this.btnPlaylist.IsTab = true;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 240);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlaylist.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlaylist.selected = false;
            this.btnPlaylist.Size = new System.Drawing.Size(238, 48);
            this.btnPlaylist.TabIndex = 1;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlaylist.Textcolor = System.Drawing.Color.Black;
            this.btnPlaylist.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblNameSong);
            this.panel1.Controls.Add(this.lblValueEnd);
            this.panel1.Controls.Add(this.lblValueStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.lblValueSound);
            this.panel1.Controls.Add(this.SliderVolum);
            this.panel1.Controls.Add(this.timeSong);
            this.panel1.Controls.Add(this.play);
            this.panel1.Controls.Add(this.pause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(242, 306);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 131);
            this.panel1.TabIndex = 1;
            // 
            // lblNameSong
            // 
            this.lblNameSong.AutoSize = true;
            this.lblNameSong.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSong.Location = new System.Drawing.Point(6, 41);
            this.lblNameSong.Name = "lblNameSong";
            this.lblNameSong.Size = new System.Drawing.Size(97, 19);
            this.lblNameSong.TabIndex = 19;
            this.lblNameSong.Text = "SongName";
            // 
            // lblValueEnd
            // 
            this.lblValueEnd.AutoSize = true;
            this.lblValueEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueEnd.Location = new System.Drawing.Point(399, 20);
            this.lblValueEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValueEnd.Name = "lblValueEnd";
            this.lblValueEnd.Size = new System.Drawing.Size(36, 17);
            this.lblValueEnd.TabIndex = 16;
            this.lblValueEnd.Text = "0.00";
            // 
            // lblValueStart
            // 
            this.lblValueStart.AutoSize = true;
            this.lblValueStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueStart.Location = new System.Drawing.Point(6, 20);
            this.lblValueStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValueStart.Name = "lblValueStart";
            this.lblValueStart.Size = new System.Drawing.Size(36, 17);
            this.lblValueStart.TabIndex = 15;
            this.lblValueStart.Text = "0.00";
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageActive = null;
            this.btnStop.Location = new System.Drawing.Point(233, 72);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 32);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStop.TabIndex = 14;
            this.btnStop.TabStop = false;
            this.btnStop.Zoom = 10;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageActive = null;
            this.btnNext.Location = new System.Drawing.Point(199, 72);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 32);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 13;
            this.btnNext.TabStop = false;
            this.btnNext.Zoom = 10;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageActive = null;
            this.btnPrevious.Location = new System.Drawing.Point(130, 72);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 32);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Zoom = 10;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageActive = null;
            this.btnPlay.Location = new System.Drawing.Point(164, 72);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 32);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 11;
            this.btnPlay.TabStop = false;
            this.btnPlay.Zoom = 10;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(286, 72);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // lblValueSound
            // 
            this.lblValueSound.AutoEllipsis = false;
            this.lblValueSound.CursorType = null;
            this.lblValueSound.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueSound.Location = new System.Drawing.Point(418, 76);
            this.lblValueSound.Margin = new System.Windows.Forms.Padding(2);
            this.lblValueSound.Name = "lblValueSound";
            this.lblValueSound.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblValueSound.Size = new System.Drawing.Size(27, 21);
            this.lblValueSound.TabIndex = 9;
            this.lblValueSound.Text = "100";
            this.lblValueSound.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblValueSound.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SliderVolum
            // 
            this.SliderVolum.BackColor = System.Drawing.Color.Transparent;
            this.SliderVolum.BackgroudColor = System.Drawing.Color.Gray;
            this.SliderVolum.BorderRadius = 0;
            this.SliderVolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SliderVolum.IndicatorColor = System.Drawing.Color.Black;
            this.SliderVolum.Location = new System.Drawing.Point(320, 76);
            this.SliderVolum.Margin = new System.Windows.Forms.Padding(2);
            this.SliderVolum.MaximumValue = 100;
            this.SliderVolum.Name = "SliderVolum";
            this.SliderVolum.Size = new System.Drawing.Size(94, 30);
            this.SliderVolum.TabIndex = 8;
            this.SliderVolum.Value = 100;
            this.SliderVolum.ValueChanged += new System.EventHandler(this.SliderVolum_ValueChanged);
            // 
            // timeSong
            // 
            this.timeSong.BackColor = System.Drawing.Color.Silver;
            this.timeSong.BorderRadius = 5;
            this.timeSong.Location = new System.Drawing.Point(9, 3);
            this.timeSong.Margin = new System.Windows.Forms.Padding(4);
            this.timeSong.MaximumValue = 100;
            this.timeSong.Name = "timeSong";
            this.timeSong.ProgressColor = System.Drawing.Color.Aqua;
            this.timeSong.Size = new System.Drawing.Size(426, 10);
            this.timeSong.TabIndex = 3;
            this.timeSong.Value = 0;
            // 
            // play
            // 
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.ImageActive = null;
            this.play.Location = new System.Drawing.Point(136, 78);
            this.play.Margin = new System.Windows.Forms.Padding(2);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(16, 17);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play.TabIndex = 18;
            this.play.TabStop = false;
            this.play.Zoom = 10;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.ImageActive = null;
            this.pause.Location = new System.Drawing.Point(206, 78);
            this.pause.Margin = new System.Windows.Forms.Padding(2);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(16, 17);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pause.TabIndex = 17;
            this.pause.TabStop = false;
            this.pause.Zoom = 10;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(242, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 67);
            this.panel2.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(249, 71);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(428, 232);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMusic.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBoxMusic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMusic.ForeColor = System.Drawing.Color.Transparent;
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.ItemHeight = 21;
            this.listBoxMusic.Location = new System.Drawing.Point(249, 71);
            this.listBoxMusic.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(432, 235);
            this.listBoxMusic.TabIndex = 4;
            this.listBoxMusic.SelectedIndexChanged += new System.EventHandler(this.listBoxMusic_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MusicPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(688, 437);
            this.Controls.Add(this.listBoxMusic);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MusicPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlay";
            this.Load += new System.EventHandler(this.MusicPlay_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlaySong;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseSong;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlaylist;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuLabel lblValueSound;
        private Bunifu.Framework.UI.BunifuSlider SliderVolum;
        private Bunifu.Framework.UI.BunifuProgressBar timeSong;
        private Bunifu.Framework.UI.BunifuImageButton btnStop;
        private Bunifu.Framework.UI.BunifuImageButton btnNext;
        private Bunifu.Framework.UI.BunifuImageButton btnPrevious;
        private Bunifu.Framework.UI.BunifuImageButton btnPlay;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label lblValueEnd;
        private System.Windows.Forms.Label lblValueStart;
        private Bunifu.Framework.UI.BunifuImageButton play;
        private Bunifu.Framework.UI.BunifuImageButton pause;
        private System.Windows.Forms.ListBox listBoxMusic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnMax;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNameSong;
        private System.Windows.Forms.Timer timer1;
    }
}