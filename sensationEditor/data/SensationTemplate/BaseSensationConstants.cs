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

        public static SensationTemplateData Ball() {
            return new SensationTemplateDataValue("Ball", 0.0,
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 1, 50, 1),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 90),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2000, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2000, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 20, 0),
                new SensationTemplateMuscleProvider()
            );
        }

        public static SensationTemplateData Dagger() {
            SensationTemplateDataValue daggerStab = new SensationTemplateDataValue("DaggerStab", 0.0,
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 60),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 1, 50, 1),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2000, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2000, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 20, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue daggerLinger = new SensationTemplateDataValue("DaggerLinger", 0.0,
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 1, 50, 20),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2000, 300),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2000, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 20, 0),
                new SensationTemplateMuscleProvider()
            );
            return new SensationTemplateDataCompound("Dagger", 0.0, daggerStab, daggerLinger);
        }

        public static SensationTemplateData Hug() {
            SensationTemplateDataValue embrace = new SensationTemplateDataValue("HugEmbrace", 0.0,
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 1, 50, 30),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2000, 1500),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2000, 500),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 20, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue pat = new SensationTemplateDataValue("HugPat", 0.0,
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 80),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 1, 50, 2),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2000, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2000, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 20, 0),
                new SensationTemplateMuscleProvider()
            );
            return new SensationTemplateDataCompound("Hug", 0.0, embrace, pat, pat);
        }

        public static SensationTemplateData ShotWithExit() {
            SensationTemplateDataValue entry = new SensationTemplateDataValue("ShotEntry", 0.0,
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 30),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 1, 50, 1),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2000, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2000, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 20, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue exit = new SensationTemplateDataValue("ShotExit", 0.0,
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 20),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 1, 50, 1),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2000, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2000, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 20, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue linger = new SensationTemplateDataValue("ShotLinger", 0.0,
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 50),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 1, 50, 5),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 80),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2000, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2000, 300),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 20, 0),
                new SensationTemplateMuscleProvider()
            );
            return new SensationTemplateDataCompound("Shot with exit", 0.0, entry, exit, linger);
        }
    }
}
