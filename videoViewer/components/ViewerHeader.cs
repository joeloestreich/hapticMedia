using owoMedia.genericComponents.pageDefinition;
using owoMedia.home.components.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owoMedia.videoViewer.components {
    public partial class ViewerHeader : UserControlOwoBase {

        public ViewerHeader() {
            InitializeComponent();
        }

        private void pbLogo_Click(object sender, EventArgs e) {
            OwoMedia.Instance.NavigateTo(new HomePage());
        }
    }
}
