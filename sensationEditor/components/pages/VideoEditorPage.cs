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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using WebSocketSharp.Server;
using hapticMedia.sensationEditor.components.TemplateComponents;

namespace hapticMedia.sensationEditor.components.pages {
    public partial class VideoEditorPage : UserControlPage {

        const string FolderName = "VideoEditor";

        SensationEditorTrack Editor;
        SensationPlayerEditor SensationPlayer = new SensationPlayerEditor();


        public delegate void OnWsMessageDelegate(WsVideoData dto);
        public OnWsMessageDelegate wsMessageDelegate;
        StateEnum lastState = StateEnum.Unstarted;

        bool HasCollision = false;

        double VideoLength = 2 * 60 + 41;
        SensationTemplateData SelectedSensation = null;

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
            EnableNavButtons();
        }

        public override void Init() {
            base.Init();

            OpenVideoViewer();

            pnlTimelineDetail.Bounds = new Rectangle(new Point(0, 0), new Size((int)(VideoLength * 30), 40));
            pnlDetailTimeWrapper.AutoScroll = false;
            pnlDetailTimeWrapper.VerticalScroll.Enabled = false;
            pnlDetailTimeWrapper.VerticalScroll.Visible = false;
            pnlDetailTimeWrapper.VerticalScroll.Maximum = 0;
            pnlDetailTimeWrapper.AutoScroll = true;


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
            Dictionary<string, Func<SensationTemplateData>> baseTemplates = new Dictionary<string, Func<SensationTemplateData>> {
                { "Ball", BaseSensationConstants.Ball },
                { "Dagger", BaseSensationConstants.Dagger },
                { "Hug", BaseSensationConstants.Hug },
                { "Shot With Exit", BaseSensationConstants.ShotWithExit }
            };

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
            SensationTemplateData template = ((Func<SensationTemplateData>)listBasicSensation.SelectedValue).Invoke();
            if (template is SensationTemplateDataValue) {
                template = new SensationTemplateDataCompound(template.Name, template);
            }
            AddToTimeline(template);
        }

        private void AddSensationTemplate() {
            AddToTimeline((SensationTemplateData)listSensationTemplates.SelectedValue);
        }

        private void AddCapture() {
            string captureString = HapticMediaFileService.LoadFileByPath(listRecordings.SelectedValue.ToString());
            List<CaptureData> capture = JsonConvert.DeserializeObject<List<CaptureData>>(captureString);
            Dictionary<double, SensationTemplateData> sensations = new Dictionary<double, SensationTemplateData>();
            foreach (CaptureData captureData in capture) {
                SensationTemplateData template = new SensationTemplateDataString(SensationTemplateData.TemplateType.TemplateCapture, "Timestamp_" + captureData.TimeStamp, captureData.Capture);
                sensations[captureData.TimestampSeconds()] = template;
            }
            SensationTemplateData compound = new SensationTemplateDataCapture(listRecordings.DisplayMember, sensations, SensationPlayer.GetCurTime());
            AddToTimeline(compound);
        }

        private void AddToTimeline(SensationTemplateData template) {
            if (lastState == StateEnum.Playing) {
                MessageBox.Show("Cant add while video is playing");
                return;
            }

            double curTime = SensationPlayer.GetCurTime();

            Editor.Track[curTime] = template;
            SensationPlayer.SensationSequence[curTime] = template.GetSensationWrapper();
            SensationPlayer.Sync();

            UpdateTimeline();
            EnableNavButtons();
            openSensationTemplate(template);
        }

        private void UpdateTimeline() {
            pnlTimelineFull.Controls.Clear();
            pnlTimelineDetail.Controls.Clear();

            double lastSensationFinish = -1;
            HasCollision = false;

            List<double> timestamps = new List<double>(Editor.Track.Keys).OrderBy(x => x).ToList();

            foreach (double timeStamp in timestamps) {
                SensationTemplateData template = Editor.Track[timeStamp];

                bool collision = timeStamp < lastSensationFinish;
                HasCollision |= collision;

                AddTimelineSensation(timeStamp, template, pnlTimelineFull, collision);
                AddTimelineSensation(timeStamp, template, pnlTimelineDetail, collision);

                double curSensationFinish = timeStamp + template.GetSensationWrapper().GetLengthInSeconds();
                if (curSensationFinish > lastSensationFinish) {
                    lastSensationFinish = curSensationFinish;
                }
            }


        }

