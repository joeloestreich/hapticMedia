using OWOGame;
using hapticMedia.sensationPlayer.sensationWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public abstract class SensationTemplateData {

        public enum TemplateType {
            TemplateValue = 0,
            TemplateCapture = 1,
            TemplateParse = 2,
            TemplateCompound = 3
        }

        public TemplateType Type;
        public string Name;

        public SensationTemplateData(TemplateType type, string name) {
            this.Type = type;
            this.Name = name;
        }

        public abstract SensationWrapper GetSensationWrapper();

    }
}
