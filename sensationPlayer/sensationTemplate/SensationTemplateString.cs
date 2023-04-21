using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owoMedia.sensationPlayer.sensationTemplate {
    internal class SensationTemplateString : SensationTemplate {

        String sensationString;

        public SensationTemplateString(string sensationString) {
            this.sensationString = sensationString;
        }

        internal override Sensation GetSensation() {
            return (Sensation) sensationString;
        }

    }
}
