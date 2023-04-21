using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owoMedia.sensationPlayer.sensationTemplate {
    public abstract class SensationTemplate {

        public void PlaySensation() {
            OWO.Send(GetSensation());
        }

        internal abstract Sensation GetSensation();

    }
}
