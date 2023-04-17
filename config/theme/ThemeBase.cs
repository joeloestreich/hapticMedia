using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owoMedia.config.theme {
    internal abstract class ThemeBase {

        public abstract Color BaseBackground();
        public abstract Color HighlightBackground();
        public abstract Color FontColor();
    }
}
