using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owoMedia.cs.pages.videoViewer {
    public class VideoInfo {

        public enum StateEnum :int {
            Unstarted = -1,
            Ended = 0,
            Playing = 1,
            Paused = 2,
            Buffering = 3,
            Cued = 5
        }

        public string videoId;
        public string timeStamp;
        public string useCase;
        public string value;

    }
}
