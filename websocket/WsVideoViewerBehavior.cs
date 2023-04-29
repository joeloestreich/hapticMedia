using Newtonsoft.Json;
using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.videoViewer.components.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using WebSocketSharp;
using System.Threading;
using hapticMedia.videoViewer.data;

namespace hapticMedia.websocket {
    public class WsVideoViewerBehavior : WebSocketBehavior {

        public const string Route = "/videoViewer";

        protected override void OnMessage(MessageEventArgs e) {
            Console.WriteLine("Socket" + Route + " - " + e.Data);
            WsVideoData dto;
            try {
                dto = JsonConvert.DeserializeObject<WsVideoData>(e.Data);
            } catch {
                Console.WriteLine("error parse: " + e.Data);
                return;
            }

            if (dto == null) {
                Console.WriteLine("dto is null");
                return;
            }
            if (!(genericComponents.pageDefinition.HapticMedia.Instance.CurrentPage is VideoViewerPage)) {
                Console.WriteLine("view is not video View");
                return;
            }

            VideoViewerPage viewer = (VideoViewerPage)genericComponents.pageDefinition.HapticMedia.Instance.CurrentPage;
            List<string> messages = viewer.OnWsMessage(dto);
            foreach (string m in messages) {
                Send(m);
            }
        }

    }
}
