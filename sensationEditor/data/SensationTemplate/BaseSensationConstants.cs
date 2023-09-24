using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    internal class BaseSensationConstants {
        private BaseSensationConstants() {
            // Constants
        }

        public static SensationTemplateDataValue NewBlank() {
            return new SensationTemplateDataValue("New",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 1),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.1f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 0, 100, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
        }

        public static SensationTemplateDataValue Ball() {
            return new SensationTemplateDataValue("Ball",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.1f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 0, 100, 90),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
        }

        public static SensationTemplateDataValue Dagger() {
            SensationTemplateDataValue daggerStab = new SensationTemplateDataValue("Stab",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 60),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.1f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 0, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue daggerTwist = new SensationTemplateDataValue("Twist",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 2),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 0, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0.300f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0.100f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            return daggerStab.FollowUpSensation = daggerTwist;
        }

        public static SensationTemplateDataValue Hug() {
            SensationTemplateDataValue embrace = new SensationTemplateDataValue("Embrace",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 3),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 0, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 1.500f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0.500f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue pat = new SensationTemplateDataValue("Pat",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 80),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.2f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 0, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0.100f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );

            embrace.FollowUpSensation = pat;
            pat.FollowUpSensation = new SensationTemplateDataValue(pat);

            return embrace;
        }

        public static SensationTemplateDataValue ShotWithExit() {
            SensationTemplateDataValue entry = new SensationTemplateDataValue("Entry",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 30),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.1f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 0, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue exit = new SensationTemplateDataValue("Exit",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 20),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.1f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 0, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue bleed = new SensationTemplateDataValue("bleed",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 50),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.5f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 0, 100, 80),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0.300f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );

            entry.FollowUpSensation = exit;
            exit.FollowUpSensation = bleed;

            return entry;
        }
    }
}
