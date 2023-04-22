using OWOGame;
using owoMedia.config.data;
using owoMedia.home.components.pages;
using owoMedia.videoViewer.components.pages;
using owoMedia.welcome.components.pages;
using owoMedia.websocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using owoMedia.applicationFrame.Service;
using Newtonsoft.Json;
using owoMedia.videoViewer.data;
using owoMedia.sensationEditor.components.pages;
using owoMedia.genericComponents.PageHeader;

namespace owoMedia.genericComponents.pageDefinition {
    public sealed partial class OwoMedia : Form {

        static string configFile = "config.txt";

        private static OwoMedia _instance;
        public static OwoMedia Instance { 
            get { 
                if (_instance == null) {
                    _instance = new OwoMedia();
                }
                return _instance;
            }
        }

        private OwoMedia() {
            InitializeComponent();
        }


        public Config Config;
        public UserControlPage CurrentPage { get; set; }

        private void OwoMedia_Load(object sender, EventArgs e) {
            string configString = OwoMediaFileService.LoadFile(null, configFile);
            if (configString == null) {
                Config = new Config();
            } else {
                Config = JsonConvert.DeserializeObject<Config>(configString);
            }

            UserControlPage initialPage;
            switch (Config.DefaultPage) {
                case Config.DefaultPageEnum.Welcome:
                    initialPage = new WelcomePage();
                    break;
                case Config.DefaultPageEnum.Home:
                    initialPage = new HomePage();
                    break;
                case Config.DefaultPageEnum.Viewer:
                    initialPage = new VideoSelectorPage();
                    break;
                case Config.DefaultPageEnum.Editor:
                    initialPage = new EditorMenuPage();
                    break;
                default:
                    Config.DefaultPage = Config.DefaultPageEnum.Welcome;
                    initialPage = new WelcomePage();
                    break;
            }


            StartUp(initialPage);
        }
        private void OwoMedia_FormClosing(object sender, FormClosingEventArgs e) {
            string configString = JsonConvert.SerializeObject(Config);
            OwoMediaFileService.SaveFile(configString, null, configFile);

            Disconnect();
        }

        private void StartUp(UserControlPage initialPage) {
            // Design
            Connect();
            this.Size = new Size(1280, 720);
            NavigateTo(initialPage);
        }

        public void NavigateTo(UserControlPage page) {
            if (CurrentPage != null) {
                CurrentPage.OnLeave();
                this.Controls.Remove(CurrentPage);
            }

            BreadCrumNavigation.OnNavigation(CurrentPage, page);

            page.Init();
            CurrentPage = page;
            CurrentPage.Dock = DockStyle.Fill;
            this.Controls.Add(page);
        }

        private void Reload() {
            Disconnect();
            Connect();
            this.CurrentPage.Reload();
        }

        private void Connect() {
            if (Config.OwoIp == null) {
                OWO.AutoConnect();
            } else {
                OWO.Connect(Config.OwoIp);
            }

            WebSocketService.StartSocketServer();
        }

        private void Disconnect() {
            WebSocketService.StopSocketServer();
            OWO.Disconnect();
        }
    }
}
