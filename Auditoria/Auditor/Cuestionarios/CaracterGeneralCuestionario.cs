﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditoria
{
    public partial class CaracterGeneralCuestionario : Form
    {
        public CaracterGeneralCuestionario()
        {
            InitializeComponent();
        }

        private void CaracterGeneralCuestionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["PanelDeCuestionarios"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }
    }
}
