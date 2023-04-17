using owoMedia.config.theme;
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
    public partial class UserControlOwoBase : UserControl {
        
        public UserControlOwoBase() {
            InitializeComponent();
        }

        public virtual void Init() {
            ThemeManager.applyTheme(this.Controls);
        }

        public virtual void OnLeave() {

        }

        public virtual void Reload() {

        }
    }
}
