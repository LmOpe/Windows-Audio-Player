namespace AudioPlayer
{
    partial class AudioPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioPlayer));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.ContolPanel = new System.Windows.Forms.Panel();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnBurn = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayerAudio = new AxWMPLib.AxWindowsMediaPlayer();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.ContolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Teal;
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Controls.Add(this.lblLogo);
            this.TopPanel.Location = new System.Drawing.Point(-1, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(836, 32);
            this.TopPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(800, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(19, 19);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Freehand521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(22, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(135, 17);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Windows Audio Player";
            // 
            // ContolPanel
            // 
            this.ContolPanel.BackColor = System.Drawing.Color.Lavender;
            this.ContolPanel.Controls.Add(this.btnSync);
            this.ContolPanel.Controls.Add(this.btnBurn);
            this.ContolPanel.Controls.Add(this.btnPlay);
            this.ContolPanel.Location = new System.Drawing.Point(-1, 31);
            this.ContolPanel.Name = "ContolPanel";
            this.ContolPanel.Size = new System.Drawing.Size(836, 38);
            this.ContolPanel.TabIndex = 1;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(757, 8);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(67, 30);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.UseWaitCursor = true;
            this.btnSync.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSync_MouseClick);
            this.btnSync.MouseLeave += new System.EventHandler(this.btnSync_MouseLeave);
            // 
            // btnBurn
            // 
            this.btnBurn.Location = new System.Drawing.Point(684, 8);
            this.btnBurn.Name = "btnBurn";
            this.btnBurn.Size = new System.Drawing.Size(67, 30);
            this.btnBurn.TabIndex = 2;
            this.btnBurn.Text = "Burn";
            this.btnBurn.UseVisualStyleBackColor = true;
            this.btnBurn.UseWaitCursor = true;
            this.btnBurn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBurn_MouseClick);
            this.btnBurn.MouseLeave += new System.EventHandler(this.btnBurn_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(611, 8);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(67, 30);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.UseWaitCursor = true;
            this.btnPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPlay_MouseClick);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 16;
            this.listBoxSongs.Location = new System.Drawing.Point(610, 84);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(213, 274);
            this.listBoxSongs.TabIndex = 2;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.BackColor = System.Drawing.Color.Teal;
            this.btnSelectSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSongs.ForeColor = System.Drawing.Color.White;
            this.btnSelectSongs.Location = new System.Drawing.Point(610, 369);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(213, 50);
            this.btnSelectSongs.TabIndex = 3;
            this.btnSelectSongs.Text = "Select Songs";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCopyright.Location = new System.Drawing.Point(337, 428);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(145, 13);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "Developed by: Muhammed O";
            // 
            // axWindowsMediaPlayerAudio
            // 
            this.axWindowsMediaPlayerAudio.Enabled = true;
            this.axWindowsMediaPlayerAudio.Location = new System.Drawing.Point(12, 84);
            this.axWindowsMediaPlayerAudio.Name = "axWindowsMediaPlayerAudio";
            this.axWindowsMediaPlayerAudio.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerAudio.OcxState")));
            this.axWindowsMediaPlayerAudio.Size = new System.Drawing.Size(592, 335);
            this.axWindowsMediaPlayerAudio.TabIndex = 4;
            // 
            // AudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.axWindowsMediaPlayerAudio);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.ContolPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AudioPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AudioPlayer";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ContolPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerAudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel ContolPanel;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnBurn;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button btnSelectSongs;
        private System.Windows.Forms.PictureBox btnClose;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerAudio;
        private System.Windows.Forms.Label lblCopyright;
    }
}

