using OWOGame;
using hapticMedia.sensationPlayer.sensationWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public class SensationTemplateDataValue : SensationTemplateData {


        public SensationTemplateValueProvider<int> Frequency;
        public SensationTemplateValueProvider<float> DurationSeconds;
        public SensationTemplateValueProvider<int> IntensityPercentage;
        public SensationTemplateValueProvider<float> RampUpMillies;
        public SensationTemplateValueProvider<float> RampDownMillies;
        public SensationTemplateValueProvider<float> ExitDelaySeconds;
        public SensationTemplateMuscleProvider Muscles;

        public SensationTemplateDataValue FollowUpSensation = null;

        public SensationTemplateDataValue(
                    string name,
                    SensationTemplateValueProvider<int> frequency,
                    SensationTemplateValueProvider<float> durationSeconds,
                    SensationTemplateValueProvider<int> intensityPercentage, 
                    SensationTemplateValueProvider<float> rampUpMillies,
                    SensationTemplateValueProvider<float> rampDownMillies, 
                    SensationTemplateValueProvider<float> exitDelaySeconds, 
                    SensationTemplateMuscleProvider muscles) :base(TemplateType.TemplateValue, name) {
            this.Frequency = frequency;
            this.DurationSeconds = durationSeconds;
            this.IntensityPercentage = intensityPercentage;
            this.RampUpMillies = rampUpMillies;
            this.RampDownMillies = rampDownMillies;
            this.ExitDelaySeconds = exitDelaySeconds;
            this.Muscles = muscles;
        }

        public override SensationWrapper GetSensationWrapper() {
            SensationWrapperValues wrapper = new SensationWrapperValues(Frequency.Cur, DurationSeconds.Cur, IntensityPercentage.Cur,
                RampUpMillies.Cur, RampDownMillies.Cur, ExitDelaySeconds.Cur, Muscles.GetMuscles(), Name);

            SensationTemplateDataValue appendSensation = FollowUpSensation;
            SensationWrapperValues lastWrapper = wrapper;
            while (appendSensation != null) {
                SensationWrapperValues append = new SensationWrapperValues(
                    appendSensation.Frequency.Cur,
                    appendSensation.DurationSeconds.Cur,
                    appendSensation.IntensityPercentage.Cur,
                    appendSensation.RampUpMillies.Cur,
                    appendSensation.RampDownMillies.Cur,
                    appendSensation.ExitDelaySeconds.Cur,
                    appendSensation.Muscles.GetMuscles(),
                    appendSensation.Name);
                lastWrapper.FollowUpSensation = append;

                appendSensation = appendSensation.FollowUpSensation;
                lastWrapper = append;
            }

            return wrapper;
        }

        public SensationTemplateDataValue(SensationTemplateDataValue original) : base(TemplateType.TemplateValue, original.Name) {
            this.Frequency = new SensationTemplateValueProvider<int>(original.Frequency);
            this.DurationSeconds = new SensationTemplateValueProvider<float>(original.DurationSeconds);
            this.IntensityPercentage = new SensationTemplateValueProvider<int>(original.IntensityPercentage);
            this.RampUpMillies = new SensationTemplateValueProvider<float>(original.RampUpMillies);
            this.RampDownMillies = new SensationTemplateValueProvider<float>(original.RampDownMillies);
            this.ExitDelaySeconds = new SensationTemplateValueProvider<float>(original.ExitDelaySeconds);
            this.Muscles = new SensationTemplateMuscleProvider(original.Muscles);

            if (original.FollowUpSensation != null) {
                this.FollowUpSensation = new SensationTemplateDataValue(original.FollowUpSensation);
            }
        }

        public bool HasSensation(SensationTemplateDataValue sensation) {
            if (this.Equals(sensation)) {
                return true;
            } else if (FollowUpSensation != null) {
                return FollowUpSensation.HasSensation(sensation);
            } else {
                return false;
            }
        }

    }
}
