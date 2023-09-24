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
    public partial class TemplateEditorValue : UserControlBase {

        SensationTemplateDataValue Template;

        public delegate void TemplateChanged(object sender, SensationTemplateData template);
        public event TemplateChanged TemplateChangedEvent;

        public TemplateEditorValue() {
            InitializeComponent();
        }

        public TemplateEditorValue(SensationTemplateDataValue template) {
            InitializeComponent();
            

            this.Template = template;

            tbFreq.Value = template.Frequency.Cur;
            tbInt.Value = template.IntensityPercentage.Cur;
            tbDur.Value = FloatToSlider(template.DurationSeconds.Cur);
            tbFIn.Value = FloatToSlider(template.RampUpMillies.Cur);
            tbFOut.Value = FloatToSlider(template.RampDownMillies.Cur);
            tbExit.Value = FloatToSlider(template.ExitDelaySeconds.Cur);

            tbFreq.Minimum = template.Frequency.Min;
            tbInt.Minimum = template.IntensityPercentage.Min;
            tbDur.Minimum = FloatToSlider(template.DurationSeconds.Min);
            tbFIn.Minimum = FloatToSlider(template.RampUpMillies.Min);
            tbFOut.Minimum = FloatToSlider(template.RampDownMillies.Min);
            tbExit.Minimum = FloatToSlider(template.ExitDelaySeconds.Min);

            tbFreq.Maximum = template.Frequency.Max;
            tbInt.Maximum = template.IntensityPercentage.Max;
            tbDur.Maximum = FloatToSlider(template.DurationSeconds.Max);
            tbFIn.Maximum = FloatToSlider(template.RampUpMillies.Max);
            tbFOut.Maximum = FloatToSlider(template.RampDownMillies.Max);
            tbExit.Maximum = FloatToSlider(template.ExitDelaySeconds.Max);

            UpdateLabels(true);
        }

        private int FloatToSlider(float value) {
            return (int)(value * 10);
        }
        private float SliderToFloat(int value) {
            if (value == 0) {
                return 0;
            }
            return (float)value / 10;
        }

        private void UpdateLabels(bool isInit) {
            lblFreqCur.Text = Template.Frequency.Cur.ToString();
            lblIntCur.Text = Template.IntensityPercentage.Cur.ToString();
            lblDurCur.Text = Template.DurationSeconds.Cur.ToString("0.00");
            lblFInCur.Text = Template.RampUpMillies.Cur.ToString("0.00");
            lblFOutCur.Text = Template.RampDownMillies.Cur.ToString("0.00");
            lblExitCur.Text = Template.ExitDelaySeconds.Cur.ToString("0.00");

            if (!isInit) {
                TemplateChangedEvent?.Invoke(this, Template);
                return;
            }

            lblFreqMin.Text = Template.Frequency.Min.ToString();
            lblIntMin.Text = Template.IntensityPercentage.Min.ToString();
            lblDurMin.Text = Template.DurationSeconds.Min.ToString("0.00");
            lblFInMin.Text = Template.RampUpMillies.Min.ToString("0.00");
            lblFOutMin.Text = Template.RampDownMillies.Min.ToString("0.00");
            lblExitMin.Text = Template.ExitDelaySeconds.Min.ToString("0.00");

            lblFreqMax.Text = Template.Frequency.Max.ToString();
            lblIntMax.Text = Template.IntensityPercentage.Max.ToString();
            lblDurMax.Text = Template.DurationSeconds.Max.ToString("0.00");
            lblFInMax.Text = Template.RampUpMillies.Max.ToString("0.00");
            lblFOutMax.Text = Template.RampDownMillies.Max.ToString("0.00");
            lblExitMax.Text = Template.ExitDelaySeconds.Max.ToString("0.00");
        }


        private void tbFreq_Scroll(object sender, EventArgs e) {
            Template.Frequency.Cur = tbFreq.Value;
            UpdateLabels(false);
        }

        private void tbInt_Scroll(object sender, EventArgs e) {
            Template.IntensityPercentage.Cur = tbInt.Value;
            UpdateLabels(false);
        }

        private void tbDur_Scroll(object sender, EventArgs e) {
            Template.DurationSeconds.Cur = SliderToFloat(tbDur.Value);
            UpdateLabels(false);
        }

        private void tbFIn_Scroll(object sender, EventArgs e) {
            Template.RampUpMillies.Cur = SliderToFloat(tbFIn.Value);
            UpdateLabels(false);
        }

        private void tbFOut_Scroll(object sender, EventArgs e) {
            Template.RampDownMillies.Cur = SliderToFloat(tbFOut.Value);
            UpdateLabels(false);
        }

        private void tbExit_Scroll(object sender, EventArgs e) {
            Template.ExitDelaySeconds.Cur = SliderToFloat(tbExit.Value);
            UpdateLabels(false);
        }

    }
}
