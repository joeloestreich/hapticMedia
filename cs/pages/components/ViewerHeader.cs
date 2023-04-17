using owoMedia.cs.applicationFrame;
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

namespace owoMedia.cs.pages.components {
    public partial class ViewerHeader : UserControlOwoBase {

        public ViewerHeader() {
            InitializeComponent();
        }

        private void pbLogo_Click(object sender, EventArgs e) {
            OwoMedia.Instance.NavigateTo(new HomePage());
        }
    }
}
