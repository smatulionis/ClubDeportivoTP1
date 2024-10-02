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
                this.Hide();
                Form formMenuPrincipal = new FormMenuPrincipal();
                formMenuPrincipal.ShowDialog();
                this.Close();
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
