using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using System.Net.Sockets;
using WebSocketSharp;
using System.Net;
using Newtonsoft.Json;
using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.videoViewer.components.pages;
using System.Windows.Forms;

namespace hapticMedia.websocket {
    internal class WebSocketService {

        const string Address = "ws://127.0.0.1:";

        static WebSocketServer server;

        private WebSocketService() {
        }

        public static void StartSocketServer() {
            StopSocketServer();

            string wsAddress = Address + HapticMedia.Instance.Config.Port;
            server = new WebSocketServer(wsAddress);
            server.AddWebSocketService(WsVideoViewerBehavior.Route, () => new WsVideoViewerBehavior());
            server.AddWebSocketService(WsVideoEditorBehavior.Route, () => new WsVideoEditorBehavior());
            server.Start();

            Console.WriteLine("WebSocketServer Started on " + wsAddress);
            Console.WriteLine("Adresses:");
            Console.WriteLine("=> " + wsAddress + WsVideoViewerBehavior.Route);
            Console.WriteLine("=> " + wsAddress + WsVideoEditorBehavior.Route);
        }

        public static void StopSocketServer() {
            if (server == null) {
                return;
            }
            server.Stop();
            server = null;
        }


    }
}
