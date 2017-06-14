using System;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void verCuestionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["IniciarSesion"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }


        private void cerrarAplicacion(FormClosedEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void InicioAuditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }
    }
}
