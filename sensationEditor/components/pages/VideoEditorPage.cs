using Google.Apis.YouTube.v3.Data;
using Newtonsoft.Json;
using hapticMedia.applicationFrame.Service;
using hapticMedia.genericComponents;
using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.Properties;
using hapticMedia.sensationEditor.data;
using hapticMedia.sensationEditor.data.SensationTemplate;
using hapticMedia.sensationPlayer;
using hapticMedia.sensationRecorder.components.pages;
using hapticMedia.sensationRecorder.data;
using hapticMedia.videoViewer.data;
using hapticMedia.websocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OWOGame;
using System.Runtime.Remoting.Messaging;
using static hapticMedia.videoViewer.data.WsVideoData;

namespace hapticMedia.sensationEditor.components.pages {
    public partial class VideoEditorPage : UserControlPage {

        const string FolderName = "VideoEditor";

        SensationEditorTrack Editor;
        SensationPlayerEditor SensationPlayer = new SensationPlayerEditor();

        double VideoLength = 60.0 * 10;

        public VideoEditorPage() {
            Editor = new SensationEditorTrack();
            // for Designer
            InitializeComponent();
        }

        public VideoEditorPage(string videoId) {
            InitializeComponent();
            this.Editor = new SensationEditorTrack(videoId);
        }
        public VideoEditorPage(SensationEditorTrack track) {
            InitializeComponent();
            this.Editor = track;
        }

        public override void Init() {
            base.Init();

            OpenVideoViewer();

            bgwTime.RunWorkerAsync();
            LabelService.SetFormatedTime(lblMaxTime, VideoLength);

            initSensationsBase();
            initSensationTemplates();
            initSensationsRecordings();
        }

        private void OpenVideoViewer() {
            string html = Resources.videoViewer;
            html = html.Replace("$VIDEO_ID$", Editor.VideoId);
            html = html.Replace("$WS_PORT$", genericComponents.pageDefinition.HapticMedia.Instance.Config.Port.ToString());
            html = html.Replace("$WS_ROUTE$", WsVideoEditorBehavior.Route);

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

        private void initSensationsBase() {
            Dictionary<string, SensationTemplateData> baseTemplates = new Dictionary<string, SensationTemplateData>();

            SensationTemplateData ball = BaseSensationConstants.Ball();
            SensationTemplateData dagger = BaseSensationConstants.Dagger();
            SensationTemplateData hug = BaseSensationConstants.Hug();
            SensationTemplateData shotWithExit = BaseSensationConstants.ShotWithExit();

            baseTemplates.Add(ball.Name, ball);
            baseTemplates.Add(dagger.Name, dagger);
            baseTemplates.Add(hug.Name, hug);
            baseTemplates.Add(shotWithExit.Name, shotWithExit);

            listBasicSensation.DataSource = new BindingSource(baseTemplates, null);
            listBasicSensation.DisplayMember = "Key";
            listBasicSensation.ValueMember = "Value";
        }

        private void initSensationTemplates() {

        }

        private void initSensationsRecordings() {
            Dictionary<string, string> recordings = HapticMediaFileService.GetFilesInDir(SensationRecorderPage.FolderName);

            if (recordings.Count == 0) {
                return;
            }

            listRecordings.DataSource = new BindingSource(recordings, null);
            listRecordings.DisplayMember = "Key";
            listRecordings.ValueMember = "Value";
        }
        private void btnAddSensation_Click(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex == 0) {
                AddBasicSensation();
            } else if (tabControl1.SelectedIndex == 1) {
                AddSensationTemplate();
            } else if (tabControl1.SelectedIndex == 2) {
                AddCapture();
            }
        }

        private void listBasicSensation_MouseDoubleClick(object sender, MouseEventArgs e) {
            int index = this.listBasicSensation.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches) {
                AddBasicSensation();
            }
        }

