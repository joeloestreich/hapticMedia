using OWOGame;
using hapticMedia.sensationPlayer.sensationWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer {
    internal class SensationPlayerEditor : SensationPlayer {

        public bool MuteSensation = false;

        public SensationPlayerEditor() : base() {

        }

        public SensationPlayerEditor(Dictionary<double, SensationWrapper> sequence) : base(sequence) {

        }

        internal override void PlaySensation(Sensation sensation) {
            if (!MuteSensation) {
                PlaySensation(sensation);
            }
        }

    }
}
