namespace hapticMedia.sensationEditor.components.pages {
    partial class EditorMenuPage {
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
            this.btnNewTrack = new System.Windows.Forms.Button();
            this.btnEditTrack = new System.Windows.Forms.Button();
            this.btnTemplates = new System.Windows.Forms.Button();
            this.pageHeader1 = new hapticMedia.genericComponents.pageHeader.PageHeader();
            this.pnlInfobox = new System.Windows.Forms.Panel();
            this.btnRelease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewTrack
            // 
            this.btnNewTrack.Location = new System.Drawing.Point(3, 210);
            this.btnNewTrack.Name = "btnNewTrack";
            this.btnNewTrack.Size = new System.Drawing.Size(499, 87);
            this.btnNewTrack.TabIndex = 4;
            this.btnNewTrack.Text = "New Sensation Track";
            this.btnNewTrack.UseVisualStyleBackColor = true;
            this.btnNewTrack.Click += new System.EventHandler(this.btnNewTrack_Click);
            // 
            // btnEditTrack
            // 
            this.btnEditTrack.Location = new System.Drawing.Point(3, 303);
            this.btnEditTrack.Name = "btnEditTrack";
            this.btnEditTrack.Size = new System.Drawing.Size(499, 87);
            this.btnEditTrack.TabIndex = 5;
            this.btnEditTrack.Text = "Edit Sensation Track";
            this.btnEditTrack.UseVisualStyleBackColor = true;
            this.btnEditTrack.Click += new System.EventHandler(this.btnEditTrack_Click);
            // 
            // btnTemplates
            // 
            this.btnTemplates.Location = new System.Drawing.Point(3, 396);
            this.btnTemplates.Name = "btnTemplates";
            this.btnTemplates.Size = new System.Drawing.Size(499, 87);
            this.btnTemplates.TabIndex = 6;
            this.btnTemplates.Text = "Manage Sensations Templates";
            this.btnTemplates.UseVisualStyleBackColor = true;
            this.btnTemplates.Click += new System.EventHandler(this.btnTemplates_Click);
            // 
            // pageHeader1
            // 
            this.pageHeader1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pageHeader1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.Size = new System.Drawing.Size(1280, 100);
            this.pageHeader1.TabIndex = 7;
            // 
            // pnlInfobox
            // 
            this.pnlInfobox.Location = new System.Drawing.Point(632, 148);
            this.pnlInfobox.Name = "pnlInfobox";
            this.pnlInfobox.Size = new System.Drawing.Size(550, 545);
            this.pnlInfobox.TabIndex = 9;
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(3, 547);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(499, 87);
            this.btnRelease.TabIndex = 10;
            this.btnRelease.Text = "Manage Releases";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // EditorMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.pnlInfobox);
            this.Controls.Add(this.pageHeader1);
            this.Controls.Add(this.btnTemplates);
            this.Controls.Add(this.btnEditTrack);
            this.Controls.Add(this.btnNewTrack);
            this.Name = "EditorMenuPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewTrack;
        private System.Windows.Forms.Button btnEditTrack;
        private System.Windows.Forms.Button btnTemplates;
        private genericComponents.pageHeader.PageHeader pageHeader1;
        private System.Windows.Forms.Panel pnlInfobox;
        private System.Windows.Forms.Button btnRelease;
    }
}
