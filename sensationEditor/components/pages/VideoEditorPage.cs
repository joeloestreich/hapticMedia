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

namespace hapticMedia.sensationEditor.components.pages {
    public partial class VideoEditorPage : UserControlPage {

        const string FolderName = "VideoEditor";

        SensationEditorTrack Editor;
        SensationPlayerEditor SensationPlayer = new SensationPlayerEditor();

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
            base.Init(); string html = Resources.videoViewer;
            html = html.Replace("$VIDEO_ID$", Editor.VideoId);
            html = html.Replace("$WS_PORT$", HapticMedia.Instance.Config.Port.ToString());
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
            bgwTime.RunWorkerAsync();

            initSensationsBase();
            initSensationTemplates();
            initSensationsRecordings();
        }

        private void initSensationsBase() {

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

            //List<CaptureData> CaptureContent ;
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
            string captureString = HapticMediaFileService.LoadFileByPath(listRecordings.SelectedValue.ToString());
            List<CaptureData> capture = JsonConvert.DeserializeObject<List<CaptureData>>(captureString);

            SensationTemplateData[] sensations = new SensationTemplateData[capture.Count];
            foreach (CaptureData captureData in capture) {
                SensationTemplateData template = new SensationTemplateData(SensationTemplateData.TemplateType.TemplateParse, "Timestamp_" + captureData.TimeStamp, captureData.Capture);
                sensations[capture.IndexOf(captureData)] = template;
            }
            SensationTemplateData compound = new SensationTemplateData(SensationTemplateData.TemplateType.TemplateParse, listRecordings.DisplayMember, sensations);

            MessageBox.Show(captureString);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Editor.Title = txtTitle.Text;
            string EditorString = JsonConvert.SerializeObject(Editor);
            HapticMediaFileService.SaveFile(EditorString, FolderName, Editor.VideoId);
        }

        private void ckbPlayOwo_CheckedChanged(object sender, EventArgs e) {
            SensationPlayer.MuteSensation = !ckbPlayOwo.Checked;
        }

        WsVideoData.StateEnum lastState = WsVideoData.StateEnum.Unstarted;
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
                    lastState = WsVideoData.StateEnum.Unstarted;
                    break;
                case "state":
                    OnStateChange(dto);
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


        private void OnStateChange(WsVideoData dto) {
            WsVideoData.StateEnum newState = (WsVideoData.StateEnum)Int16.Parse(dto.value);

            if (lastState != WsVideoData.StateEnum.Playing && newState == WsVideoData.StateEnum.Playing) {
                SensationPlayer.Start();
            } else if (lastState == WsVideoData.StateEnum.Playing && newState != WsVideoData.StateEnum.Playing) {
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
            LabelService.SetFormatedTime(lblCurTime, SensationPlayer.GetTime());
        }
    }
}
