using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer.sensationWrapper {
    internal class SensationWrapperCompound : SensationWrapper {

        Sensation[] sensations;

        public SensationWrapperCompound(double timestamp, Sensation[] sensations) : base (timestamp) {
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
