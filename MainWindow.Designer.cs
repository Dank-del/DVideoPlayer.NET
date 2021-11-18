
namespace DVideoPlayer.NET
{
    partial class MainWindow
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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.textLabel = new System.Windows.Forms.Label();
            this.mainVideo = new LibVLCSharp.WinForms.VideoView();
            this.videoPathInputBox = new System.Windows.Forms.TextBox();
            this.playFromSrcButton = new System.Windows.Forms.Button();
            this.playAndPauseButton = new System.Windows.Forms.Button();
            this.volumeUpButton = new System.Windows.Forms.Button();
            this.volumeDownButton = new System.Windows.Forms.Button();
            this.volumeLevelBar = new System.Windows.Forms.ProgressBar();
            this.videoStopButton = new System.Windows.Forms.Button();
            this.ToggleMuteButton = new System.Windows.Forms.Button();
            this.VideoTrackBar = new System.Windows.Forms.TrackBar();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bottomPanel.Controls.Add(this.VideoTrackBar);
            this.bottomPanel.Controls.Add(this.textLabel);
            this.bottomPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bottomPanel.Location = new System.Drawing.Point(0, 407);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(802, 44);
            this.bottomPanel.TabIndex = 0;
            this.bottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.White;
            this.textLabel.Location = new System.Drawing.Point(12, 13);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(79, 19);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "DVideo.NET";
            this.textLabel.Click += new System.EventHandler(this.TextLabel_Click);
            // 
            // mainVideo
            // 
            this.mainVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainVideo.BackColor = System.Drawing.Color.Black;
            this.mainVideo.Location = new System.Drawing.Point(0, -1);
            this.mainVideo.MediaPlayer = null;
            this.mainVideo.Name = "mainVideo";
            this.mainVideo.Size = new System.Drawing.Size(696, 402);
            this.mainVideo.TabIndex = 1;
            this.mainVideo.Text = "videoView1";
            // 
            // videoPathInputBox
            // 
            this.videoPathInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPathInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.videoPathInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.videoPathInputBox.ForeColor = System.Drawing.Color.White;
            this.videoPathInputBox.Location = new System.Drawing.Point(702, 12);
            this.videoPathInputBox.Name = "videoPathInputBox";
            this.videoPathInputBox.Size = new System.Drawing.Size(86, 13);
            this.videoPathInputBox.TabIndex = 1;
            // 
            // playFromSrcButton
            // 
            this.playFromSrcButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playFromSrcButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playFromSrcButton.Location = new System.Drawing.Point(751, 31);
            this.playFromSrcButton.Name = "playFromSrcButton";
            this.playFromSrcButton.Size = new System.Drawing.Size(37, 24);
            this.playFromSrcButton.TabIndex = 2;
            this.playFromSrcButton.Text = "Play";
            this.playFromSrcButton.UseVisualStyleBackColor = true;
            this.playFromSrcButton.Click += new System.EventHandler(this.PlayFromSrcButton_Click);
            // 
            // playAndPauseButton
            // 
            this.playAndPauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playAndPauseButton.Location = new System.Drawing.Point(702, 98);
            this.playAndPauseButton.Name = "playAndPauseButton";
            this.playAndPauseButton.Size = new System.Drawing.Size(86, 23);
            this.playAndPauseButton.TabIndex = 1;
            this.playAndPauseButton.Text = "Play/Pause";
            this.playAndPauseButton.UseVisualStyleBackColor = true;
            this.playAndPauseButton.Click += new System.EventHandler(this.PlayAndPauseButton_Click);
            // 
            // volumeUpButton
            // 
            this.volumeUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeUpButton.Location = new System.Drawing.Point(703, 128);
            this.volumeUpButton.Name = "volumeUpButton";
            this.volumeUpButton.Size = new System.Drawing.Size(85, 23);
            this.volumeUpButton.TabIndex = 3;
            this.volumeUpButton.Text = "Volume ++";
            this.volumeUpButton.UseVisualStyleBackColor = true;
            this.volumeUpButton.Click += new System.EventHandler(this.VolumeUpButton_Click);
            // 
            // volumeDownButton
            // 
            this.volumeDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeDownButton.Location = new System.Drawing.Point(703, 158);
            this.volumeDownButton.Name = "volumeDownButton";
            this.volumeDownButton.Size = new System.Drawing.Size(85, 23);
            this.volumeDownButton.TabIndex = 4;
            this.volumeDownButton.Text = "Volume --";
            this.volumeDownButton.UseVisualStyleBackColor = true;
            this.volumeDownButton.Click += new System.EventHandler(this.VolumeDownButton_Click);
            // 
            // volumeLevelBar
            // 
            this.volumeLevelBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeLevelBar.Location = new System.Drawing.Point(702, 216);
            this.volumeLevelBar.Name = "volumeLevelBar";
            this.volumeLevelBar.Size = new System.Drawing.Size(85, 23);
            this.volumeLevelBar.TabIndex = 1;
            // 
            // videoStopButton
            // 
            this.videoStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoStopButton.Location = new System.Drawing.Point(703, 245);
            this.videoStopButton.Name = "videoStopButton";
            this.videoStopButton.Size = new System.Drawing.Size(85, 23);
            this.videoStopButton.TabIndex = 5;
            this.videoStopButton.Text = "Stop Media";
            this.videoStopButton.UseVisualStyleBackColor = true;
            this.videoStopButton.Click += new System.EventHandler(this.VideoStopButton_Click);
            // 
            // ToggleMuteButton
            // 
            this.ToggleMuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToggleMuteButton.Location = new System.Drawing.Point(703, 188);
            this.ToggleMuteButton.Name = "ToggleMuteButton";
            this.ToggleMuteButton.Size = new System.Drawing.Size(84, 23);
            this.ToggleMuteButton.TabIndex = 6;
            this.ToggleMuteButton.Text = "Mute/Unmute";
            this.ToggleMuteButton.UseVisualStyleBackColor = true;
            this.ToggleMuteButton.Click += new System.EventHandler(this.ToggleMuteButton_Click);
            // 
            // VideoTrackBar
            // 
            this.VideoTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.VideoTrackBar.Location = new System.Drawing.Point(97, -1);
            this.VideoTrackBar.Name = "VideoTrackBar";
            this.VideoTrackBar.Size = new System.Drawing.Size(705, 45);
            this.VideoTrackBar.TabIndex = 1;
            this.VideoTrackBar.ValueChanged += new System.EventHandler(this.VideoTrackBar_ValueChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(107)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToggleMuteButton);
            this.Controls.Add(this.videoStopButton);
            this.Controls.Add(this.volumeLevelBar);
            this.Controls.Add(this.volumeDownButton);
            this.Controls.Add(this.volumeUpButton);
            this.Controls.Add(this.playAndPauseButton);
            this.Controls.Add(this.playFromSrcButton);
            this.Controls.Add(this.videoPathInputBox);
            this.Controls.Add(this.mainVideo);
            this.Controls.Add(this.bottomPanel);
            this.Name = "MainWindow";
            this.Text = "DVideoPlayer.NET";
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private LibVLCSharp.WinForms.VideoView mainVideo;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox videoPathInputBox;
        private System.Windows.Forms.Button playFromSrcButton;
        private System.Windows.Forms.Button playAndPauseButton;
        private System.Windows.Forms.Button volumeUpButton;
        private System.Windows.Forms.Button volumeDownButton;
        private System.Windows.Forms.ProgressBar volumeLevelBar;
        private System.Windows.Forms.Button videoStopButton;
        private System.Windows.Forms.Button ToggleMuteButton;
        private System.Windows.Forms.TrackBar VideoTrackBar;
    }
}

