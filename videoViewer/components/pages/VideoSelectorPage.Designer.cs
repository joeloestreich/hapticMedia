namespace hapticMedia.videoViewer.components.pages {
    partial class VideoSelectorPage {
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
            this.flowVideoList = new System.Windows.Forms.FlowLayoutPanel();
            this.viewerHeader1 = new hapticMedia.videoViewer.components.ViewerHeader();
            this.SuspendLayout();
            // 
            // flowVideoList
            // 
            this.flowVideoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowVideoList.AutoScroll = true;
            this.flowVideoList.Location = new System.Drawing.Point(246, 109);
            this.flowVideoList.Name = "flowVideoList";
            this.flowVideoList.Size = new System.Drawing.Size(1034, 611);
            this.flowVideoList.TabIndex = 2;
            // 
            // viewerHeader1
            // 
            this.viewerHeader1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewerHeader1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewerHeader1.Location = new System.Drawing.Point(0, -11);
            this.viewerHeader1.Name = "viewerHeader1";
            this.viewerHeader1.Size = new System.Drawing.Size(1280, 100);
            this.viewerHeader1.TabIndex = 3;
            // 
            // VideoSelectorPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.viewerHeader1);
            this.Controls.Add(this.flowVideoList);
            this.Name = "VideoSelectorPage";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowVideoList;
        private ViewerHeader viewerHeader1;
    }
}
