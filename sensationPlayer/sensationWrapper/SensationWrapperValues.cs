﻿using OWOGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hapticMedia.sensationPlayer.sensationWrapper {
    internal class SensationWrapperValues : SensationWrapper {

        int frequency;
        float durationSeconds;
        int intensityPercentage;
        float RampUpMillies;
        float RampDownMillies;
        float ExitDelaySeconds;

        Muscle[] muscles;
        string Name;

        public SensationWrapperValues FollowUpSensation = null;

        public SensationWrapperValues(int frequency, float durationSeconds, int intensityPercentage, 
                float RampUpMillies, float RampDownMillies, float ExitDelaySeconds, 
                Muscle[] muscles, string name) {
            this.frequency = frequency;
            this.durationSeconds = durationSeconds;
            this.intensityPercentage = intensityPercentage;
            this.RampUpMillies = RampUpMillies;
            this.RampDownMillies = RampDownMillies;
            this.ExitDelaySeconds = ExitDelaySeconds;
            this.muscles = muscles;
            this.Name = name;
        }

        public override Sensation GetSensation() {
            MicroSensation micro = SensationsFactory.Create(frequency, durationSeconds, intensityPercentage, RampUpMillies, RampDownMillies, ExitDelaySeconds);
            micro = micro.WithName(Name);
            Sensation sensation = micro.WithMuscles(muscles);

            SensationWrapperValues appendSensation = FollowUpSensation;
            while (appendSensation != null) {
                MicroSensation append = SensationsFactory.Create(
                    appendSensation.frequency,
                    appendSensation.durationSeconds,
                    appendSensation.intensityPercentage,
                    appendSensation.RampUpMillies, 
                    appendSensation.RampDownMillies, 
                    appendSensation.ExitDelaySeconds);
                append = append.WithName(appendSensation.Name);
                Sensation followUp = append.WithMuscles(appendSensation.muscles);

                sensation = sensation.Append(followUp);
                appendSensation = appendSensation.FollowUpSensation;
            }

            return sensation;
        }
    }
}
