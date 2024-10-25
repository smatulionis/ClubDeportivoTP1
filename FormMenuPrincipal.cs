using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "USUARIO: " + usuario + " " + "(" + rol +
            ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            FormInscripcion frmInscripcion = new FormInscripcion(this);
            frmInscripcion.Show();
            this.Hide();
        }

        private void btnAsignarAct_Click(object sender, EventArgs e)
        {
            FormAsignarAct frmAsignarAct = new FormAsignarAct(this);
            frmAsignarAct.Show();
            this.Hide();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FormPagar frmPagar = new FormPagar(this);
            frmPagar.Show();
            this.Hide();
        }

        private void btnVencimiento_Click(object sender, EventArgs e)
        {
            FormVencimiento frmVencimiento = new FormVencimiento(this);
            frmVencimiento.Show();
            this.Hide();
        }
    }
}
