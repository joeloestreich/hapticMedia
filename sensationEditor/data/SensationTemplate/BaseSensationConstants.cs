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
            return new SensationTemplateDataValue("Ball",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.1f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 90),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
        }

        public static SensationTemplateData Dagger() {
            SensationTemplateDataValue daggerStab = new SensationTemplateDataValue("DaggerStab",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 60),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.1f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue daggerLinger = new SensationTemplateDataValue("DaggerLinger",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 2),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0.300f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0.100f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            return new SensationTemplateDataCompound("Dagger", daggerStab, daggerLinger);
        }

        public static SensationTemplateData Hug() {
            SensationTemplateDataValue embrace = new SensationTemplateDataValue("HugEmbrace",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 3),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 1.500f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0.500f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue pat = new SensationTemplateDataValue("HugPat",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 80),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.2f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0.100f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            return new SensationTemplateDataCompound("Hug", embrace, pat, pat);
        }

        public static SensationTemplateData ShotWithExit() {
            SensationTemplateDataValue entry = new SensationTemplateDataValue("ShotEntry",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 30),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.1f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue exit = new SensationTemplateDataValue("ShotExit",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 20),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.1f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 100),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            SensationTemplateDataValue linger = new SensationTemplateDataValue("ShotLinger",
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Frequency, 1, 100, 50),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.Duration, 0.1f, 5, 0.5f),
                new SensationTemplateValueProvider<int>(
                    SensationTemplateValueProvider<int>.SelectorType.Range, SensationTemplateValueProvider<int>.ProviderType.Intensity, 1, 100, 80),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampUp, 0, 2, 0),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.RampDown, 0, 2, 0.300f),
                new SensationTemplateValueProvider<float>(
                    SensationTemplateValueProvider<float>.SelectorType.Range, SensationTemplateValueProvider<float>.ProviderType.ExitDelay, 0, 2, 0),
                new SensationTemplateMuscleProvider()
            );
            return new SensationTemplateDataCompound("Shot with exit", entry, exit, linger);
        }
    }
}
