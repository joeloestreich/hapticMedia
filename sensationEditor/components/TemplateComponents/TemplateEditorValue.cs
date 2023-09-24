using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.sensationEditor.data.SensationTemplate;
using hapticMedia.sensationEditor.data.SensationTemplate.muscle;
using OWOGame;
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
        private Muscle selectedMuscle;

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

            initMuscleLabels();

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
        private void initMuscleLabels() {
            setMuscleText(MuscleConstants.Pectoral_R, "OFF");
            setMuscleText(MuscleConstants.Pectoral_L, "OFF");
            setMuscleText(MuscleConstants.Abdominal_R, "OFF");
            setMuscleText(MuscleConstants.Abdominal_L, "OFF");
            setMuscleText(MuscleConstants.Arm_R, "OFF");
            setMuscleText(MuscleConstants.Arm_L, "OFF");
            setMuscleText(MuscleConstants.Dorsal_R, "OFF");
            setMuscleText(MuscleConstants.Dorsal_L, "OFF");
            setMuscleText(MuscleConstants.Lumbar_R, "OFF");
            setMuscleText(MuscleConstants.Lumbar_L, "OFF");

            foreach (Muscle existing in Template.Muscles.GetMuscles()) {
                setMuscleText(existing.id, existing.intensity.ToString());
            }
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

        private void lblPecL_Click(object sender, EventArgs e) {
            SelectMuscle(Muscle.Pectoral_L);
        }

        private void lblPecR_Click(object sender, EventArgs e) {
            SelectMuscle(Muscle.Pectoral_R);
        }

        private void lblArmL_Click(object sender, EventArgs e) {
            SelectMuscle(Muscle.Arm_L);
        }

        private void lblArmR_Click(object sender, EventArgs e) {
            SelectMuscle(Muscle.Arm_R);
        }

        private void lblAbdomL_Click(object sender, EventArgs e) {
            SelectMuscle(Muscle.Abdominal_L);
        }

        private void lblAbdomR_Click(object sender, EventArgs e) {
            SelectMuscle(Muscle.Abdominal_R);
        }

        private void lblDorsalL_Click(object sender, EventArgs e) {
            SelectMuscle(Muscle.Dorsal_L);
        }

        private void lblDorsalR_Click(object sender, EventArgs e) {
            SelectMuscle(Muscle.Dorsal_R);
        }

        private void lblLumbarL_Click(object sender, EventArgs e) {
            SelectMuscle(Muscle.Lumbar_L);
        }

        private void lblLumbarR_Click(object sender, EventArgs e) {
            SelectMuscle(Muscle.Lumbar_R);
        }

        private void picMuscles_MouseClick(object sender, MouseEventArgs e) {
            Rectangle Pectoral_L = new Rectangle(60, 45, 40, 25);
            Rectangle Pectoral_R = new Rectangle(103, 45, 40, 25);
            Rectangle Arm_L = new Rectangle(30, 70, 25, 25);
            Rectangle Arm_R = new Rectangle(147, 70, 25, 25);
            Rectangle Abdominal_L = new Rectangle(75, 110, 25, 45);
            Rectangle Abdominal_R = new Rectangle(105, 110, 25, 45);
            Rectangle Dorsal_L = new Rectangle(258, 75, 25, 43);
            Rectangle Dorsal_R = new Rectangle(290, 75, 25, 43);
            Rectangle Lumbar_L = new Rectangle(258, 130, 25, 25);
            Rectangle Lumbar_R = new Rectangle(290, 130, 25, 25);

            if (Pectoral_L.Contains(e.Location)) {
                SelectMuscle(Muscle.Pectoral_L);
            } else if (Pectoral_R.Contains(e.Location)) {
                SelectMuscle(Muscle.Pectoral_R);
            } else if (Arm_L.Contains(e.Location)) {
                SelectMuscle(Muscle.Arm_L);
            } else if (Arm_R.Contains(e.Location)) {
                SelectMuscle(Muscle.Arm_R);
            } else if (Abdominal_L.Contains(e.Location)) {
                SelectMuscle(Muscle.Abdominal_L);
            } else if (Abdominal_R.Contains(e.Location)) {
                SelectMuscle(Muscle.Abdominal_R);
            } else if (Dorsal_L.Contains(e.Location)) {
                SelectMuscle(Muscle.Dorsal_L);
            } else if (Dorsal_R.Contains(e.Location)) {
                SelectMuscle(Muscle.Dorsal_R);
            } else if (Lumbar_L.Contains(e.Location)) {
                SelectMuscle(Muscle.Lumbar_L);
            } else if (Lumbar_R.Contains(e.Location)) {
                SelectMuscle(Muscle.Lumbar_R);
            }
        }

        private void picMuscles_MouseDoubleClick(object sender, MouseEventArgs e) {
            Rectangle Pectoral_L = new Rectangle(60, 45, 40, 25);
            Rectangle Pectoral_R = new Rectangle(103, 45, 40, 25);
            Rectangle Arm_L = new Rectangle(30, 70, 25, 25);
            Rectangle Arm_R = new Rectangle(147, 70, 25, 25);
            Rectangle Abdominal_L = new Rectangle(75, 110, 25, 45);
            Rectangle Abdominal_R = new Rectangle(105, 110, 25, 45);
            Rectangle Dorsal_L = new Rectangle(258, 75, 25, 43);
            Rectangle Dorsal_R = new Rectangle(290, 75, 25, 43);
            Rectangle Lumbar_L = new Rectangle(258, 130, 25, 25);
            Rectangle Lumbar_R = new Rectangle(290, 130, 25, 25);

            if (Pectoral_L.Contains(e.Location)
                || Pectoral_R.Contains(e.Location)
                || Arm_L.Contains(e.Location)
                || Arm_R.Contains(e.Location)
                || Abdominal_L.Contains(e.Location)
                || Abdominal_R.Contains(e.Location)
                || Dorsal_L.Contains(e.Location)
                || Dorsal_R.Contains(e.Location)
                || Lumbar_L.Contains(e.Location)
                || Lumbar_R.Contains(e.Location)) {
                cbEnableMuscle.Checked = !cbEnableMuscle.Checked;
            }
        }

        private void SelectMuscle(Muscle muscle) {
            selectedMuscle = muscle;

            cbEnableMuscle.Visible = true;
            lblMuscleMin.Visible = true;
            lblMuscleSlider.Visible = true;
            lblMusclePercent.Visible = true;
            lblMusleMax.Visible = true;
            tbMuscleIntensity.Visible = true;

            switch(muscle.id) {
                case MuscleConstants.Pectoral_R:
                    lblMuscleName.Text = "Pectoral - Right";
                    break;
                case MuscleConstants.Pectoral_L:
                    lblMuscleName.Text = "Pectoral - Left";
                    break;
                case MuscleConstants.Abdominal_R:
                    lblMuscleName.Text = "Abdominal - Right";
                    break;
                case MuscleConstants.Abdominal_L:
                    lblMuscleName.Text = "Abdominal - Left";
                    break;
                case MuscleConstants.Arm_R:
                    lblMuscleName.Text = "Arm - Right";
                    break;
                case MuscleConstants.Arm_L:
                    lblMuscleName.Text = "Arm - Left";
                    break;
                case MuscleConstants.Dorsal_R:
                    lblMuscleName.Text = "Dorsal - Right";
                    break;
                case MuscleConstants.Dorsal_L:
                    lblMuscleName.Text = "Dorsal - Left";
                    break;
                case MuscleConstants.Lumbar_R:
                    lblMuscleName.Text = "Lumbar - Right";
                    break;
                case MuscleConstants.Lumbar_L:
                    lblMuscleName.Text = "Lumbar - Left";
                    break;
                default:
                    lblMuscleName.Text = "Unknown";
                    break;
            }

            foreach (Muscle existing in Template.Muscles.GetMuscles()) {
                if (existing.id.Equals(muscle.id)) {
                    selectedMuscle = existing;
                    cbEnableMuscle.Checked = true;
                    tbMuscleIntensity.Value = existing.intensity;
                    lblMusclePercent.Text = tbMuscleIntensity.Value.ToString();
                    return;
                }
            }

            // Muscle not activ yet
            cbEnableMuscle.Checked = false;
            tbMuscleIntensity.Enabled = false;
            tbMuscleIntensity.Value = 100;
            lblMusclePercent.Text = tbMuscleIntensity.Value.ToString();
        }

        private void cbEnableMuscle_CheckedChanged(object sender, EventArgs e) {
            if (((CheckBox) sender).Checked) {
                Template.Muscles.AddMuscle(selectedMuscle);
                setMuscleText(selectedMuscle.id, selectedMuscle.intensity.ToString());
            } else {
                Template.Muscles.RemoveMuscle(selectedMuscle);
                setMuscleText(selectedMuscle.id, "OFF");
            }
            tbMuscleIntensity.Enabled = ((CheckBox)sender).Checked;
            TemplateChangedEvent?.Invoke(this, Template);
        }

        private void tbMuscleIntensity_Scroll(object sender, EventArgs e) {
            selectedMuscle = selectedMuscle.WithIntensity(tbMuscleIntensity.Value);
            lblMusclePercent.Text = tbMuscleIntensity.Value.ToString();
            Template.Muscles.AddMuscle(selectedMuscle);
            setMuscleText(selectedMuscle.id, lblMusclePercent.Text);
            TemplateChangedEvent?.Invoke(this, Template);
        }

        private void setMuscleText(int muscleId, string text) {
            Label lbl;
            switch (muscleId) {
                case MuscleConstants.Pectoral_R:
                    lbl = lblPecR;
                    break;
                case MuscleConstants.Pectoral_L:
                    lbl = lblPecL;
                    break;
                case MuscleConstants.Abdominal_R:
                    lbl = lblAbdomR;
                    break;
                case MuscleConstants.Abdominal_L:
                    lbl = lblAbdomL;
                    break;
                case MuscleConstants.Arm_R:
                    lbl = lblArmR;
                    break;
                case MuscleConstants.Arm_L:
                    lbl = lblArmL;
                    break;
                case MuscleConstants.Dorsal_R:
                    lbl = lblDorsalR;
                    break;
                case MuscleConstants.Dorsal_L:
                    lbl = lblDorsalL;
                    break;
                case MuscleConstants.Lumbar_R:
                    lbl = lblLumbarR;
                    break;
                case MuscleConstants.Lumbar_L:
                    lbl = lblLumbarL;
                    break;
                default:
                    return;
            }
            lbl.Text = text;
        }
    }
}
