using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public class SensationTemplateValueProvider<TValue> {

        public enum SelectorType {
            Range = 0,
            Exact = 1,
            Random = 2,
        }
        public enum ProviderType {
            Frequency = 0,
            Duration = 1,
            Intensity = 2,
            RampUp = 3,
            RampDown = 4,
            ExitDelay = 5,
        }

        public SelectorType Selector { get;}
        public ProviderType Type { get; }
        public TValue Min { get; set; }
        public TValue Max { get; set; }
        public TValue Default { get; set; }
        public TValue Cur { get; set; }

        public SensationTemplateValueProvider(SelectorType selector, ProviderType type) {
            this.Selector = selector;
            this.Type = type;
        }
        public SensationTemplateValueProvider(SelectorType selector, ProviderType type, TValue min, TValue max, TValue def) {
            this.Selector = selector;
            this.Type = type;
            this.Min = min;
            this.Max = max;
            this.Default = def;
            this.Cur = def;
        }
        public SensationTemplateValueProvider(SelectorType selector, ProviderType type, TValue min, TValue max, TValue def, TValue cur) {
            this.Selector = selector;
            this.Type = type;
            this.Min = min;
            this.Max = max;
            this.Default = def;
            this.Cur = cur;
        }

    }
}
