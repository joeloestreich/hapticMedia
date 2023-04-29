using hapticMedia.genericComponents;
using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.sensationEditor.components.pages;
using hapticMedia.videoViewer.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hapticMedia.sensationEditor.components {
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
                genericComponents.pageDefinition.HapticMedia.Instance.NavigateTo(new VideoEditorPage(videoId));
            }
        }
    }
}
