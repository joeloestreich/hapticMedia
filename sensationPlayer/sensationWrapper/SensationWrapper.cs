using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer.sensationWrapper {
    public abstract class SensationWrapper {

        public double Timestamp;

        public SensationWrapper(double timestamp) {
            this.Timestamp = timestamp;
        }

        public abstract Sensation GetSensation();
        public virtual double GetLength() {
            return GetSensation().Duration;
        }

    }
}
