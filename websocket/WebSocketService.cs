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
using owoMedia.genericComponents.pageDefinition;
using owoMedia.videoViewer.components.pages;
using System.Windows.Forms;

namespace owoMedia.websocket {
    internal class WebSocketService {

        const string Address = "ws://127.0.0.1:";

        static WebSocketServer server;

        private WebSocketService() {
        }

        public static void StartSocketServer() {
            StopSocketServer();

            string wsAddress = Address + OwoMedia.Instance.Config.Port;
            server = new WebSocketServer(wsAddress);
            server.AddWebSocketService(WsVideoViewerBehavior.Route, () => new WsVideoViewerBehavior());
            server.Start();

            Console.WriteLine("WebSocketServer Started on " + wsAddress);
            Console.WriteLine("Adresses:");
            Console.WriteLine("=> " + wsAddress + WsVideoViewerBehavior.Route);
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
