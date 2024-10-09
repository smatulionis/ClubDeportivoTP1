using ClubDeportivo.Datos;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Data;

namespace ClubDeportivo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            tablaLogin = dato.usuarioLog(txtUsuario.Text, txtContrasenia.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenuPrincipal frmMenuPrincipal = new FormMenuPrincipal();
                frmMenuPrincipal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                frmMenuPrincipal.usuario = Convert.ToString(txtUsuario.Text);
                frmMenuPrincipal.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "CONTRASEÑA")
            {
                txtContrasenia.Text = "";
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "CONTRASEÑA";
                txtContrasenia.UseSystemPasswordChar = false;
            }
        }
    }
}
