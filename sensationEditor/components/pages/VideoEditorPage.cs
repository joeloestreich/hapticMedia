using Google.Apis.YouTube.v3.Data;
using owoMedia.genericComponents.pageDefinition;
using owoMedia.Properties;
using owoMedia.sensationPlayer;
using owoMedia.videoViewer.data;
using owoMedia.websocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owoMedia.sensationEditor.components.pages {
    public partial class VideoEditorPage : UserControlPage {

        string VideoId;
        SensationPlayer SensationPlayer;

        public VideoEditorPage(string videoId) {
            InitializeComponent();
            this.VideoId = videoId;
            this.SensationPlayer = new SensationPlayer();
        }
        public VideoEditorPage(string videoId, SensationPlayer sensationPlayer) {
            InitializeComponent();
            this.VideoId = videoId;
            this.SensationPlayer = sensationPlayer;
        }

        public override void Init() {
            base.Init(); string html = Resources.videoViewer;
            html = html.Replace("$VIDEO_ID$", VideoId);
            html = html.Replace("$WS_PORT$", OwoMedia.Instance.Config.Port.ToString());
            html = html.Replace("$WS_ROUTE$", WsVideoEditorBehavior.Route);
            //this.webVideo.DocumentText = html;

            string testName = "videoEditorTest.html";
            if (File.Exists(testName)) {
                File.Delete(testName);
            }
            using (FileStream fs = File.Create(testName)) {
                Byte[] title = new UTF8Encoding(true).GetBytes(html);
                fs.Write(title, 0, title.Length);
            }
            System.Diagnostics.Process.Start(testName);
        }

        WsVideoData.StateEnum lastState = WsVideoData.StateEnum.Unstarted;
        public List<string> OnWsMessage(WsVideoData dto) {
            if (this.lblCurTime.InvokeRequired) {
                return (List<string>)this.lblCurTime.Invoke(
                  new Func<List<string>>(() => ActualOnWsMessage(dto))
                );
            } else {
                return ActualOnWsMessage(dto);
            }

        }

        public delegate void OnWsMessageDelegate(WsVideoData dto);
        public OnWsMessageDelegate wsMessageDelegate;
        public List<string> ActualOnWsMessage(WsVideoData dto) {

            List<string> messages = new List<string>();

            if (dto.videoId != this.VideoId) {
                messages.Add("IdError");
                return messages;
            }

            if (lastState == WsVideoData.StateEnum.Unstarted) {
                messages.Add("Play");
            }

            switch (dto.useCase) {
                case "init":
                    messages.Add("Connected");
                    lastState = WsVideoData.StateEnum.Unstarted;
                    break;
                case "state":
                    OnStateChange(dto);
                    break;
                case "time":
                    // general Check;
                    break;
                default:
                    Console.WriteLine("Unknown Usecase: " + dto.useCase);
                    break;
            }

            OnDetectTime(dto);

            return messages;
        }

        SyncableStopwatch stopWatch = new SyncableStopwatch();


        bool sync = false;
        private void btnSync_Click(object sender, EventArgs e) {
            sync = true;
        }

        private void OnDetectTime(WsVideoData dto) {
            if (sync) {
                sync = false;
                stopWatch.SyncTime(dto.timeStamp);
            }

            TimeSpan t = TimeSpan.FromSeconds(stopWatch.GetSyncedSeconds());
            string formatedTime;
            if (t.Hours > 0) {
                formatedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
            } else {
                formatedTime = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
            }
            lblCurTime.Text = formatedTime;

        }

        private void OnStateChange(WsVideoData dto) {
            WsVideoData.StateEnum newState = (WsVideoData.StateEnum)Int16.Parse(dto.value);

            if (lastState != WsVideoData.StateEnum.Playing && newState == WsVideoData.StateEnum.Playing) {
                stopWatch.Start();
            } else if (lastState == WsVideoData.StateEnum.Playing && newState != WsVideoData.StateEnum.Playing) {
                stopWatch.Stop();
            }

            lastState = newState;
            this.lblState.Text = lastState.ToString();
        }
    }
}
