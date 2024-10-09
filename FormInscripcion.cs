using ClubDeportivo.Entidades;
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
    public partial class FormInscripcion : Form
    {
        private FormMenuPrincipal _formMenuPrincipal;

        public FormInscripcion(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            _formMenuPrincipal = formMenuPrincipal;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formMenuPrincipal.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
            txtDocumento.Text == "" || cboTipo.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Socio socio = new E_Socio();
                socio.Nombre = txtNombre.Text;
                socio.Apellido = txtApellido.Text;
                socio.Documento = Convert.ToInt32(txtDocumento.Text);
                socio.TipoDoc = cboTipo.Text;
                Datos.Socios postulantes = new Datos.Socios();
                respuesta = postulantes.Nuevo_socio(socio);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("SOCIO YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Almacenado con éxito con el Id Nro " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            cboTipo.Text = "";
            txtNombre.Focus();
        }
    }
}
