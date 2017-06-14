using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auditoria.Administrador;
using Auditoria.Auditor;

namespace Auditoria
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                buttonIngresar.PerformClick();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text.Equals("Administrador"))
            {
               InicioAdministrador form = new InicioAdministrador();
                form.Show();
                this.Visible = false;
            }
           
            if (textUsuario.Text.Equals("Auditor"))
                {
                   InicioAuditor form = new InicioAuditor();
                    form.Show();
                    this.Visible = false;
                }              
        }
    }
}
