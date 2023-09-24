using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public class SensationTemplateMuscleProvider {

        private List<Muscle> muscles = new List<Muscle>();

        public SensationTemplateMuscleProvider() {
            Muscle m = Muscle.Pectoral_R;
            m.WithIntensity(100);
            muscles.Add(m);
        }

        public SensationTemplateMuscleProvider(SensationTemplateMuscleProvider original) {

        }

        public Muscle[] GetMuscles() {
            return muscles.ToArray();
        }

        public void AddMuscle(Muscle m) {
            RemoveMuscle(m);
            muscles.Add(m);
        }
        public void RemoveMuscle(Muscle m) {
            foreach (Muscle existing in muscles) {
                if (existing.id.Equals(m.id)) {
                    muscles.Remove(existing);
                    return;
                }
            }
        }

    }
}
