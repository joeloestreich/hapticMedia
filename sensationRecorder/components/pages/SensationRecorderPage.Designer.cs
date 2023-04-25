namespace hapticMedia.sensationRecorder.components.pages {
    partial class SensationRecorderPage {
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
            this.bgwCapture = new System.ComponentModel.BackgroundWorker();
            this.btnStopCapture = new System.Windows.Forms.Button();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pageHeader1 = new hapticMedia.genericComponents.pageHeader.PageHeader();
            this.SuspendLayout();
            // 
            // bgwCapture
            // 
            this.bgwCapture.WorkerReportsProgress = true;
            this.bgwCapture.WorkerSupportsCancellation = true;
            this.bgwCapture.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCapture_DoWork);
            this.bgwCapture.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCapture_ProgressChanged);
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.Location = new System.Drawing.Point(28, 320);
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(363, 80);
            this.btnStopCapture.TabIndex = 3;
            this.btnStopCapture.Text = "Stop Recording";
            this.btnStopCapture.UseVisualStyleBackColor = true;
            this.btnStopCapture.Click += new System.EventHandler(this.btnStopCapture_Click);
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Location = new System.Drawing.Point(28, 234);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(363, 80);
            this.btnStartCapture.TabIndex = 2;
            this.btnStartCapture.Text = "Start Recording";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "test owo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(422, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(824, 594);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pageHeader1
            // 
            this.pageHeader1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pageHeader1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.Size = new System.Drawing.Size(1280, 100);
            this.pageHeader1.TabIndex = 4;
            // 
            // SensationRecorderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pageHeader1);
            this.Controls.Add(this.btnStopCapture);
            this.Controls.Add(this.btnStartCapture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SensationRecorderPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.Button btnStopCapture;
        private System.ComponentModel.BackgroundWorker bgwCapture;
        private genericComponents.pageHeader.PageHeader pageHeader1;
    }
}
