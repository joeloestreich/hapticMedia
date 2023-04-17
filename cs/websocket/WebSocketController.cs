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
using owoMedia.cs.applicationFrame;
using owoMedia.cs.pages.videoViewer;
using System.Windows.Forms;

namespace owoMedia.cs.websocket {
    internal class WebSocketController {

        const string Address = "ws://127.0.0.1:";

        readonly OwoMedia owoMedia;
        WebSocketServer server;

        public WebSocketController(OwoMedia owoMedia) {
            this.owoMedia = owoMedia;
            StartSocketServer();
        }

        private void StartSocketServer() {
            StopSocketServer();

            string wsAddress = Address + owoMedia.Config.Port;
            server = new WebSocketServer(wsAddress);
            server.AddWebSocketService(WsVideoViewerBehavior.Route, () => new WsVideoViewerBehavior(owoMedia));
            server.Start();

            Console.WriteLine("WebSocketServer Started on " + wsAddress);
            Console.WriteLine("Adresses:");
            Console.WriteLine("=> " + wsAddress + WsVideoViewerBehavior.Route);
        }

        public void StopSocketServer() {
            if (server == null) {
                return;
            }
            server.Stop();
            server = null;
        }

        
    }
}
