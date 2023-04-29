﻿using hapticMedia.genericComponents.pageDefinition;
using hapticMedia.home.components.pages;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hapticMedia.genericComponents.pageHeader {
    public partial class PageHeader : UserControlBase {
        public PageHeader() {
            InitializeComponent();
        }

        private void picLogo_Click(object sender, EventArgs e) {
            pageDefinition.HapticMedia.Instance.NavigateTo(new HomePage());
        }

    }
}
