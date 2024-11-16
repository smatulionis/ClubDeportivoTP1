using ClubDeportivo.Datos;
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
        FormMenuPrincipal principal = new FormMenuPrincipal();
        public FormInscripcion()
        {
            InitializeComponent();
            cboTipo.SelectedIndex = 0;
            cboCliente.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Hide();
        }

        // Registrar cliente
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
            txtDocumento.Text == "" || cboTipo.Text == "" || cboCliente.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (!chkApto.Checked)
            {
                MessageBox.Show("Debe tener el Apto Físico para inscribirse.", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                string tipoCliente = cboCliente.SelectedItem.ToString();

                if (tipoCliente == "Socio")
                {
                    E_Socio socio = new E_Socio(txtNombre.Text, txtApellido.Text, cboTipo.Text, Convert.ToInt32(txtDocumento.Text), chkApto.Checked);

                    Socios socios = new Socios();
                    respuesta = socios.altaCliente(socio, true);
                }
                else
                {
                    E_NoSocio noSocio = new E_NoSocio(txtNombre.Text, txtApellido.Text, cboTipo.Text, Convert.ToInt32(txtDocumento.Text), chkApto.Checked);

                    NoSocios noSocios = new NoSocios();
                    respuesta = noSocios.altaCliente(noSocio, false);
                }

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == -1)
                    {
                        MessageBox.Show("CLIENTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Almacenado con éxito con el Id Nro " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                        principal.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            cboTipo.SelectedIndex = 0;
            cboCliente.SelectedIndex = 0;
            chkApto.Checked = false;
            txtNombre.Focus();
        }
    }
}
