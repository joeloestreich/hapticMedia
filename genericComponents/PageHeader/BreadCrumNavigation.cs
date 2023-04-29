using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.home.components.pages;
using hapticMedia.sensationEditor.components.pages;
using hapticMedia.sensationRecorder.components.pages;
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

namespace hapticMedia.genericComponents.PageHeader {
    public partial class BreadCrumNavigation : UserControlBase {

        private static Dictionary<Type, List<Type>> ChildPages = new Dictionary<Type, List<Type>>() {
            { typeof(VideoSelectorPage), new List<Type>(){ typeof(VideoViewerPage) } },
            { typeof(EditorMenuPage), new List<Type>(){ typeof(VideoEditorPage) } }
        };

        private static Dictionary<Type, string> PageNames = new Dictionary<Type, string>() {
            { typeof(HomePage), "Home" },
            { typeof(VideoSelectorPage), "Browse Videos" },
            { typeof(VideoViewerPage), "VideoInfo" },
            { typeof(EditorMenuPage), "Editor Menu" },
            { typeof(VideoEditorPage), "Editor" },
            { typeof(SensationRecorderPage), "Sensation Recorder" }
        };


        static List<UserControlPage> Crums = new List<UserControlPage>();
        private Dictionary<string, UserControlPage> NavHelper = new Dictionary<string, UserControlPage>();

        public BreadCrumNavigation() {
            InitializeComponent();
        }

        private void BreadCrumNavigation_Load(object sender, EventArgs e) {
            bool first = true;
            foreach (UserControlPage page in Crums) {
                if (!first) {
                    Label lblArrow = new Label();
                    lblArrow.Text = ">";
                    flowLayoutPanel1.Controls.Add(lblArrow);
                }
                string pageName = "Unknown";
                if (PageNames.ContainsKey(page.GetType())) {
                    pageName = PageNames[page.GetType()];
                }

                Label lblCrum = new Label();
                lblCrum.Text = pageName;
                lblCrum.Click += LblCrum_Click;
                flowLayoutPanel1.Controls.Add(lblCrum);

                NavHelper[pageName] = page;

                first = false;
            }
        }

        private void LblCrum_Click(object sender, EventArgs e) {
            Label crum = (Label) sender;
            pageDefinition.HapticMedia.Instance.NavigateTo(NavHelper[crum.Text]);
        }


        public static void OnNavigation(UserControlPage oldPage, UserControlPage newPage) {
            if (IsNavigateBack(newPage)) {
                while (!Crums[Crums.Count - 1].GetType().Equals(newPage.GetType())) {
                    Crums.RemoveAt(Crums.Count - 1);
                }
            } else if (IsNavigateDeeper(oldPage, newPage)) {
                Crums.Add(newPage);
            } else {
                Crums.Clear();
                if (!(newPage is HomePage)) {
                    Crums.Add(new HomePage());
                }
                Crums.Add(newPage);
            }
        }


        private static bool IsNavigateDeeper(UserControlPage oldPage, UserControlPage newPage) {
            if (oldPage == null) {
                return false;
            }
            return ChildPages.ContainsKey(oldPage.GetType())
                && ChildPages[oldPage.GetType()].Contains(newPage.GetType());
        }

        private static bool IsNavigateBack(UserControlPage newPage) {
            foreach (UserControlPage crum in Crums) {
                if (crum.GetType().Equals(newPage.GetType())) {
                    return true;
                }
            }
            return false;
        }
    }
}
