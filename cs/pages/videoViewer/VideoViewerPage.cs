using OWOGame;
using owoMedia.cs.applicationFrame;
using owoMedia.cs.websocket;
using owoMedia.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owoMedia.cs.pages.videoViewer {
    public partial class VideoViewerPage : UserControlPage {

        string videoId;

        public VideoViewerPage(string videoId){
            this.videoId = videoId;
            InitializeComponent();
        }

        public override void Init() {
            base.Init();
            string html = Resources.videoViewer;
            html = html.Replace("$VIDEO_ID$", videoId);
            html = html.Replace("$WS_PORT$", OwoMedia.Instance.Config.Port.ToString());
            html = html.Replace("$WS_STATE_ROUTE$", WsVideoViewerBehavior.Route);
            //this.webVideo.DocumentText = html;

            string testName = "videoViewerTest.html";
            if (File.Exists(testName)) {
                File.Delete(testName);
            }
            using (FileStream fs = File.Create(testName)) {
                Byte[] title = new UTF8Encoding(true).GetBytes(html);
                fs.Write(title, 0, title.Length);
            }
            System.Diagnostics.Process.Start(testName);
        }



        VideoInfo.StateEnum lastState = VideoInfo.StateEnum.Unstarted;
        public void OnStateChange(VideoInfo dto) {
            stateChangeDelegate = new OnStateChangeDelegate(ActualOnStateChange);
            this.Invoke(stateChangeDelegate, new object[] { dto });
        }

        public delegate void OnStateChangeDelegate(VideoInfo dto);
        public OnStateChangeDelegate stateChangeDelegate;
        public void ActualOnStateChange(VideoInfo dto) {
            VideoInfo.StateEnum newState = (VideoInfo.StateEnum) Int16.Parse(dto.value);


            // lastly
            lastState = newState;

            this.lblState.Text = lastState.ToString();
        }

        private void btnOwoShoot_Click(object sender, EventArgs e) {

            MicroSensation ball = SensationsFactory.Create(100, 0.1f, 100, 0, 0, 0);
            Sensation softBall = ball.WithMuscles(Muscle.Pectoral_R.WithIntensity(50));

            OWO.Send(softBall);
        }

        public override void OnLeave() {
            base.OnLeave();
            // stops Sensations

        }
    }
}
