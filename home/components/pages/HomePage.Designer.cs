namespace owoMedia.home.components.pages {
    partial class HomePage {
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
            this.btnView = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnEditVideo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSensations = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(3, 83);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(499, 87);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Browse Videos";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(746, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 191);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(3, 581);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(499, 87);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnEditVideo
            // 
            this.btnEditVideo.Location = new System.Drawing.Point(3, 237);
            this.btnEditVideo.Name = "btnEditVideo";
            this.btnEditVideo.Size = new System.Drawing.Size(499, 87);
            this.btnEditVideo.TabIndex = 3;
            this.btnEditVideo.Text = "Manage Videos";
            this.btnEditVideo.UseVisualStyleBackColor = true;
            this.btnEditVideo.Click += new System.EventHandler(this.btnEditVideo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(1195, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 66);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnSensations
            // 
            this.btnSensations.Location = new System.Drawing.Point(3, 330);
            this.btnSensations.Name = "btnSensations";
            this.btnSensations.Size = new System.Drawing.Size(499, 87);
            this.btnSensations.TabIndex = 5;
            this.btnSensations.Text = "Create Sensation Templates";
            this.btnSensations.UseVisualStyleBackColor = true;
            this.btnSensations.Click += new System.EventHandler(this.btnSensations_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(3, 423);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(499, 87);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "Sensation Recorder";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnSensations);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEditVideo);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnView);
            this.Name = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnEditVideo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSensations;
        private System.Windows.Forms.Button btnRecord;
    }
}
