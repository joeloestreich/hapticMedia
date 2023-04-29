using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer.sensationWrapper {
    internal class SensationWrapperCapture : SensationWrapper {

        List<SensationWrapper> Sensations;

        public SensationWrapperCapture(double timestamp, List<SensationWrapper> sensations) : base (timestamp) {
            this.Sensations = sensations;
        }

        public SensationWrapper GetSensationWrapperForTime(double lastCheck, double curCheck) {
            foreach (SensationWrapper sensation in Sensations) {
                double normal = GetNormalizedTimestamp(sensation);
                if (normal > lastCheck && normal <= curCheck) {
                    return sensation;
                } else if (normal < lastCheck) {
                    break;
                }
            }
            return null;
        }

        private double GetNormalizedTimestamp(SensationWrapper wrapper) {
            return Timestamp + wrapper.Timestamp;
        }

        public override Sensation GetSensation() {
            throw new Exception("SensationWrapperCapture shouldnt call GetSensation(), but the GetSensation() of its child Sensations");
        }

        public override double GetLength() {
            return Timestamp + GetNormalizedTimestamp(Sensations.Last()) + Sensations.Last().GetLength();
        }

    }
}
