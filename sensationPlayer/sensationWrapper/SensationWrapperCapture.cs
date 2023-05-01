using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer.sensationWrapper {
    internal class SensationWrapperCapture : SensationWrapper {

        double CaptureInsertTime;

        Dictionary<double, SensationWrapper> Sensations;

        public SensationWrapperCapture(double captureInsertTime, Dictionary<double, SensationWrapper> sensations) {
            this.CaptureInsertTime = captureInsertTime;
            this.Sensations = sensations;
        }

        public SensationWrapper GetSensationWrapperForTime(double lastCheck, double curCheck) {

            foreach (var entry in Sensations) {
                double timestamp = entry.Key;
                SensationWrapper wrapper = entry.Value;

                double normal = GetNormalizedTimestamp(timestamp);
                if (normal > lastCheck && normal <= curCheck) {
                    return wrapper;
                } else if (normal < lastCheck) {
                    break;
                }
            }
            return null;
        }

        private double GetNormalizedTimestamp(double subTime) {
            return CaptureInsertTime + subTime;
        }

        public override Sensation GetSensation() {
            throw new Exception("SensationWrapperCapture shouldnt call GetSensation(), but the GetSensation() of its child Sensations");
        }

        public override double GetLengthInSeconds() {
            return CaptureInsertTime + GetNormalizedTimestamp(Sensations.Last().Key) + Sensations.Last().Value.GetLengthInSeconds();
        }

    }
}
