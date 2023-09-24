using OWOGame;
using hapticMedia.config.data;
using hapticMedia.home.components.pages;
using hapticMedia.videoViewer.components.pages;
using hapticMedia.welcome.components.pages;
using hapticMedia.websocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hapticMedia.applicationFrame.Service;
using Newtonsoft.Json;
using hapticMedia.videoViewer.data;
using hapticMedia.sensationEditor.components.pages;
using hapticMedia.genericComponents.PageHeader;
using hapticMedia.sensationEditor.components.TemplateComponents;

namespace hapticMedia.genericComponents.pageDefinition {
    public sealed partial class HapticMedia : Form {

        static string configFile = "config.txt";

        private static HapticMedia _instance;
        public static HapticMedia Instance { 
            get { 
                if (_instance == null) {
                    _instance = new HapticMedia();
                }
                return _instance;
            }
        }

        private HapticMedia() {
            InitializeComponent();
        }


        public Config Config;
        public UserControlPage CurrentPage { get; set; }

        private void HapticMedia_Load(object sender, EventArgs e) {
            string configString = HapticMediaFileService.LoadFile(null, configFile);
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
        private void HapticMedia_FormClosing(object sender, FormClosingEventArgs e) {
            string configString = JsonConvert.SerializeObject(Config);
            HapticMediaFileService.SaveFile(configString, null, configFile);

            Disconnect();
        }

        private void StartUp(UserControlPage initialPage) {
            // Design
            Connect();

            Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            this.Size = new Size(1280, 720 + titleHeight);

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
