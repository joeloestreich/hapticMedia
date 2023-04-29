using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.config.data;
using hapticMedia.home.components.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hapticMedia.welcome.components.pages {
    public partial class WelcomePage : UserControlPage {
        public WelcomePage() {
            InitializeComponent();
        }

        public override void Init() {
            base.Init();
            genericComponents.pageDefinition.HapticMedia.Instance.Config.DefaultPage = Config.DefaultPageEnum.Welcome;
        }

        private void button1_Click(object sender, EventArgs e) {
            genericComponents.pageDefinition.HapticMedia.Instance.NavigateTo(new HomePage());
        }
    }
}
