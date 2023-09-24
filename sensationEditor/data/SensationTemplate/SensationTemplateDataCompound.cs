using OWOGame;
using hapticMedia.sensationPlayer.sensationWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public class SensationTemplateDataCompound : SensationTemplateData {

        public List<SensationTemplateData> Sensations { get; }

        private List<SensationTemplateData> Loop { get; } = new List<SensationTemplateData>();

        public SensationTemplateDataCompound(string name, params SensationTemplateData[] sensations) : base(TemplateType.TemplateCompound, name) {
            this.Sensations = new List<SensationTemplateData>(sensations);
        }

        public void SetLoopingSensations(SensationTemplateData from, SensationTemplateData till) {
            Loop.Clear();
            bool isLooping = false;
            foreach (SensationTemplateData sensation in this.Sensations) {
                if (sensation.Equals(from)) {
                    isLooping = true;
                }
                if (isLooping) {
                    Loop.Add(sensation);
                }
                if (sensation.Equals(till)) {
                    break;
                }
            }
        }

        public void AddSensation(SensationTemplateData template) {
            Sensations.Add(template);
        }

        public bool IsLooping() {
            return Loop.Any();
        }

        public List<SensationTemplateData> GetLoop() {
            List<SensationTemplateData> newTemps = new List<SensationTemplateData>();
            foreach (var newTemp in Loop) {
                if (newTemp is SensationTemplateDataCompound) {
                    newTemps.AddRange(((SensationTemplateDataCompound)newTemp).GetLoop());
                } else if (newTemp is SensationTemplateDataValue) {
                    newTemps.Add(new SensationTemplateDataValue((SensationTemplateDataValue)newTemp));
                } else {
                    continue;
                }
            }
            return newTemps;
        }

        public override SensationWrapper GetSensationWrapper() {
            List<Sensation> sensations = new List<Sensation>();
            for (int i = 0; i < Sensations.Count; i++) {
                sensations.Add(Sensations[i].GetSensationWrapper().GetSensation());
            }
            return new SensationWrapperCompound(sensations);
        }

    }
}
