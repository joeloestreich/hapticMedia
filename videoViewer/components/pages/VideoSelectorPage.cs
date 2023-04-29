using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.config.data;
using hapticMedia.videoViewer.components.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp.Server;

namespace hapticMedia.videoViewer.components.pages {
    public partial class VideoSelectorPage : UserControlPage {

        string UserSearch = null;

        public VideoSelectorPage(string search) {
            this.UserSearch = search;
            InitializeComponent();
        }

        public VideoSelectorPage() {
            InitializeComponent();
        }

        public override void Init() {
            base.Init();
            genericComponents.pageDefinition.HapticMedia.Instance.Config.DefaultPage = Config.DefaultPageEnum.Viewer;

            List<string> list = new List<string>();
            list.Add("Oe043UhUTm4");
            list.Add("TpqRe_hGCCY");
            list.Add("EmuBnhtgLDA");

            list.Add("Oe043UhUTm4");
            list.Add("TpqRe_hGCCY");
            list.Add("EmuBnhtgLDA");
            list.Add("Oe043UhUTm4");
            list.Add("TpqRe_hGCCY");
            list.Add("EmuBnhtgLDA");
            list.Add("Oe043UhUTm4");
            list.Add("TpqRe_hGCCY");
            list.Add("EmuBnhtgLDA");

            foreach (string videoId in list) {
                VideoSelectorEntry entry = new VideoSelectorEntry(videoId);
                entry.Init();
                this.flowVideoList.Controls.Add(entry);
            }

        }

    }
}