        private void listSensationTemplates_MouseDoubleClick(object sender, MouseEventArgs e) {
            int index = this.listSensationTemplates.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches) {
                AddSensationTemplate();
            }
        }

        private void listRecordings_MouseDoubleClick(object sender, MouseEventArgs e) {
            int index = this.listRecordings.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches) {
                AddCapture();
            }
        }

        private void AddBasicSensation() {

        }

        private void AddSensationTemplate() {

        }

        private void AddCapture() {
            double curTime = SensationPlayer.GetCurTime();

            string captureString = HapticMediaFileService.LoadFileByPath(listRecordings.SelectedValue.ToString());
            List<CaptureData> capture = JsonConvert.DeserializeObject<List<CaptureData>>(captureString);
            SensationTemplateData[] sensations = new SensationTemplateData[capture.Count];
            foreach (CaptureData captureData in capture) {
                SensationTemplateData template = new SensationTemplateDataString(SensationTemplateData.TemplateType.TemplateCapture, "Timestamp_" + captureData.TimeStamp, captureData.TimestampSeconds(), captureData.Capture);
                sensations[capture.IndexOf(captureData)] = template;
            }
            SensationTemplateData compound = new SensationTemplateDataCapture(listRecordings.DisplayMember, curTime, sensations);
            AddToTimeline(compound);
            MessageBox.Show(captureString);
        }

        private void AddToTimeline(SensationTemplateData template) {
            double length = template.GetSensationWrapper().GetLength();

            Editor.Track[template.Timestamp] = template;
            SensationPlayer.SensationSequence[template.Timestamp] = template.GetSensationWrapper();
            SensationPlayer.Sync();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Editor.Title = txtTitle.Text;
            string EditorString = JsonConvert.SerializeObject(Editor);
            HapticMediaFileService.SaveFile(EditorString, FolderName, Editor.VideoId);
        }

        private void ckbPlayOwo_CheckedChanged(object sender, EventArgs e) {
            SensationPlayer.MuteSensation = !ckbPlayOwo.Checked;
        }

        StateEnum lastState = StateEnum.Unstarted;
        public List<string> OnWsMessage(WsVideoData dto) {
            if (this.lblState.InvokeRequired) {
                return (List<string>)this.lblState.Invoke(
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

            if (dto.videoId != Editor.VideoId) {
                messages.Add("IdError");
                return messages;
            }

            switch (dto.useCase) {
                case "init":
                    messages.Add("Connected");
                    lastState = StateEnum.Unstarted;
                    break;
                case "state":
                    OnStateChange(dto, messages);
                    break;
                case "time":
                    SensationPlayer.TimeCheck(dto.timeStamp);
                    break;
                default:
                    Console.WriteLine("Unknown Usecase: " + dto.useCase);
                    break;
            }

            return messages;
        }


        private void OnStateChange(WsVideoData dto, List<string> messages) {
            StateEnum newState = (StateEnum)Int16.Parse(dto.value);


            if (lastState == StateEnum.Unstarted && !SensationPlayer.GetCurTime().Equals(0)) {
                messages.Add("GoTo_" + SensationPlayer.GetCurTime());
            }

            if (lastState != StateEnum.Playing && newState == StateEnum.Playing) {
                SensationPlayer.Start();
            } else if (lastState == StateEnum.Playing && newState != StateEnum.Playing) {
                SensationPlayer.Stop();
            }

            lastState = newState;
            this.lblState.Text = lastState.ToString();

            SensationPlayer.Sync(dto.timeStamp);
        }


        public override void OnLeave() {
            base.OnLeave();
            bgwTime.CancelAsync();
        }

        private void bgwTime_DoWork(object sender, DoWorkEventArgs e) {
            while (!bgwTime.CancellationPending) {
                bgwTime.ReportProgress(0);
                Thread.Sleep(100);
            }
        }

        private void bgwTime_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            LabelService.SetFormatedTime(lblCurTime, SensationPlayer.GetCurTime());
        }

        private void pnlTimeline_Click(object sender, EventArgs e) {

        }

        private void btnOpenViewer_Click(object sender, EventArgs e) {
            OpenVideoViewer();
        }
    }
}
