using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationRecorder.data {
    internal class CaptureData {

        public long TimeStamp;
        public string Capture;

        public CaptureData(long timeStamp, string capture) {
            this.TimeStamp = timeStamp;
            this.Capture = capture;
        }
    }
}
