﻿namespace MusicMaster
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MusicFolder = new TextBox();
            MusicFolderConfirm = new Button();
            label2 = new Label();
            NowPlaying = new Label();
            PlayButton = new Button();
            Back = new Button();
            Skip = new Button();
            Pause = new Button();
            Stop = new Button();
            MuteIndicator = new Label();
            VolumeRange = new Label();
            Volume = new NumericUpDown();
            Mute = new Button();
            Unmute = new Button();
            label1 = new Label();
            label3 = new Label();
            StartPic = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            musictimetot = new Label();
            musictime = new Label();
            label5 = new Label();
            Albumcover = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)Volume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Albumcover).BeginInit();
            SuspendLayout();
            // 
            // MusicFolder
            // 
            MusicFolder.Location = new Point(153, 2);
            MusicFolder.Name = "MusicFolder";
            MusicFolder.Size = new Size(231, 31);
            MusicFolder.TabIndex = 0;
            MusicFolder.Text = "\r\n";
            MusicFolder.TextChanged += MusicFolder_TextChanged;
            // 
            // MusicFolderConfirm
            // 
            MusicFolderConfirm.Location = new Point(390, 2);
            MusicFolderConfirm.Name = "MusicFolderConfirm";
            MusicFolderConfirm.Size = new Size(145, 31);
            MusicFolderConfirm.TabIndex = 1;
            MusicFolderConfirm.Text = "Search Music Folder";
            MusicFolderConfirm.UseVisualStyleBackColor = true;
            MusicFolderConfirm.Click += MusicFolderConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 5);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 3;
            label2.Text = "Uw Muziek Folder";
            // 
            // NowPlaying
            // 
            NowPlaying.AutoSize = true;
            NowPlaying.Location = new Point(80, 47);
            NowPlaying.Name = "NowPlaying";
            NowPlaying.Size = new Size(115, 25);
            NowPlaying.TabIndex = 4;
            NowPlaying.Text = "Now Playing:";
            NowPlaying.Click += NowPlaying_Click;
            // 
            // PlayButton
            // 
            PlayButton.Location = new Point(4, 177);
            PlayButton.Name = "PlayButton";
            PlayButton.RightToLeft = RightToLeft.No;
            PlayButton.Size = new Size(380, 49);
            PlayButton.TabIndex = 5;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // Back
            // 
            Back.Location = new Point(4, 82);
            Back.Name = "Back";
            Back.RightToLeft = RightToLeft.No;
            Back.Size = new Size(182, 41);
            Back.TabIndex = 6;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Skip
            // 
            Skip.Location = new Point(192, 82);
            Skip.Name = "Skip";
            Skip.RightToLeft = RightToLeft.No;
            Skip.Size = new Size(192, 41);
            Skip.TabIndex = 7;
            Skip.Text = "Skip";
            Skip.UseVisualStyleBackColor = true;
            Skip.Click += Skip_Click;
            // 
            // Pause
            // 
            Pause.Location = new Point(4, 232);
            Pause.Name = "Pause";
            Pause.RightToLeft = RightToLeft.No;
            Pause.Size = new Size(380, 49);
            Pause.TabIndex = 8;
            Pause.Text = "Pause";
            Pause.UseVisualStyleBackColor = true;
            Pause.Click += Pause_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(4, 287);
            Stop.Name = "Stop";
            Stop.RightToLeft = RightToLeft.No;
            Stop.Size = new Size(380, 49);
            Stop.TabIndex = 9;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // MuteIndicator
            // 
            MuteIndicator.AutoSize = true;
            MuteIndicator.Location = new Point(408, 113);
            MuteIndicator.Name = "MuteIndicator";
            MuteIndicator.Size = new Size(86, 25);
            MuteIndicator.TabIndex = 10;
            MuteIndicator.Text = "Unmuted";
            MuteIndicator.Click += MuteIndicator_Click;
            // 
            // VolumeRange
            // 
            VolumeRange.AutoSize = true;
            VolumeRange.Location = new Point(396, 142);
            VolumeRange.Name = "VolumeRange";
            VolumeRange.Size = new Size(124, 25);
            VolumeRange.TabIndex = 11;
            VolumeRange.Text = "Volume 0-100";
            // 
            // Volume
            // 
            Volume.Location = new Point(394, 187);
            Volume.Name = "Volume";
            Volume.Size = new Size(130, 31);
            Volume.TabIndex = 13;
            Volume.Value = new decimal(new int[] { 100, 0, 0, 0 });
            Volume.ValueChanged += Volume_ValueChanged;
            // 
            // Mute
            // 
            Mute.Location = new Point(393, 232);
            Mute.Name = "Mute";
            Mute.RightToLeft = RightToLeft.No;
            Mute.Size = new Size(130, 49);
            Mute.TabIndex = 14;
            Mute.Text = "Mute";
            Mute.UseVisualStyleBackColor = true;
            Mute.Click += Mute_Click;
            // 
            // Unmute
            // 
            Unmute.Location = new Point(394, 287);
            Unmute.Name = "Unmute";
            Unmute.RightToLeft = RightToLeft.No;
            Unmute.Size = new Size(130, 47);
            Unmute.TabIndex = 15;
            Unmute.Text = "Unmute";
            Unmute.UseVisualStyleBackColor = true;
            Unmute.Click += Unmute_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 47);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 16;
            label1.Text = "Geen Muziek gevonden";
            label1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 342);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 17;
            label3.Text = "V(version)";
            // 
            // StartPic
            // 
            StartPic.BackgroundImageLayout = ImageLayout.Center;
            StartPic.Image = Properties.Resources.musicmaster___nocode;
            StartPic.Location = new Point(-1, -1);
            StartPic.Name = "StartPic";
            StartPic.Padding = new Padding(145, 0, 0, 0);
            StartPic.Size = new Size(544, 377);
            StartPic.TabIndex = 18;
            StartPic.TabStop = false;
            StartPic.Click += StartPic_Click;
            // 
            // button1
            // 
            button1.Location = new Point(192, 129);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(192, 41);
            button1.TabIndex = 19;
            button1.Text = "10 Second Skip";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(4, 130);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(182, 41);
            button2.TabIndex = 20;
            button2.Text = "10 Second Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // musictimetot
            // 
            musictimetot.AutoSize = true;
            musictimetot.Location = new Point(463, 82);
            musictimetot.Name = "musictimetot";
            musictimetot.Size = new Size(56, 25);
            musictimetot.TabIndex = 21;
            musictimetot.Text = "00:00";
            musictimetot.Click += musictime_Click;
            // 
            // musictime
            // 
            musictime.AutoSize = true;
            musictime.Location = new Point(401, 82);
            musictime.Name = "musictime";
            musictime.Size = new Size(56, 25);
            musictime.TabIndex = 22;
            musictime.Text = "00:00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 82);
            label5.Name = "label5";
            label5.Size = new Size(19, 25);
            label5.TabIndex = 23;
            label5.Text = "/";
            // 
            // Albumcover
            // 
            Albumcover.Location = new Point(-1, 30);
            Albumcover.Name = "Albumcover";
            Albumcover.Size = new Size(63, 54);
            Albumcover.TabIndex = 24;
            Albumcover.TabStop = false;
            Albumcover.Click += Albumcover_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 25;
            label4.Text = "label4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 342);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 26;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 374);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(Albumcover);
            Controls.Add(label5);
            Controls.Add(musictime);
            Controls.Add(musictimetot);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Unmute);
            Controls.Add(Mute);
            Controls.Add(Volume);
            Controls.Add(VolumeRange);
            Controls.Add(MuteIndicator);
            Controls.Add(Stop);
            Controls.Add(Pause);
            Controls.Add(Skip);
            Controls.Add(Back);
            Controls.Add(PlayButton);
            Controls.Add(NowPlaying);
            Controls.Add(label2);
            Controls.Add(MusicFolderConfirm);
            Controls.Add(MusicFolder);
            Controls.Add(StartPic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(564, 414);
            Name = "Form1";
            Text = "MusicMaster";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Volume).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)Albumcover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MusicFolder;
        private Button MusicFolderConfirm;
        private Label label2;
        private Label NowPlaying;
        private Button PlayButton;
        private Button Back;
        private Button Skip;
        private Button Pause;
        private Button Stop;
        private Label MuteIndicator;
        private Label VolumeRange;
        private NumericUpDown Volume;
        private Button Mute;
        private Button Unmute;
        private Label label1;
        private Label label3;
        private PictureBox StartPic;
        private Button button1;
        private Button button2;
        private Label musictimetot;
        private Label musictime;
        private Label label5;
        private PictureBox Albumcover;
        private Label label4;
        private Label label6;
    }
}