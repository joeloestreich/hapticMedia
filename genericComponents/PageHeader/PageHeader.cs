using owoMedia.genericComponents.pageDefinition;
using owoMedia.home.components.pages;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owoMedia.genericComponents.pageHeader {
    public partial class PageHeader : UserControlOwoBase {
        public PageHeader() {
            InitializeComponent();
        }

        private void picLogo_Click(object sender, EventArgs e) {
            OwoMedia.Instance.NavigateTo(new HomePage());
        }

    }
}
