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

        public delegate void TemplateCreated(object sender, SensationTemplateDataValue template);
        public event TemplateCreated TemplateCreatedEvent;

        SensationTemplateData ParentTemplate = null;

        public CreateNewSensationPanel() {
            InitializeComponent();
        }

        public CreateNewSensationPanel(SensationTemplateData template) {
            InitializeComponent();
            this.ParentTemplate = template;
        }

        private void btnCreateBlank_Click(object sender, EventArgs e) {

            SensationTemplateDataValue template = BaseSensationConstants.NewBlank();
            template.Name = txtName.Text;

            TemplateCreatedEvent?.Invoke(this, template);
        }

        private void btnCreateParameter_Click(object sender, EventArgs e) {

        }
    }
}
