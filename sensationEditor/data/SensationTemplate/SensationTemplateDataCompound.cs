﻿using OWOGame;
using hapticMedia.sensationPlayer.sensationWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hapticMedia.sensationEditor.data.SensationTemplate {
    public class SensationTemplateDataCompound : SensationTemplateData {

        SensationTemplateData[] Sensations;

        public SensationTemplateDataCompound(string name, params SensationTemplateData[] sensations) : base(TemplateType.TemplateCompound, name) {
            this.Sensations = sensations;
        }

        public override SensationWrapper GetSensationWrapper() {
            Sensation[] sensArray = new Sensation[Sensations.Length];
            for (int i = 0; i < Sensations.Length; i++) {
                sensArray[i] = Sensations[i].GetSensationWrapper().GetSensation();
            }
            return new SensationWrapperCompound(sensArray);
        }

    }
}
