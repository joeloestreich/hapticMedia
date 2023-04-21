using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace owoMedia.sensationPlayer.sensationTemplate {
    internal class SensationTemplateValues : SensationTemplate {

        int frequency;
        float durationSeconds;
        int intensityPercentage;
        float RampUpMillies;
        float RampDownMillies;
        float ExitDelaySeconds;
        Muscle[] muscles;

        public SensationTemplateValues(int frequency, float durationSeconds, int intensityPercentage, float RampUpMillies, float RampDownMillies, float ExitDelaySeconds, Muscle[] muscles) {
            this.frequency = frequency;
            this.durationSeconds = durationSeconds;
            this.intensityPercentage = intensityPercentage;
            this.RampUpMillies = RampUpMillies;
            this.RampDownMillies = RampDownMillies;
            this.ExitDelaySeconds = ExitDelaySeconds;
            this.muscles = muscles;
        }

        internal override Sensation GetSensation() {
            MicroSensation micro = SensationsFactory.Create(frequency, durationSeconds, intensityPercentage, RampUpMillies, RampDownMillies, ExitDelaySeconds);
            return micro.WithMuscles(muscles);
        }
    }
}
