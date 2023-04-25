using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.videoViewer.components.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hapticMedia.videoViewer.components {
    public partial class VideoSelectorEntry : UserControlBase {

        string videoId;

        public VideoSelectorEntry(string videoId) {
            this.videoId = videoId;
            InitializeComponent();
        }

        private void VideoSelectorEntry_MouseEnter(object sender, EventArgs e) {
            this.BackColor = SystemColors.Control;
        }

        private void VideoSelectorEntry_MouseHover(object sender, EventArgs e) {
            this.lblTitle.Text = "Creator";
        }

        private void VideoSelectorEntry_MouseLeave(object sender, EventArgs e) {
            this.BackColor = SystemColors.ControlLightLight;
        }

        private void VideoSelectorEntry_Click(object sender, EventArgs e) {

            HapticMedia.Instance.NavigateTo(new VideoViewerPage(videoId));
        }
    }
}
