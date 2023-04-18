using owoMedia.genericComponents.pageDefinition;
using owoMedia.config.data;
using owoMedia.videoViewer.components.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using owoMedia.sensationRecorder.components.pages;

namespace owoMedia.home.components.pages {
    public partial class HomePage : UserControlPage {
        public HomePage() {
            InitializeComponent();
        }

        public override void Init() {
            base.Init();
            OwoMedia.Instance.Config.DefaultPage = Config.DefaultPageEnum.Home;
        }

        private void btnView_Click(object sender, EventArgs e) {
            OwoMedia.Instance.NavigateTo(new VideoSelectorPage());
        }

        private void btnEditVideo_Click(object sender, EventArgs e) {

        }

        private void btnSensations_Click(object sender, EventArgs e) {

        }

        private void btnRecord_Click(object sender, EventArgs e) {
            OwoMedia.Instance.NavigateTo(new SensationRecorderPage());
        }

        private void btnOptions_Click(object sender, EventArgs e) {

        }
    }
}
