using owoMedia.cs.applicationFrame;
using owoMedia.cs.config;
using owoMedia.cs.pages.videoSelector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owoMedia.cs.pages.home {
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
    }
}
