using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditoria.Auditor
{
    public partial class VerEmpresa : Form
    {
        public VerEmpresa()
        {
            InitializeComponent();
        }

        

        private void botonAuditar_Click(object sender, EventArgs e)
        {
            PanelDeCuestionarios  form = new PanelDeCuestionarios();
            form.Show();
            this.Visible = false;
        }
    }
}
