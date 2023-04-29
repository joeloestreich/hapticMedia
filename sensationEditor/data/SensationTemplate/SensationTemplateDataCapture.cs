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

        SensationTemplateData[] Sensations;
        public List<double> Cuts = new List<double>(); // to double double object?

        public SensationTemplateDataCapture(string name, double timestamp,
                    SensationTemplateData[] sensations) : base(TemplateType.TemplateCapture, name, timestamp) {
            this.Sensations = sensations;
        }

        public override SensationWrapper GetSensationWrapper() {
            List<SensationWrapper> captures = new List<SensationWrapper>();
            for (int i = 0; i < Sensations.Length; i++) {
                // check for cuts
                captures.Add(Sensations[i].GetSensationWrapper());
            }
            return new SensationWrapperCapture(Timestamp, captures);
        }

    }
}
