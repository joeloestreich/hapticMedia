namespace owoMedia.cs.pages.videoSelector {
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
            this.viewerHeader = new owoMedia.cs.pages.components.ViewerHeader();
            this.flowVideoList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // viewerHeader
            // 
            this.viewerHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewerHeader.Location = new System.Drawing.Point(-3, 3);
            this.viewerHeader.Name = "viewerHeader";
            this.viewerHeader.Size = new System.Drawing.Size(1280, 100);
            this.viewerHeader.TabIndex = 1;
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
            // VideoSelector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.flowVideoList);
            this.Controls.Add(this.viewerHeader);
            this.Name = "VideoSelector";
            this.ResumeLayout(false);

        }

        #endregion
        private components.ViewerHeader viewerHeader;
        private System.Windows.Forms.FlowLayoutPanel flowVideoList;
    }
}
