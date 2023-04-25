using hapticMedia.config.theme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hapticMedia.genericComponents.pageDefinition {
    public partial class UserControlBase : UserControl {
        
        public UserControlBase() {
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
