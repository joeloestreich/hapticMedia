using owoMedia.cs.applicationFrame;
using owoMedia.cs.config;
using owoMedia.cs.pages.home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owoMedia.cs.pages.welcome {
    public partial class WelcomePage : UserControlPage {
        public WelcomePage() {
            InitializeComponent();
        }

        public override void Init() {
            base.Init();
            OwoMedia.Instance.Config.DefaultPage = Config.DefaultPageEnum.Welcome;
        }

        private void button1_Click(object sender, EventArgs e) {
            OwoMedia.Instance.NavigateTo(new HomePage());
        }
    }
}
