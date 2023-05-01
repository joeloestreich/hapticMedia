using OWOGame;
using hapticMedia.sensationPlayer.sensationWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public class SensationTemplateDataCapture : SensationTemplateData {

        Dictionary<double, SensationTemplateData> Sensations;
        double CaptureInsertTime;
        public List<double> Cuts = new List<double>(); // to double double object?

        public SensationTemplateDataCapture(string name, Dictionary<double, SensationTemplateData> sensations, double captureInsertTime) : base(TemplateType.TemplateCapture, name) {
            this.Sensations = sensations;
            this.CaptureInsertTime = captureInsertTime;
        }

        public override SensationWrapper GetSensationWrapper() {
            Dictionary<double, SensationWrapper> captures = new Dictionary<double, SensationWrapper>();
            foreach (var entry in Sensations) {
                double timestamp = entry.Key;
                SensationTemplateData template = entry.Value;
                captures.Add(timestamp, Sensations[timestamp].GetSensationWrapper());
            }
            return new SensationWrapperCapture(CaptureInsertTime, captures);
        }

    }
}
