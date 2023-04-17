using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owoMedia.cs.config {
    public class Config {

        public enum DefaultPageEnum {
            Welcome,
            Home,
            Search,
            Edit
        }

        public int Port = 5000;
        public Size Size = new Size(1280, 720);
        public DefaultPageEnum DefaultPage = DefaultPageEnum.Welcome;
        public string OwoIp = null;
        public Boolean LightTheme = true;

    }
}
