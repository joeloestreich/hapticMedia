using Google.Apis.YouTube.v3.Data;
using OWOGame;
using owoMedia.genericComponents.pageDefinition;
using owoMedia.videoViewer.components.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owoMedia.sensationRecorder.components.pages {
    public partial class SensationRecorderPage : UserControlPage {
        public SensationRecorderPage() {
            InitializeComponent();
        }

        public override void Init() {
            base.Init();

            

        }

        

        private void button1_Click(object sender, EventArgs e) {
            MicroSensation ball = SensationsFactory.Create(100, 0.1f, 100, 0, 0, 0);
            Sensation softBall = ball.WithMuscles(Muscle.Pectoral_R.WithIntensity(50));

            OWO.Send(softBall);
        }
    }
}
