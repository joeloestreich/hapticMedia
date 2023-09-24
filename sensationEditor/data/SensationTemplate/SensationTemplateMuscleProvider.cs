using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public class SensationTemplateMuscleProvider {

        public SensationTemplateMuscleProvider() {

        }

        public SensationTemplateMuscleProvider(SensationTemplateMuscleProvider original) {

        }

        public Muscle[] GetMuscles() {

            return new Muscle[] { Muscle.Abdominal_R };
        }

    }
}
