using owoMedia.genericComponents.pageDefinition;
using owoMedia.videoViewer.components.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owoMedia.videoViewer.components {
    public partial class VideoSearch : UserControlOwoBase {

        public VideoSearch() {
            InitializeComponent();
        }


        public override void Init() {
            base.Init();
            txtSearchBar.Text = "Search Youtube";
            txtSearchBar.ForeColor = Color.Gray;
        }
        private void VideoSearch_Load(object sender, EventArgs e) {
        }

        static string UserEntry = "";

        private void txtSearchBar_Enter(object sender, EventArgs e) {
            if (UserEntry.Trim().Equals("")) {
                txtSearchBar.Text = "";
                txtSearchBar.ForeColor = Color.Black;
            }
        }

        private void txtSearchBar_Leave(object sender, EventArgs e) {
            UserEntry = txtSearchBar.Text.Trim();
            if (UserEntry.Equals("")) {
                txtSearchBar.Text = "Search Youtube";
                txtSearchBar.ForeColor = Color.Gray;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UserControlPage nextPage;

            string videoId = IdentifyVideoId(UserEntry);
            if (videoId != null) {
                nextPage = new VideoViewerPage(videoId);
            } else {
                nextPage = new VideoSelectorPage(UserEntry);
            }
            OwoMedia.Instance.NavigateTo(nextPage);
        }

        public static string IdentifyVideoId(string url) {

            if (url == null) {
                return null;
            }

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (url.Contains("?")) {
                foreach (string para in url.Substring(url.IndexOf("?") + 1).Split('&')) {
                    string[] pair = para.Split('=');
                    parameters.Add(pair[0], pair[1]);
                }
            }

            if (url.Contains("youtube") && parameters.ContainsKey("v")) {
                return parameters["v"];
            }

            if (url.Contains("youtube") && url.Contains("/v/") && url.Contains("?")) {
                url = url.Substring(url.IndexOf("/v/") + 3);
                return url.Substring(0, url.IndexOf("?"));
            }

            if (url.Contains("youtube") && url.Contains("/v/")) {
                return url.Substring(url.IndexOf("/v/") + 3);
            }

            string ytDotUrl = "youtu.be/";
            if (url.Contains(ytDotUrl) && url.Contains("?")) {
                url = url.Substring(url.IndexOf(ytDotUrl) + ytDotUrl.Length);
                return url.Substring(0, url.IndexOf("?"));
            }

            if (url.Contains(ytDotUrl)) {
                return url.Substring(url.IndexOf(ytDotUrl) + ytDotUrl.Length);
            }

            return null;
        }
    }
}
