using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owoMedia.sensationPlayer.sensationTemplate {
    internal class SensationTemplateCompound : SensationTemplate {

        Sensation[] sensations;

        public SensationTemplateCompound(Sensation[] sensations) {
            this.sensations = sensations;
        }

        internal override Sensation GetSensation() {
            Sensation compound = null;
            foreach (var sensation in sensations) {
                if (compound == null) {
                    compound = sensation;
                } else {
                    compound = compound.Append(sensation);
                }
            }
            return compound;
        }

    }
}
