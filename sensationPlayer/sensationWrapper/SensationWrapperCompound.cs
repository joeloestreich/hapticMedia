using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer.sensationWrapper {
    internal class SensationWrapperCompound : SensationWrapper {

        List<Sensation> sensations;

        public SensationWrapperCompound(List<Sensation> sensations) {
            this.sensations = sensations;
        }

        public override Sensation GetSensation() {
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
