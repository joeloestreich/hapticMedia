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

        string UserEntry = "";

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
            string search = txtSearchBar.Text;

            string videoId = IdentifyVideoId(search);
            if (videoId != null) {
                nextPage = new VideoViewerPage(videoId);
            } else {
                nextPage = new VideoSelectorPage(search);
            }
            OwoMedia.Instance.NavigateTo(nextPage);
        }

        public static string IdentifyVideoId(string url) {
            string input = url;

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (input.Contains("?")) {
                foreach (string para in input.Substring(input.IndexOf("?") + 1).Split('&')) {
                    string[] pair = para.Split('=');
                    parameters.Add(pair[0], pair[1]);
                }
            }

            if (input.Contains("youtube") && parameters.ContainsKey("v")) {
                return parameters["v"];
            }

            if (input.Contains("youtube") && input.Contains("/v/") && input.Contains("?")) {
                input = input.Substring(input.IndexOf("/v/") + 3);
                return input.Substring(0, input.IndexOf("?"));
            }

            if (input.Contains("youtube") && input.Contains("/v/")) {
                return input.Substring(input.IndexOf("/v/") + 3);
            }

            string ytDotUrl = "youtu.be/";
            if (input.Contains(ytDotUrl) && input.Contains("?")) {
                input = input.Substring(input.IndexOf(ytDotUrl) + ytDotUrl.Length);
                return input.Substring(0, input.IndexOf("?"));
            }

            if (input.Contains(ytDotUrl)) {
                return input.Substring(input.IndexOf(ytDotUrl) + ytDotUrl.Length);
            }

            return null;
        }
    }
}
