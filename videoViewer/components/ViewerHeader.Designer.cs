namespace hapticMedia.videoViewer.components {
    partial class ViewerHeader {
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
            this.videoSearch1 = new hapticMedia.videoViewer.components.VideoSearch();
            this.SuspendLayout();
            // 
            // videoSearch1
            // 
            this.videoSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.videoSearch1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.videoSearch1.Location = new System.Drawing.Point(314, 27);
            this.videoSearch1.Name = "videoSearch1";
            this.videoSearch1.Size = new System.Drawing.Size(650, 24);
            this.videoSearch1.TabIndex = 1;
            // 
            // ViewerHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.videoSearch1);
            this.Name = "ViewerHeader";
            this.Controls.SetChildIndex(this.videoSearch1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoSearch videoSearch1;
    }
}
