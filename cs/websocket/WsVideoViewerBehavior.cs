using Newtonsoft.Json;
using owoMedia.cs.applicationFrame;
using owoMedia.cs.pages.videoViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using WebSocketSharp;
using System.Threading;

namespace owoMedia.cs.websocket {
    public class WsVideoViewerBehavior : WebSocketBehavior {

        public const string Route = "/videoViewer";

        OwoMedia owoMedia;

        public WsVideoViewerBehavior(OwoMedia owoMedia) {
            this.owoMedia = owoMedia;
        }

        protected override void OnMessage(MessageEventArgs e) {
            Console.WriteLine("Socket" + Route + " - " + e.Data);
            VideoInfo dto;
            try {
                dto = JsonConvert.DeserializeObject<VideoInfo>(e.Data);
            } catch {
                Console.WriteLine("error parse: " + e.Data);
                return;
            }

            if (dto == null) {
                Console.WriteLine("dto is null");
                return;
            }
            if (!(owoMedia.CurrentPage is VideoViewerPage)) {
                Console.WriteLine("view is not video View");
                return;
            }

            VideoViewerPage viewer = (VideoViewerPage) owoMedia.CurrentPage;


            switch (dto.useCase) {
                case "init":
                    Thread.Sleep(6000);
                    Send("ready");
                    break;
                case "state":
                    viewer.OnStateChange(dto);
                    break;
                default:
                    Console.WriteLine("Unknown Usecase: " + dto.useCase);
                    break;
            }

        }

    }
}
