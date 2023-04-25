using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.config.data {
    public class Config {

        public enum DefaultPageEnum {
            Welcome,
            Home,
            Viewer,
            Editor
        }

        public int Port = 5000;
        public DefaultPageEnum DefaultPage = DefaultPageEnum.Welcome;
        public string OwoIp = null;
        public bool LightTheme = true;

    }
}
