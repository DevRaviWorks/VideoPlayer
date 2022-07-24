using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinVideoPlayer
{
    public partial class VideoPlayer : Form
    {
        public VideoPlayer()
        {
            InitializeComponent();         
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            mediaPlayer.URL = AppDomain.CurrentDomain.BaseDirectory + "\\Video\\sample-Video.mp4";
            mediaPlayer.Ctlcontrols.play();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
        }

        private void btn_fullScreen_Click(object sender, EventArgs e)
        {
            mediaPlayer.fullScreen = mediaPlayer.URL.Length > 1;
        }
    }
}
