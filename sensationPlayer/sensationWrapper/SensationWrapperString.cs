using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer.sensationWrapper {
    internal class SensationWrapperString : SensationWrapper {

        String sensationString;

        public SensationWrapperString(double timestamp, string sensationString) : base(timestamp) {
            this.sensationString = sensationString;
        }

        public override Sensation GetSensation() {
            return (Sensation) sensationString;
        }

    }
}