        private void AddTimelineSensation(double timeStamp, SensationTemplateData template, Panel parent, bool collision) {
            UserControlBase sensationBox = new UserControlBase();
            sensationBox.BorderStyle = BorderStyle.FixedSingle;

            if (collision) {
                sensationBox.Location = new Point((int)(timeStamp / VideoLength * parent.Width), 5);
                sensationBox.Size = new Size(Math.Max((int)(template.GetSensationWrapper().GetLengthInSeconds() / VideoLength * parent.Width), 5), 20);
                sensationBox.BackColor = Color.Red;
            } else {
                sensationBox.Location = new Point((int)(timeStamp / VideoLength * parent.Width), 10);
                sensationBox.Size = new Size(Math.Max((int)(template.GetSensationWrapper().GetLengthInSeconds() / VideoLength * parent.Width), 2), 20);
                sensationBox.BackColor = Color.DeepSkyBlue;
            }

            if (template.Equals(SelectedSensation)) {
                sensationBox.BackColor = Color.LightGoldenrodYellow;
            }

            sensationBox.Click += (sender, e) => { openSensationTemplate(template); };

            parent.Controls.Add(sensationBox);
        }

        private void btnNavFirst_Click(object sender, EventArgs e) {
            List<double> timestamps = new List<double>(Editor.Track.Keys).OrderBy(x => x).ToList();
            openSensationTemplate(Editor.Track[timestamps.First()]);
        }

        private void btnNavBack_Click(object sender, EventArgs e) {
            List<double> timestamps = new List<double>(Editor.Track.Keys).OrderBy(x => x).ToList();
            foreach(var entry in Editor.Track) {
                if (entry.Value.Equals(SelectedSensation)) {
                    openSensationTemplate(Editor.Track[timestamps[timestamps.IndexOf(entry.Key) - 1]]);
                    break;
                }
            }
        }

        private void btnNavForward_Click(object sender, EventArgs e) {
            List<double> timestamps = new List<double>(Editor.Track.Keys).OrderBy(x => x).ToList();
            foreach (var entry in Editor.Track) {
                if (entry.Value.Equals(SelectedSensation)) {
                    openSensationTemplate(Editor.Track[timestamps[timestamps.IndexOf(entry.Key) + 1]]);
                    break;
                }
            }
        }

        private void btnNavLast_Click(object sender, EventArgs e) {
            List<double> timestamps = new List<double>(Editor.Track.Keys).OrderBy(x => x).ToList();
            openSensationTemplate(Editor.Track[timestamps.Last()]);
        }

        private void btnNavConflict_Click(object sender, EventArgs e) {
            double lastSensationFinish = -1;
            List<double> timestamps = new List<double>(Editor.Track.Keys).OrderBy(x => x).ToList();
            foreach (double timestamp in timestamps) {
                SensationTemplateData template = Editor.Track[timestamp];

                double curSensationFinish = timestamp + template.GetSensationWrapper().GetLengthInSeconds();
                if (curSensationFinish > lastSensationFinish) {
                    lastSensationFinish = curSensationFinish;
                } else {
                    openSensationTemplate(template);
                    break;
                }
            }
        }

        private void openSensationTemplate(SensationTemplateData template) {
            SelectedSensation = template;
            EnableNavButtons();
            UpdateTimeline();

            tcSensationEditor.TabPages.Clear();
            AddSensationTab(template, !(template is  SensationTemplateDataCapture));
        }

        private void AddSensationTab(SensationTemplateData template, bool addCreateTab) {
            if (template is SensationTemplateDataCompound) {
                SensationTemplateDataCompound compound = template as SensationTemplateDataCompound;
                foreach (SensationTemplateData part in compound.Sensations) {
                    AddSensationTab(part, false);
                }
            } else if(template is SensationTemplateDataValue) {
                AddSensationTabValue(template);
            } else if (template is SensationTemplateDataCapture) {

            }

            if (addCreateTab) {
                AddSensationTabLoop(template);
            }
        }

        private void AddSensationTabValue(SensationTemplateData template) {
            TabPage tab = new TabPage(template.Name);

            TemplateEditorValue edit = new TemplateEditorValue(template as SensationTemplateDataValue);
            edit.TemplateChangedEvent += Edit_TemplateChangedEvent;
            tab.Controls.Add(edit);

            tcSensationEditor.TabPages.Add(tab);
        }

        private void AddSensationTabLoop(SensationTemplateData template) {
            TabPage LoopTab = new TabPage("+");
            CreateNewSensationPanel createPanel = new CreateNewSensationPanel(template);
            createPanel.TemplateCreatedEvent += CreatePanel_TemplateCreatedEvent;
            LoopTab.Controls.Add(createPanel);
            tcSensationEditor.TabPages.Add(LoopTab);
        }

