using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer.sensationWrapper {
    public abstract class SensationWrapper {

        public abstract Sensation GetSensation();
        public virtual double GetLengthInSeconds() {
            return GetSensation().Duration;
        }

    }
}
