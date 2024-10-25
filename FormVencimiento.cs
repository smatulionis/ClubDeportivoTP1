using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
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
    public partial class FormVencimiento : Form
    {
        private FormMenuPrincipal _formMenuPrincipal;

        public FormVencimiento(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            _formMenuPrincipal = formMenuPrincipal;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formMenuPrincipal.Show();
            this.Hide();
        }

        private void FormVencimiento_Load(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select s.IdCliente, Nombre, Apellido, Fecha " +
                        "from socio s " +
                        "inner join cliente c on s.IdCliente = c.IdCliente " +
                        "inner join cuota cuo on c.IdCliente = cuo.IdCliente " +
                        "where cuo.Fecha = DATE_SUB(CURDATE(), INTERVAL 30 DAY) " +
                        "order by Nombre";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvActividad.Rows.Add();
                        dtgvActividad.Rows[renglon].Cells[0].Value = reader.GetInt32(0);
                        dtgvActividad.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvActividad.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtgvActividad.Rows[renglon].Cells[3].Value = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

    }
}
