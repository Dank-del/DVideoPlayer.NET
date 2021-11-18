using LibVLCSharp.Shared;
using System;
using System.Windows.Forms;

namespace DVideoPlayer.NET
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            playAndPauseButton.Visible = false;
            videoStopButton.Visible = false;
            volumeDownButton.Visible = false;
            volumeUpButton.Visible = false;
            volumeLevelBar.Visible = false;
            ToggleMuteButton.Visible = false;
            VideoTrackBar.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayFromSrcButton_Click(object sender, EventArgs e)
        {
            LibVLC libvlc = new LibVLC(enableDebugLogs: true);
            try
            {
                volumeLevelBar.Maximum = 100;
                Media media = new Media(libvlc, new Uri($@"{videoPathInputBox.Text}"));
                MediaPlayer mediaplayer = new MediaPlayer(media);
                mainVideo.MediaPlayer = mediaplayer;
                volumeLevelBar.Value = mainVideo.MediaPlayer.Volume;
                mainVideo.MediaPlayer.Play();
                playAndPauseButton.Visible = true;
                videoStopButton.Visible = true;
                volumeDownButton.Visible = true;
                volumeUpButton.Visible = true;
                volumeLevelBar.Visible = true;
                ToggleMuteButton.Visible = true;
                VideoTrackBar.Visible = true;
                VideoTrackBar.SetRange(0, (int)(media.Duration / 1000));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlayAndPauseButton_Click(object sender, EventArgs e)
        {
            if (mainVideo.MediaPlayer.IsPlaying) {
                mainVideo.MediaPlayer.Pause();
            } else
            {
                mainVideo.MediaPlayer.Play();
            }
        }

        private void TextLabel_Click(object sender, EventArgs e)
        {

        }

        private void VolumeUpButton_Click(object sender, EventArgs e)
        {
            var p = mainVideo.MediaPlayer;
            if (p.Volume == 100)
            {
                MessageBox.Show("Max Volume reached", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                p.Volume += 10;
            }
            volumeLevelBar.Value = p.Volume;
        }

        private void VolumeDownButton_Click(object sender, EventArgs e)
        {
            var p = mainVideo.MediaPlayer;
            if (p.Volume == 0)
            {
                MessageBox.Show("Video Muted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                p.Volume -= 10;
            }
            volumeLevelBar.Value = p.Volume;
        }

        private void VideoStopButton_Click(object sender, EventArgs e)
        {
            var p = mainVideo.MediaPlayer;
            p.Stop();
        }

        private void ToggleMuteButton_Click(object sender, EventArgs e)
        {
            mainVideo.MediaPlayer.ToggleMute();
        }

        private void VideoTrackBar_ValueChanged(object sender, EventArgs e)
        {
            var v = VideoTrackBar.Value;
            mainVideo.MediaPlayer.SeekTo(new TimeSpan(v)); //=  VideoTrackBar.Value;
        }
    }
}
