using owoMedia.config.data;
using owoMedia.genericComponents.pageDefinition;
using owoMedia.videoViewer.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owoMedia.sensationEditor.components.pages {
    public partial class EditorMenuPage : UserControlPage {
        public EditorMenuPage() {
            InitializeComponent();
        }

        public override void Init() {
            base.Init();
            OwoMedia.Instance.Config.DefaultPage = Config.DefaultPageEnum.Editor;
        }

        private void btnNewTrack_Click(object sender, EventArgs e) {
            //string promptValue = Prompt.ShowDialog("Select a Video you want to add Sensations to (URL)", "Select Video");
            string videoId = VideoSearch.IdentifyVideoId(null);
            if (videoId != null) {
                OwoMedia.Instance.NavigateTo(new VideoEditorPage(videoId));
            } else {

            }
        }

        private void btnEditTrack_Click(object sender, EventArgs e) {

        }

        private void btnTemplates_Click(object sender, EventArgs e) {

        }
    }
}
