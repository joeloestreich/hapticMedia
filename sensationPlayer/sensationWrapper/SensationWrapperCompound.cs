using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owoMedia.sensationPlayer.sensationWrapper {
    internal class SensationWrapperCompound : SensationWrapper {

        Sensation[] sensations;

        public SensationWrapperCompound(Sensation[] sensations) {
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
