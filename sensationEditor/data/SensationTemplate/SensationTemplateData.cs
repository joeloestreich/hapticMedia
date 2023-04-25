using OWOGame;
using hapticMedia.sensationPlayer.sensationWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public class SensationTemplateData {

        public enum TemplateType {
            TemplateValue = 0,
            TemplateCapture = 1,
            TemplateParse = 2,
            TemplateCompound = 3
        }

        TemplateType Type;
        string Name;

        SensationTemplateValueProvider<int> Frequency;
        SensationTemplateValueProvider<float> DurationSeconds;
        SensationTemplateValueProvider<int> IntensityPercentage;
        SensationTemplateValueProvider<float> RampUpMillies;
        SensationTemplateValueProvider<float> RampDownMillies;
        SensationTemplateValueProvider<float> ExitDelaySeconds;
        SensationTemplateMuscleProvider Muscles;

        string Parameter;

        SensationTemplateData[] Sensations;

        public SensationTemplateData(
                    TemplateType type,
                    string name,
                    SensationTemplateData[] sensations) {
            this.Type = type;
            this.Name = name;
            this.Sensations = sensations;
        }

        public SensationTemplateData(
                    TemplateType type,
                    string name,
                    string parameter) {
            this.Type = type;
            this.Name = name;
            this.Parameter = parameter;
        }

        public SensationTemplateData(
                    TemplateType type, 
                    string name, 
                    SensationTemplateValueProvider<int> frequency,
                    SensationTemplateValueProvider<float> durationSeconds,
                    SensationTemplateValueProvider<int> intensityPercentage, 
                    SensationTemplateValueProvider<float> rampUpMillies,
                    SensationTemplateValueProvider<float> rampDownMillies, 
                    SensationTemplateValueProvider<float> exitDelaySeconds, 
                    SensationTemplateMuscleProvider muscles) {
            this.Type = type;
            this.Name = name;
            this.Frequency = frequency;
            this.DurationSeconds = durationSeconds;
            this.IntensityPercentage = intensityPercentage;
            this.RampUpMillies = rampUpMillies;
            this.RampDownMillies = rampDownMillies;
            this.ExitDelaySeconds = exitDelaySeconds;
            this.Muscles = muscles;
        }

        public SensationWrapper GetSensationWrapper() {
            SensationWrapper wrapper = null;

            if (Type == TemplateType.TemplateValue) {
                wrapper = new SensationWrapperValues(
                    Frequency.Cur, DurationSeconds.Cur, IntensityPercentage.Cur, RampUpMillies.Cur, RampDownMillies.Cur,ExitDelaySeconds.Cur, Muscles.GetMuscles(), Name);
            } else if (Type == TemplateType.TemplateCapture) {
                wrapper = new SensationWrapperString(ParseCapture(Parameter));
            } else if (Type == TemplateType.TemplateParse) {
                wrapper = new SensationWrapperString(Parameter);
            } else if (Type == TemplateType.TemplateCompound) {
                // TODO
            }

            return wrapper;
        }

        private string ParseCapture(string capture) {
            if (capture.Contains("*Sensation*")) {
                return ParseSensationAsterisks(capture);
            } else if (capture.Contains("newOWO")) {
                return ParseNewOwo(capture);
            } else {
                Console.WriteLine("Couldnt Parse: " + capture);
                return null;
            }
        }

        private string ParseSensationAsterisks(string capture) {
            return capture.Substring(capture.LastIndexOf('*') + 1);
        }

        private string ParseNewOwo(string capture) {
            capture = capture.Replace("/eof", "");
            capture = capture.Substring(capture.LastIndexOf('/') + 1);

            StringBuilder parse = new StringBuilder();
            bool first = true;
            
            foreach (string sensation in capture.Split('&')) {
                if (!first) {
                    parse.Append("&");
                }

                string[] part = capture.Split('|');
                string values = part[0];
                string muscles = part[1];

                values += "," + Name;
                parse.Append(values);
                if (muscles != null) {
                    parse.Append("|");
                    parse.Append(muscles);
                }

                first = false;
            }
            return parse.ToString();
        }

    }
}
