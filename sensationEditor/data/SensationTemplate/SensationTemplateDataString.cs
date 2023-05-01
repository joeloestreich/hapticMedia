using OWOGame;
using hapticMedia.sensationPlayer.sensationWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public class SensationTemplateDataString : SensationTemplateData {

        string Parameter;

        public SensationTemplateDataString(TemplateType type, string name, string parameter) : base(type, name) {
            this.Parameter = parameter;
        }

        public override SensationWrapper GetSensationWrapper() {
            if (Type == TemplateType.TemplateCapture) {
                return new SensationWrapperString(ParseCapture(Parameter));
            } else if (Type == TemplateType.TemplateParse) {
                return new SensationWrapperString(Parameter);
            }
            return null;
        }

        private string ParseCapture(string capture) {
            if (capture.Contains("*SENSATION*")) {
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
