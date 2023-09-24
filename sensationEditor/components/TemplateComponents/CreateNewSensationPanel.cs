using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.sensationEditor.data.SensationTemplate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hapticMedia.sensationEditor.components.TemplateComponents {
    public partial class CreateNewSensationPanel : UserControlBase {

        public delegate void TemplateCreated(object sender, SensationTemplateData template);
        public event TemplateCreated TemplateCreatedEvent;

        SensationTemplateData ParentTemplate = null;

        public CreateNewSensationPanel() {
            InitializeComponent();
        }

        public CreateNewSensationPanel(SensationTemplateData template) {
            InitializeComponent();
            this.ParentTemplate = template;
        }

        public List<SensationTemplateData> OnOpenTab() {
            if (ParentTemplate is SensationTemplateDataCompound && ((SensationTemplateDataCompound) ParentTemplate).IsLooping()) {
                return ((SensationTemplateDataCompound)ParentTemplate).GetLoop();
            } 
            return null;
        }

        private void btnCreateBlank_Click(object sender, EventArgs e) {

            SensationTemplateData template = BaseSensationConstants.NewBlank();
            template.Name = txtName.Text;

            TemplateCreatedEvent?.Invoke(this, template);
        }

        private void btnCreateParameter_Click(object sender, EventArgs e) {

        }
    }
}
