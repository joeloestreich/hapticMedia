using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer.sensationWrapper {
    internal class SensationWrapperString : SensationWrapper {

        String sensationString;

        public SensationWrapperString(string sensationString) {
            this.sensationString = sensationString;
        }

        internal override Sensation GetSensation() {
            return (Sensation) sensationString;
        }

    }
}
