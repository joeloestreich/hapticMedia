using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;

namespace hapticMedia.videoViewer.data {
    public class WsVideoData {

        public enum StateEnum : int {
            Unstarted = -1,
            Ended = 0,
            Playing = 1,
            Paused = 2,
            Buffering = 3,
            Cued = 5
        }

        public string videoId;
        public double timeStamp;
        public string useCase;
        public string value;

    }
}
