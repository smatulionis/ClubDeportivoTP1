using ClubDeportivo.Datos;
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
            lblUsuario.Text = "USUARIO: " + SesionUsuario.Usuario + " " + "(" + SesionUsuario.Rol +
            ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Formulario Registrar Cliente
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            FormInscripcion frmInscripcion = new FormInscripcion();
            frmInscripcion.Show();
            this.Hide();
        }

        // Formulario Asignar actividad a un cliente
        private void btnAsignarAct_Click(object sender, EventArgs e)
        {
            FormAsignarAct frmAsignarAct = new FormAsignarAct();
            frmAsignarAct.Show();
            this.Hide();
        }

        // Formulario Pagar
        private void btnPagar_Click(object sender, EventArgs e)
        {
            FormPagar frmPagar = new FormPagar();
            frmPagar.Show();
            this.Hide();
        }

        // Formulario Listar socios con vencimiento cuota
        private void btnVencimiento_Click(object sender, EventArgs e)
        {
            FormVencimiento frmVencimiento = new FormVencimiento();
            frmVencimiento.Show();
            this.Hide();
        }
    }
}
