namespace owoMedia.cs.pages.components {
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
            this.videoSearch = new owoMedia.cs.pages.components.VideoSearch();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSearch
            // 
            this.videoSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.videoSearch.Location = new System.Drawing.Point(347, 31);
            this.videoSearch.Name = "videoSearch";
            this.videoSearch.Size = new System.Drawing.Size(652, 29);
            this.videoSearch.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbLogo.Location = new System.Drawing.Point(1132, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(145, 57);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // ViewerHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.videoSearch);
            this.Name = "ViewerHeader";
            this.Size = new System.Drawing.Size(1280, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VideoSearch videoSearch;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}
