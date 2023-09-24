namespace hapticMedia.sensationEditor.components.pages {
    partial class VideoEditorPage {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.pageHeader1 = new hapticMedia.genericComponents.pageHeader.PageHeader();
            this.lblCurTime = new System.Windows.Forms.Label();
            this.lblMaxTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bgwTime = new System.ComponentModel.BackgroundWorker();
            this.pnlSensationConfig = new System.Windows.Forms.Panel();
            this.tcSensationEditor = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.createNewSensationPanel1 = new hapticMedia.sensationEditor.components.TemplateComponents.CreateNewSensationPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPreviewFeel = new System.Windows.Forms.Button();
            this.btnAddSensation = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ckbPlayOwo = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBasicSensation = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listSensationTemplates = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listRecordings = new System.Windows.Forms.ListBox();
            this.btnOpenViewer = new System.Windows.Forms.Button();
            this.pnlDetailTimeWrapper = new System.Windows.Forms.Panel();
            this.pnlTimelineDetail = new hapticMedia.sensationEditor.components.TimelinePanel();
            this.pnlTimelineFull = new hapticMedia.sensationEditor.components.TimelinePanel();
            this.btnNavFirst = new System.Windows.Forms.Button();
            this.btnNavBack = new System.Windows.Forms.Button();
            this.btnNavLast = new System.Windows.Forms.Button();
            this.btnNavForward = new System.Windows.Forms.Button();
            this.btnNavConflict = new System.Windows.Forms.Button();
            this.btnRemoveSensation = new System.Windows.Forms.Button();
            this.pnlSensationConfig.SuspendLayout();
            this.tcSensationEditor.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlDetailTimeWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "State";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(132, 112);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(62, 25);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "State";
            // 
            // pageHeader1
            // 
            this.pageHeader1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pageHeader1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.Size = new System.Drawing.Size(1280, 100);
            this.pageHeader1.TabIndex = 8;
            // 
            // lblCurTime
            // 
            this.lblCurTime.AutoSize = true;
            this.lblCurTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurTime.Location = new System.Drawing.Point(132, 137);
            this.lblCurTime.Name = "lblCurTime";
            this.lblCurTime.Size = new System.Drawing.Size(96, 25);
            this.lblCurTime.TabIndex = 9;
            this.lblCurTime.Text = "00:00:00";
            // 
            // lblMaxTime
            // 
            this.lblMaxTime.AutoSize = true;
            this.lblMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTime.Location = new System.Drawing.Point(258, 137);
            this.lblMaxTime.Name = "lblMaxTime";
            this.lblMaxTime.Size = new System.Drawing.Size(96, 25);
            this.lblMaxTime.TabIndex = 10;
            this.lblMaxTime.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "/";
            // 
            // bgwTime
            // 
            this.bgwTime.WorkerReportsProgress = true;
            this.bgwTime.WorkerSupportsCancellation = true;
            this.bgwTime.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTime_DoWork);
            this.bgwTime.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwTime_ProgressChanged);
            // 
            // pnlSensationConfig
            // 
            this.pnlSensationConfig.Controls.Add(this.tcSensationEditor);
            this.pnlSensationConfig.Location = new System.Drawing.Point(3, 337);
            this.pnlSensationConfig.Name = "pnlSensationConfig";
            this.pnlSensationConfig.Size = new System.Drawing.Size(846, 380);
            this.pnlSensationConfig.TabIndex = 13;
            // 
            // tcSensationEditor
            // 
            this.tcSensationEditor.Controls.Add(this.tabPage4);
            this.tcSensationEditor.Location = new System.Drawing.Point(0, 0);
            this.tcSensationEditor.Name = "tcSensationEditor";
            this.tcSensationEditor.SelectedIndex = 0;
            this.tcSensationEditor.Size = new System.Drawing.Size(846, 380);
            this.tcSensationEditor.TabIndex = 0;
            this.tcSensationEditor.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcSensationEditor_Selected);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.createNewSensationPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(838, 354);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "+";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // createNewSensationPanel1
            // 
            this.createNewSensationPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createNewSensationPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.createNewSensationPanel1.Location = new System.Drawing.Point(1, 0);
            this.createNewSensationPanel1.Name = "createNewSensationPanel1";
            this.createNewSensationPanel1.Size = new System.Drawing.Size(838, 354);
            this.createNewSensationPanel1.TabIndex = 0;
            this.createNewSensationPanel1.TemplateCreatedEvent += new hapticMedia.sensationEditor.components.TemplateComponents.CreateNewSensationPanel.TemplateCreated(this.CreatePanel_TemplateCreatedEvent);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPreviewFeel);
            this.panel3.Controls.Add(this.btnAddSensation);
            this.panel3.Location = new System.Drawing.Point(855, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 402);
            this.panel3.TabIndex = 14;
            // 
            // btnPreviewFeel
            // 
            this.btnPreviewFeel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewFeel.Location = new System.Drawing.Point(309, 363);
            this.btnPreviewFeel.Name = "btnPreviewFeel";
            this.btnPreviewFeel.Size = new System.Drawing.Size(96, 25);
            this.btnPreviewFeel.TabIndex = 20;
            this.btnPreviewFeel.Text = "Feel";
            this.btnPreviewFeel.UseVisualStyleBackColor = true;
            this.btnPreviewFeel.Click += new System.EventHandler(this.btnPreviewFeel_Click);
            // 
            // btnAddSensation
            // 
            this.btnAddSensation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSensation.Location = new System.Drawing.Point(4, 363);
            this.btnAddSensation.Name = "btnAddSensation";
            this.btnAddSensation.Size = new System.Drawing.Size(299, 25);
            this.btnAddSensation.TabIndex = 19;
            this.btnAddSensation.Text = "Add Sensation at Current Position";
            this.btnAddSensation.UseVisualStyleBackColor = true;
            this.btnAddSensation.Click += new System.EventHandler(this.btnAddSensation_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(411, 127);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(849, 26);
            this.txtTitle.TabIndex = 15;
            this.txtTitle.Text = "Some Video Title you are working with";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1150, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 25);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ckbPlayOwo
            // 
            this.ckbPlayOwo.AutoSize = true;
            this.ckbPlayOwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPlayOwo.Location = new System.Drawing.Point(36, 165);
            this.ckbPlayOwo.Name = "ckbPlayOwo";
            this.ckbPlayOwo.Size = new System.Drawing.Size(141, 24);
            this.ckbPlayOwo.TabIndex = 18;
            this.ckbPlayOwo.Text = "Play Sensations";
            this.ckbPlayOwo.UseVisualStyleBackColor = true;
            this.ckbPlayOwo.CheckedChanged += new System.EventHandler(this.ckbPlayOwo_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(855, 315);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBasicSensation);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(397, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Base Sensations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBasicSensation
            // 
            this.listBasicSensation.FormattingEnabled = true;
            this.listBasicSensation.Location = new System.Drawing.Point(0, 1);
            this.listBasicSensation.Name = "listBasicSensation";
            this.listBasicSensation.Size = new System.Drawing.Size(397, 329);
            this.listBasicSensation.TabIndex = 2;
            this.listBasicSensation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBasicSensation_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listSensationTemplates);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sensation Templates";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listSensationTemplates
            // 
            this.listSensationTemplates.FormattingEnabled = true;
            this.listSensationTemplates.Location = new System.Drawing.Point(0, 1);
            this.listSensationTemplates.Name = "listSensationTemplates";
            this.listSensationTemplates.Size = new System.Drawing.Size(397, 329);
            this.listSensationTemplates.TabIndex = 1;
            this.listSensationTemplates.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSensationTemplates_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listRecordings);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(397, 331);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recordings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listRecordings
            // 
            this.listRecordings.FormattingEnabled = true;
            this.listRecordings.Location = new System.Drawing.Point(0, 0);
            this.listRecordings.Name = "listRecordings";
            this.listRecordings.Size = new System.Drawing.Size(397, 329);
            this.listRecordings.TabIndex = 0;
            this.listRecordings.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listRecordings_MouseDoubleClick);
            // 
            // btnOpenViewer
            // 
            this.btnOpenViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenViewer.Location = new System.Drawing.Point(411, 156);
            this.btnOpenViewer.Name = "btnOpenViewer";
            this.btnOpenViewer.Size = new System.Drawing.Size(132, 25);
            this.btnOpenViewer.TabIndex = 19;
            this.btnOpenViewer.Text = "Open Viewer";
            this.btnOpenViewer.UseVisualStyleBackColor = true;
            this.btnOpenViewer.Click += new System.EventHandler(this.btnOpenViewer_Click);
            // 
            // pnlDetailTimeWrapper
            // 
            this.pnlDetailTimeWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetailTimeWrapper.AutoScroll = true;
            this.pnlDetailTimeWrapper.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDetailTimeWrapper.Controls.Add(this.pnlTimelineDetail);
            this.pnlDetailTimeWrapper.Location = new System.Drawing.Point(8, 236);
            this.pnlDetailTimeWrapper.Name = "pnlDetailTimeWrapper";
            this.pnlDetailTimeWrapper.Size = new System.Drawing.Size(1267, 53);
            this.pnlDetailTimeWrapper.TabIndex = 20;
            // 
            // pnlTimelineDetail
            // 
            this.pnlTimelineDetail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTimelineDetail.Location = new System.Drawing.Point(0, 2);
            this.pnlTimelineDetail.Name = "pnlTimelineDetail";
            this.pnlTimelineDetail.Size = new System.Drawing.Size(1267, 39);
            this.pnlTimelineDetail.TabIndex = 22;
            this.pnlTimelineDetail.Click += new System.EventHandler(this.pnlTimelineDetail_Click);
            this.pnlTimelineDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTimelineDetail_Paint);
            // 
            // pnlTimelineFull
            // 
            this.pnlTimelineFull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimelineFull.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTimelineFull.Location = new System.Drawing.Point(8, 205);
            this.pnlTimelineFull.Name = "pnlTimelineFull";
            this.pnlTimelineFull.Size = new System.Drawing.Size(1267, 30);
            this.pnlTimelineFull.TabIndex = 21;
            this.pnlTimelineFull.Click += new System.EventHandler(this.pnlTimelineFull_Click);
            this.pnlTimelineFull.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTimelineFull_Paint);
            // 
            // btnNavFirst
            // 
            this.btnNavFirst.Enabled = false;
            this.btnNavFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavFirst.Location = new System.Drawing.Point(8, 306);
            this.btnNavFirst.Name = "btnNavFirst";
            this.btnNavFirst.Size = new System.Drawing.Size(38, 25);
            this.btnNavFirst.TabIndex = 22;
            this.btnNavFirst.Text = "<<";
            this.btnNavFirst.UseVisualStyleBackColor = true;
            this.btnNavFirst.Click += new System.EventHandler(this.btnNavFirst_Click);
            // 
            // btnNavBack
            // 
            this.btnNavBack.Enabled = false;
            this.btnNavBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavBack.Location = new System.Drawing.Point(52, 306);
            this.btnNavBack.Name = "btnNavBack";
            this.btnNavBack.Size = new System.Drawing.Size(38, 25);
            this.btnNavBack.TabIndex = 23;
            this.btnNavBack.Text = "<";
            this.btnNavBack.UseVisualStyleBackColor = true;
            this.btnNavBack.Click += new System.EventHandler(this.btnNavBack_Click);
            // 
            // btnNavLast
            // 
            this.btnNavLast.Enabled = false;
            this.btnNavLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavLast.Location = new System.Drawing.Point(140, 306);
            this.btnNavLast.Name = "btnNavLast";
            this.btnNavLast.Size = new System.Drawing.Size(38, 25);
            this.btnNavLast.TabIndex = 25;
            this.btnNavLast.Text = ">>";
            this.btnNavLast.UseVisualStyleBackColor = true;
            this.btnNavLast.Click += new System.EventHandler(this.btnNavLast_Click);
            // 
            // btnNavForward
            // 
            this.btnNavForward.Enabled = false;
            this.btnNavForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavForward.Location = new System.Drawing.Point(96, 306);
            this.btnNavForward.Name = "btnNavForward";
            this.btnNavForward.Size = new System.Drawing.Size(38, 25);
            this.btnNavForward.TabIndex = 24;
            this.btnNavForward.Text = ">";
            this.btnNavForward.UseVisualStyleBackColor = true;
            this.btnNavForward.Click += new System.EventHandler(this.btnNavForward_Click);
            // 
            // btnNavConflict
            // 
            this.btnNavConflict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavConflict.Location = new System.Drawing.Point(184, 306);
            this.btnNavConflict.Name = "btnNavConflict";
            this.btnNavConflict.Size = new System.Drawing.Size(38, 25);
            this.btnNavConflict.TabIndex = 26;
            this.btnNavConflict.Text = "!";
            this.btnNavConflict.UseVisualStyleBackColor = true;
            this.btnNavConflict.Visible = false;
            this.btnNavConflict.Click += new System.EventHandler(this.btnNavConflict_Click);
            // 
            // btnRemoveSensation
            // 
            this.btnRemoveSensation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSensation.Location = new System.Drawing.Point(689, 306);
            this.btnRemoveSensation.Name = "btnRemoveSensation";
            this.btnRemoveSensation.Size = new System.Drawing.Size(160, 25);
            this.btnRemoveSensation.TabIndex = 27;
            this.btnRemoveSensation.Text = "Remove Sensation";
            this.btnRemoveSensation.UseVisualStyleBackColor = true;
            this.btnRemoveSensation.Visible = false;
            this.btnRemoveSensation.Click += new System.EventHandler(this.btnRemoveSensation_Click);
            // 
            // VideoEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveSensation);
            this.Controls.Add(this.btnNavConflict);
            this.Controls.Add(this.btnNavLast);
            this.Controls.Add(this.btnNavForward);
            this.Controls.Add(this.btnNavBack);
            this.Controls.Add(this.btnNavFirst);
            this.Controls.Add(this.pnlTimelineFull);
            this.Controls.Add(this.pnlDetailTimeWrapper);
            this.Controls.Add(this.btnOpenViewer);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ckbPlayOwo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlSensationConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaxTime);
            this.Controls.Add(this.lblCurTime);
            this.Controls.Add(this.pageHeader1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "VideoEditorPage";
            this.pnlSensationConfig.ResumeLayout(false);
            this.tcSensationEditor.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlDetailTimeWrapper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblState;
        private genericComponents.pageHeader.PageHeader pageHeader1;
        private System.Windows.Forms.Label lblCurTime;
        private System.Windows.Forms.Label lblMaxTime;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker bgwTime;
        private System.Windows.Forms.Panel pnlSensationConfig;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ckbPlayOwo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddSensation;
        private System.Windows.Forms.ListBox listRecordings;
        private System.Windows.Forms.ListBox listSensationTemplates;
        private System.Windows.Forms.ListBox listBasicSensation;
        private System.Windows.Forms.Button btnOpenViewer;
        private System.Windows.Forms.Panel pnlDetailTimeWrapper;
        private System.Windows.Forms.Button btnPreviewFeel;
        private TimelinePanel pnlTimelineFull;
        private TimelinePanel pnlTimelineDetail;
        private System.Windows.Forms.Button btnNavFirst;
        private System.Windows.Forms.Button btnNavBack;
        private System.Windows.Forms.Button btnNavLast;
        private System.Windows.Forms.Button btnNavForward;
        private System.Windows.Forms.Button btnNavConflict;
        private System.Windows.Forms.TabControl tcSensationEditor;
        private System.Windows.Forms.TabPage tabPage4;
        private TemplateComponents.CreateNewSensationPanel createNewSensationPanel1;
        private System.Windows.Forms.Button btnRemoveSensation;
    }
}
