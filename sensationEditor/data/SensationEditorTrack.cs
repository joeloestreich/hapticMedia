
using owoMedia.sensationEditor.data.SensationTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owoMedia.sensationEditor.data {
    public class SensationEditorTrack {

        public string VideoId;
        public string Title;
        public Dictionary<double, SensationTemplateData> Track;

        public SensationEditorTrack() {

        }

        public SensationEditorTrack(string videoId) {
            this.VideoId = videoId;
            this.Title = "SOME TITLE";
            this.Track = new Dictionary<double, SensationTemplateData>();
        }


    }
}