        private void CreatePanel_TemplateCreatedEvent(object sender, SensationTemplateData template) {
            foreach (TabPage tp in tcSensationEditor.TabPages) {
                foreach (var con in tp.Controls) {
                    if (con is CreateNewSensationPanel) {

                        if (SelectedSensation is SensationTemplateDataCompound) {
                            AddSensationTab(template, false);
                            ((SensationTemplateDataCompound)SelectedSensation).AddSensation(template);
                            ReAddCreateTab(tp, tcSensationEditor.SelectedIndex);
                            UpdateTimeline();
                        } else if (SelectedSensation == null) {
                            SensationTemplateDataCompound newTemplate =  new SensationTemplateDataCompound(template.Name, template);
                            AddToTimeline(newTemplate);
                            openSensationTemplate(newTemplate);
                        }
                        return;
                    }
                }
            }
        }

        private void tcSensationEditor_Selected(object sender, TabControlEventArgs e) {
            if (e.TabPage == null) {
                return;
            }

            foreach (var con in e.TabPage.Controls) {
                if (con is CreateNewSensationPanel && SelectedSensation is SensationTemplateDataCompound) {
                    CreateNewSensationPanel createPanel = (CreateNewSensationPanel) con;

                    List<SensationTemplateData> predefined = createPanel.OnOpenTab();
                    if (predefined == null) {
                        return;
                    }

                    foreach (SensationTemplateData part in predefined) {
                        AddSensationTab(part, false);
                        ((SensationTemplateDataCompound)SelectedSensation).AddSensation(part);
                    }

                    ReAddCreateTab(e.TabPage, e.TabPageIndex);
                    UpdateTimeline();
                }
            }
        }

        private void ReAddCreateTab(TabPage tab, int index) {
            tcSensationEditor.TabPages.Remove(tab);
            tcSensationEditor.TabPages.Add(tab);
            tcSensationEditor.SelectedIndex = index;
        }

        private void Edit_TemplateChangedEvent(object sender, SensationTemplateData editTemplate) {
            foreach (var entry in Editor.Track) {
                double timestamp = entry.Key;
                SensationTemplateData template = entry.Value;

                if (SelectedSensation is SensationTemplateDataCompound) {
                    if (template is SensationTemplateDataCompound && ((SensationTemplateDataCompound)template).Sensations.Contains(editTemplate)) {
                        SensationPlayer.SensationSequence[timestamp] = template.GetSensationWrapper();
                        break;
                    }
                }
            }
            UpdateTimeline();
        }

        private void EnableNavButtons() {
            List<double> timestamps = new List<double>(Editor.Track.Keys).OrderBy(x => x).ToList();

            btnNavConflict.Visible = HasCollision;

            if (!timestamps.Any()) {
                btnNavFirst.Enabled = false;
                btnNavBack.Enabled = false;
                btnNavForward.Enabled = false;
                btnNavLast.Enabled = false;

                btnRemoveSensation.Visible = false;
                return;
            }

            btnNavFirst.Enabled = true;
            btnNavBack.Enabled = true;
            btnNavForward.Enabled = true;
            btnNavLast.Enabled = true;

            if (Editor.Track[timestamps.First()].Equals(SelectedSensation)) {
                btnNavFirst.Enabled = false;
                btnNavBack.Enabled = false;
            }
            if (Editor.Track[timestamps.Last()].Equals(SelectedSensation)) {
                btnNavForward.Enabled = false;
                btnNavLast.Enabled = false;
            }
            if (SelectedSensation == null) {
                btnNavBack.Enabled = false;
                btnNavForward.Enabled = false;

                btnRemoveSensation.Visible = false;
            } else {
                btnRemoveSensation.Visible = true;
            }
        }

        private void btnPreviewFeel_Click(object sender, EventArgs e) {
            SensationTemplateData template;
            if (tabControl1.SelectedIndex == 0) {
                template = ((Func<SensationTemplateData>)listBasicSensation.SelectedValue).Invoke();
            } else if (tabControl1.SelectedIndex == 1) {
                template = (SensationTemplateData) listSensationTemplates.SelectedValue;
            } else {
                // not a feature
                return;
            }

            OWO.Send(template.GetSensationWrapper().GetSensation());
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Editor.Title = txtTitle.Text;
            string EditorString = JsonConvert.SerializeObject(Editor);
            HapticMediaFileService.SaveFile(EditorString, FolderName, Editor.VideoId);

            if (HasCollision) {
                MessageBox.Show("There are Collsions in your Sensations. You wont be able to upload this.");
            }
        }

        private void pnlTimelineFull_Click(object sender, EventArgs e) {
            GoToTime(pnlTimelineFull, e as MouseEventArgs);
        }


        private void pnlTimelineDetail_Click(object sender, EventArgs e) {
            GoToTime(pnlTimelineDetail, e as MouseEventArgs);
        }

