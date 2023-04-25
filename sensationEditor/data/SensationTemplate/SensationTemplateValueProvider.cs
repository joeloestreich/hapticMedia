using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public class SensationTemplateValueProvider<TValue> {

        public enum ProviderType {
            ProviderRange = 0,
            ProviderExact = 1,
            ProviderRandom = 2,
        }

        public ProviderType Type { get;}
        public string Name { get; set; }
        public TValue Min { get; set; }
        public TValue Max { get; set; }
        public TValue Cur { get; set; }

        public SensationTemplateValueProvider(ProviderType type) {
            this.Type = type;
        }

    }
}
