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
using hapticMedia.sensationEditor.components.pages;

namespace hapticMedia.websocket {
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
            if (!(genericComponents.pageDefinition.HapticMedia.Instance.CurrentPage is VideoEditorPage)) {
                Console.WriteLine("view is not video Editor");
                return;
            }

            VideoEditorPage viewer = (VideoEditorPage)genericComponents.pageDefinition.HapticMedia.Instance.CurrentPage;
            List<string> messages = viewer.OnWsEvent(dto);
            foreach (string m in messages) {
                Send(m);
            }
        }

        protected override void OnClose(CloseEventArgs e) {
            base.OnClose(e);

            VideoEditorPage viewer = (VideoEditorPage)genericComponents.pageDefinition.HapticMedia.Instance.CurrentPage;
            List<string> messages = viewer.OnWsEvent(null);
        }

    }
}