        private void GoToTime(Panel pnl, MouseEventArgs e) {
            double clickedPercent = (e.X * 1.0 / pnl.Width);
            double clickedTime = VideoLength * clickedPercent;
            SensationPlayer.Sync(clickedTime);

            if (Editor.Track.ContainsKey(clickedTime)) {
                openSensationTemplate(Editor.Track[clickedTime]);
            } else {
                openSensationTemplate(null);
            }

            ReDrawTimeline();
            WsBroadcast("GoTo_" + clickedTime);
        }

        private void btnOpenViewer_Click(object sender, EventArgs e) {
            OpenVideoViewer();
        }

        private void ckbPlayOwo_CheckedChanged(object sender, EventArgs e) {
            SensationPlayer.MuteSensation = !ckbPlayOwo.Checked;
        }

        private void btnRemoveSensation_Click(object sender, EventArgs e) {
            foreach (var entry in Editor.Track) {
                if (entry.Value.Equals(SelectedSensation)) {
                    Editor.Track.Remove(entry.Key);
                    openSensationTemplate(null);
                    break;
                }
            }
        }

        public List<string> OnWsEvent(WsVideoData dto) {
            if (this.lblState.InvokeRequired) {
                return (List<string>)this.lblState.Invoke(
                  new Func<List<string>>(() => ActualOnWsEvent(dto))
                );
            } else {
                return ActualOnWsEvent(dto);
            }

        }

        private List<string> ActualOnWsEvent(WsVideoData dto) {
            if (dto == null) {
                OnWsClose();
                return null;
            } else {
                return OnWsMessage(dto);
            }
        }

        private void OnWsClose() {
            WsVideoData dto = new WsVideoData();
            dto.value = ((int) StateEnum.Unstarted).ToString();
            dto.timeStamp = SensationPlayer.GetCurTime();
            OnStateChange(dto, new List<string>());
        }

        private List<string> OnWsMessage(WsVideoData dto) {

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
                    bool gotSynced = SensationPlayer.TimeCheck(dto.timeStamp);
                    if (gotSynced) {
                        ReDrawTimeline();
                    }
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
            } else {
                SensationPlayer.Sync(dto.timeStamp);
            }

            if (lastState != StateEnum.Playing && newState == StateEnum.Playing) {
                SensationPlayer.Start();
                btnAddSensation.Enabled = false;
            } else if (lastState == StateEnum.Playing && newState != StateEnum.Playing) {
                SensationPlayer.Stop();
                btnAddSensation.Enabled = true;
            }

            lastState = newState;

            this.lblState.Text = lastState.ToString();
            ReDrawTimeline();
        }

        private void ReDrawTimeline() {
            this.pnlTimelineFull.Invalidate();
            this.pnlTimelineDetail.Invalidate();
        }

        private void WsBroadcast(string message) {
            WebSocketService.server.WebSocketServices[WsVideoEditorBehavior.Route].Sessions.Broadcast(message);
        }


        public override void OnLeave() {
            base.OnLeave();
            SensationPlayer.Stop();
            bgwTime.CancelAsync();
        }

        private void bgwTime_DoWork(object sender, DoWorkEventArgs e) {
            while (!bgwTime.CancellationPending) {
                bgwTime.ReportProgress(0);
                ReDrawTimeline();
                Thread.Sleep(100);
            }
        }

        private void bgwTime_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            LabelService.SetFormatedTime(lblCurTime, SensationPlayer.GetCurTime());
        }
        private void pnlTimelineFull_Paint(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            AddTimelineBars(e, (Panel)sender, false);
        }

        private void pnlTimelineDetail_Paint(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            AddTimelineBars(e, (Panel)sender, true);
        }

        private void AddTimelineBars(PaintEventArgs e, Panel parent, bool isDetail) {
            Pen timePen = new Pen(Color.Black, 1);

            double time = 0;
            while (time < VideoLength) {
                if (time % 10.0 == 0) {
                    DrawLine(e.Graphics, parent, timePen, time, 100);
                } else if (isDetail && time % 5.0 == 0) {
                    DrawLine(e.Graphics, parent, timePen, time, 20);
                } else if (isDetail && time % 1.0 == 0) {
                    DrawLine(e.Graphics, parent, timePen, time, 5);
                }
                time++;
            }

            Pen posPen = new Pen(Color.Black, 3);
            DrawLine(e.Graphics, parent, posPen, SensationPlayer.GetCurTime(), 100);
        }

        private void DrawLine(Graphics g, Panel parent, Pen pen, double time, int height) {
            int x = (int)(time / VideoLength * parent.Width);
            var point1 = new Point(x, 0);
            var point2 = new Point(x, height);
            g.DrawLine(pen, point1, point2);
        }
    }
}
