using Newtonsoft.Json;
using owoMedia.genericComponents.pageDefinition;
using owoMedia.videoViewer.components.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using WebSocketSharp;
using System.Threading;
using owoMedia.videoViewer.data;
using owoMedia.sensationEditor.components.pages;

namespace owoMedia.websocket {
    public class WsVideoEditorBehavior : WebSocketBehavior {

        public const string Route = "/videoEditor";

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
            if (!(OwoMedia.Instance.CurrentPage is VideoEditorPage)) {
                Console.WriteLine("view is not video Editor");
                return;
            }

            VideoEditorPage viewer = (VideoEditorPage)OwoMedia.Instance.CurrentPage;
            List<string> messages = viewer.OnWsMessage(dto);
            foreach (string m in messages) {
                Send(m);
            }
        }

    }
}
