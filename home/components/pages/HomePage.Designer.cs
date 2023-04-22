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
            this.btnViewer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLiveShare = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlInfobox = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewer
            // 
            this.btnViewer.Location = new System.Drawing.Point(3, 83);
            this.btnViewer.Name = "btnViewer";
            this.btnViewer.Size = new System.Drawing.Size(499, 87);
            this.btnViewer.TabIndex = 0;
            this.btnViewer.Text = "Browse Videos";
            this.btnViewer.UseVisualStyleBackColor = true;
            this.btnViewer.Click += new System.EventHandler(this.btnViewer_Click);
            this.btnViewer.MouseEnter += new System.EventHandler(this.btnViewer_MouseEnter);
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
            this.btnOptions.MouseEnter += new System.EventHandler(this.btnOptions_MouseEnter);
            // 
            // btnEditor
            // 
            this.btnEditor.Location = new System.Drawing.Point(3, 421);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(499, 87);
            this.btnEditor.TabIndex = 3;
            this.btnEditor.Text = "Manage Videos";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            this.btnEditor.MouseEnter += new System.EventHandler(this.btnEditor_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(1188, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 66);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnLiveShare
            // 
            this.btnLiveShare.Location = new System.Drawing.Point(3, 176);
            this.btnLiveShare.Name = "btnLiveShare";
            this.btnLiveShare.Size = new System.Drawing.Size(499, 87);
            this.btnLiveShare.TabIndex = 5;
            this.btnLiveShare.Text = "Sensation Live Share";
            this.btnLiveShare.UseVisualStyleBackColor = true;
            this.btnLiveShare.Click += new System.EventHandler(this.btnLiveShare_Click);
            this.btnLiveShare.MouseEnter += new System.EventHandler(this.btnLiveShare_MouseEnter);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(3, 328);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(499, 87);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "Sensation Recorder";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            this.btnRecord.MouseEnter += new System.EventHandler(this.btnRecord_MouseEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Welcome test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlInfobox
            // 
            this.pnlInfobox.Location = new System.Drawing.Point(677, 328);
            this.pnlInfobox.Name = "pnlInfobox";
            this.pnlInfobox.Size = new System.Drawing.Size(550, 250);
            this.pnlInfobox.TabIndex = 8;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInfobox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnLiveShare);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEditor);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnViewer);
            this.Name = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLiveShare;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlInfobox;
    }
}
