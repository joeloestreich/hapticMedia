using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hapticMedia.applicationFrame.Service {
    public class LabelService {

        private LabelService() {
            // Service
        }

        public static void SetFormatedTime(Label lbl, double time) {
            TimeSpan t = TimeSpan.FromSeconds(time);
            string formatedTime;
            if (t.Hours > 0) {
                formatedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
            } else {
                formatedTime = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
            }
            lbl.Text = formatedTime;
        }

    }
}
