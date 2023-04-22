namespace owoMedia.genericComponents.pageHeader {
    partial class PageHeader {
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.breadCrumNavigation1 = new owoMedia.genericComponents.PageHeader.BreadCrumNavigation();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picLogo.Location = new System.Drawing.Point(1099, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(178, 94);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // breadCrumNavigation1
            // 
            this.breadCrumNavigation1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.breadCrumNavigation1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.breadCrumNavigation1.Location = new System.Drawing.Point(92, 61);
            this.breadCrumNavigation1.Name = "breadCrumNavigation1";
            this.breadCrumNavigation1.Size = new System.Drawing.Size(948, 21);
            this.breadCrumNavigation1.TabIndex = 1;
            // 
            // PageHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.breadCrumNavigation1);
            this.Controls.Add(this.picLogo);
            this.Name = "PageHeader";
            this.Size = new System.Drawing.Size(1280, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private genericComponents.PageHeader.BreadCrumNavigation breadCrumNavigation1;
    }
}
