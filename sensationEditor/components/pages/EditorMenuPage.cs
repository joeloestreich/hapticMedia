﻿using hapticMedia.config.data;
using hapticMedia.genericComponents;
using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.home.components;
using hapticMedia.videoViewer.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hapticMedia.sensationEditor.components.pages {
    public partial class EditorMenuPage : UserControlPage {
        public EditorMenuPage() {
            InitializeComponent();
        }

        public override void Init() {
            base.Init();
            genericComponents.pageDefinition.HapticMedia.Instance.Config.DefaultPage = Config.DefaultPageEnum.Editor;
        }

        private void btnNewTrack_Click(object sender, EventArgs e) {
            CreateVideoInfobox info = new CreateVideoInfobox();
            info.Location = new Point(0, 100);
            ChangeInfo(info);
        }

        private void btnEditTrack_Click(object sender, EventArgs e) {
            ChangeInfo(null);
        }

        private void btnTemplates_Click(object sender, EventArgs e) {
            ChangeInfo(null);
        }

        private void btnRelease_Click(object sender, EventArgs e) {
            ChangeInfo(null);
        }

        private void ChangeInfo(InfoAreaBase info) {
            this.pnlInfobox.Controls.Clear();
            if (info != null) {
                this.pnlInfobox.Controls.Add(info);
            }
        }
    }
}
