using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hapticMedia.sensationEditor.components {
    public partial class TimelinePanel : Panel {
        public TimelinePanel() {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
    }
}
