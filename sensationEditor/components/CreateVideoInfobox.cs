using owoMedia.genericComponents;
using owoMedia.genericComponents.pageDefinition;
using owoMedia.sensationEditor.components.pages;
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

namespace owoMedia.sensationEditor.components {
    public partial class CreateVideoInfobox : InfoAreaBase {
        public CreateVideoInfobox() {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            pnlErrors.Controls.Clear();
            string videoId = VideoSearch.IdentifyVideoId(this.txtInput.Text);
            if (videoId == null) {
                Label lblError = new Label();
                lblError.Text = "The URL is Invalid";
                pnlErrors.Controls.Add(lblError);
            } else {
                OwoMedia.Instance.NavigateTo(new VideoEditorPage(videoId));
            }
        }
    }
}
