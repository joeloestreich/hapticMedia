namespace owoMedia.sensationEditor.components.pages {
    partial class VideoEditorPage {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurTime = new System.Windows.Forms.Label();
            this.lblMaxTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.pageHeader1 = new owoMedia.genericComponents.pageHeader.PageHeader();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(0, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 51);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // lblCurTime
            // 
            this.lblCurTime.AutoSize = true;
            this.lblCurTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurTime.Location = new System.Drawing.Point(137, 177);
            this.lblCurTime.Name = "lblCurTime";
            this.lblCurTime.Size = new System.Drawing.Size(66, 25);
            this.lblCurTime.TabIndex = 3;
            this.lblCurTime.Text = "00:00";
            // 
            // lblMaxTime
            // 
            this.lblMaxTime.AutoSize = true;
            this.lblMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTime.Location = new System.Drawing.Point(233, 177);
            this.lblMaxTime.Name = "lblMaxTime";
            this.lblMaxTime.Size = new System.Drawing.Size(66, 25);
            this.lblMaxTime.TabIndex = 4;
            this.lblMaxTime.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "State";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(137, 131);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(62, 25);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "State";
            // 
            // pageHeader1
            // 
            this.pageHeader1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pageHeader1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.Size = new System.Drawing.Size(1280, 100);
            this.pageHeader1.TabIndex = 8;
            // 
            // VideoEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pageHeader1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaxTime);
            this.Controls.Add(this.lblCurTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "VideoEditorPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurTime;
        private System.Windows.Forms.Label lblMaxTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblState;
        private genericComponents.pageHeader.PageHeader pageHeader1;
    }
}
