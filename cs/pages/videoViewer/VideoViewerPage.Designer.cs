namespace owoMedia.cs.pages.videoViewer {
    partial class VideoViewerPage {
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
            this.lblState = new System.Windows.Forms.Label();
            this.btnOwoShoot = new System.Windows.Forms.Button();
            this.viewerHeader = new owoMedia.cs.pages.components.ViewerHeader();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(1182, 103);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(30, 13);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "state";
            // 
            // btnOwoShoot
            // 
            this.btnOwoShoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOwoShoot.Location = new System.Drawing.Point(1182, 138);
            this.btnOwoShoot.Name = "btnOwoShoot";
            this.btnOwoShoot.Size = new System.Drawing.Size(96, 29);
            this.btnOwoShoot.TabIndex = 13;
            this.btnOwoShoot.Text = "OWO Test";
            this.btnOwoShoot.UseVisualStyleBackColor = true;
            this.btnOwoShoot.Click += new System.EventHandler(this.btnOwoShoot_Click);
            // 
            // viewerHeader
            // 
            this.viewerHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewerHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewerHeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewerHeader.Location = new System.Drawing.Point(0, 0);
            this.viewerHeader.Name = "viewerHeader";
            this.viewerHeader.Size = new System.Drawing.Size(1280, 100);
            this.viewerHeader.TabIndex = 14;
            // 
            // VideoViewerPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.viewerHeader);
            this.Controls.Add(this.btnOwoShoot);
            this.Controls.Add(this.lblState);
            this.Name = "VideoViewerPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnOwoShoot;
        private components.ViewerHeader viewerHeader;
    }
}
