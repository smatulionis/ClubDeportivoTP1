using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class FormAsignarAct : Form
    {
        private FormMenuPrincipal _formMenuPrincipal;

        public FormAsignarAct(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            _formMenuPrincipal = formMenuPrincipal;
        }

        private void FormAsignarAct_Load(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        public void CargaGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select IdActividad, NombreActividad, Monto from actividad order by NombreActividad";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvActividad.Rows.Add();
                        dtgvActividad.Rows[renglon].Cells[0].Value = reader.GetInt32(0);
                        dtgvActividad.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvActividad.Rows[renglon].Cells[2].Value = reader.GetFloat(2);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                }
                dtgvActividad.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }
        }

        private void dtgvActividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtIdCliente.Text == "")
            {
                MessageBox.Show("Debe completar la casilla Id Cliente",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    int idActividad = Convert.ToInt32(dtgvActividad.Rows[e.RowIndex].Cells[0].Value);
                    string respuesta;

                    E_Inscripcion inscripcion = new E_Inscripcion();
                    inscripcion.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                    inscripcion.IdActividad = idActividad;

                    Datos.Inscripcion asigInscripcion = new Datos.Inscripcion();
                    respuesta = asigInscripcion.nuevaInscripcion(inscripcion);

                    bool esnumero = int.TryParse(respuesta, out int codigo);
                    if (esnumero)
                    {
                        if (codigo == -1)
                        {
                            MessageBox.Show("CLIENTE NO EXISTE", "AVISO DEL SISTEMA",
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
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formMenuPrincipal.Show();
            this.Hide();
        }
    }
}
