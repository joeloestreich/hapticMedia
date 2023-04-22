using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owoMedia.genericComponents.pageDefinition {
    public partial class UserControlPage : UserControlOwoBase {
        
        public UserControlPage() {
            InitializeComponent();
        }

        public override void Init() {
            base.Init();
            this.Dock = DockStyle.Fill;
            this.Size = OwoMedia.Instance.Size;
        }

    }
}
