using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.config.data;
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
using hapticMedia.sensationRecorder.components.pages;
using hapticMedia.sensationEditor.components.pages;
using hapticMedia.welcome.components.pages;
using hapticMedia.genericComponents;

namespace hapticMedia.home.components.pages {
    public partial class HomePage : UserControlPage {
        public HomePage() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // WELCOME TEST
            genericComponents.pageDefinition.HapticMedia.Instance.NavigateTo(new WelcomePage());
        }

        public override void Init() {
            base.Init();
            genericComponents.pageDefinition.HapticMedia.Instance.Config.DefaultPage = Config.DefaultPageEnum.Home;
        }

        private void btnViewer_Click(object sender, EventArgs e) {
            genericComponents.pageDefinition.HapticMedia.Instance.NavigateTo(new VideoSelectorPage());
        }

        private void btnLiveShare_Click(object sender, EventArgs e) {

        }

        private void btnRecord_Click(object sender, EventArgs e) {
            genericComponents.pageDefinition.HapticMedia.Instance.NavigateTo(new SensationRecorderPage());
        }

        private void btnEditor_Click(object sender, EventArgs e) {
            genericComponents.pageDefinition.HapticMedia.Instance.NavigateTo(new EditorMenuPage());
        }

        private void btnOptions_Click(object sender, EventArgs e) {

        }



        private void btnViewer_MouseEnter(object sender, EventArgs e) {
            ChangeInfo(new BrowseVideoInfo());
        }

        private void btnLiveShare_MouseEnter(object sender, EventArgs e) {
            ChangeInfo(new LiveShareInfo());
        }

        private void btnRecord_MouseEnter(object sender, EventArgs e) {
            ChangeInfo(new SensationRecorderInfo());
        }

        private void btnEditor_MouseEnter(object sender, EventArgs e) {
            ChangeInfo(new ManageVideoInfo());
        }

        private void btnOptions_MouseEnter(object sender, EventArgs e) {
            ChangeInfo(new OptionInfo());
        }
        private void ChangeInfo(InfoAreaBase info) {
            this.pnlInfobox.Controls.Clear();
            this.pnlInfobox.Controls.Add(info);
        }
    }
}
