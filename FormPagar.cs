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
    public partial class FormPagar : Form
    {
        private FormMenuPrincipal _formMenuPrincipal;
        public FormComprobante doc;
        public FormCarnet carnet;

        public FormPagar(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            _formMenuPrincipal = formMenuPrincipal;
            doc = new FormComprobante(_formMenuPrincipal);
            carnet = new FormCarnet(_formMenuPrincipal);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formMenuPrincipal.Show();
            this.Hide();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();
            this.Hide();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == "")
            {
                MessageBox.Show("Debe completar la casilla Id Cliente",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (!chkEfectivo.Checked && !chkTarjeta.Checked)
            {
                MessageBox.Show("Debe seleccionar la forma de pago", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                string respuesta;
                float montoActividad = 0;

                sqlCon = Conexion.getInstancia().CrearConexion();

                query = ("select Monto from actividad a inner join inscripcion i on a.IdActividad = i.IdActividad" +
                    " inner join cliente c on c.IdCliente = i.IdCliente " +
                    "where c.IdCliente = " +
                txtIdCliente.Text);

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;

                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    montoActividad = reader.GetFloat(0);
                }

                E_Cuota cuota = new E_Cuota();
                cuota.IdCliente = Convert.ToInt32(txtIdCliente.Text);

                Clientes tipoCliente = new Clientes();
                respuesta = tipoCliente.identificarTipoCliente(cuota.IdCliente);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1) // Socio
                    {
                        if (chkEfectivo.Checked == true)
                        {
                            cuota.FormaPago = "Efectivo";
                            cuota.Monto = (float)(cuota.Monto * 0.90);
                        }
                        else
                        {
                            cuota.FormaPago = "Tarjeta";
                        }
                    }
                    else if (codigo == 2) // No Socio
                    {
                        if (chkEfectivo.Checked == true)
                        {
                            cuota.FormaPago = "Efectivo";
                            cuota.Monto = (float)(montoActividad * 0.90);
                        }
                        else
                        {
                            cuota.FormaPago = "Tarjeta";
                            cuota.Monto = montoActividad;
                        }
                    }
                    else
                    {
                        MessageBox.Show("CLIENTE INEXISTENTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Datos.Cuota nuevaCuota = new Datos.Cuota();
                    nuevaCuota.pagarCuota(cuota);
                    btnComprobante.Enabled = true;
                    if (codigo == 1)
                    {
                        btnCarnet.Enabled = true;
                    }
                    MessageBox.Show("CUOTA ABONADA CON ÉXITO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Error al procesar el tipo de cliente: " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }

            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();

                query = ("select NombreActividad, concat(Nombre, ' ', Apellido), cuo.Monto, Fecha, FormaPago, (select count(cu.IdCuota) from cuota cu where cu.IdCliente = c.IdCliente) as PagosAnteriores from actividad a inner join inscripcion i on a.IdActividad = i.IdActividad" +
                        " inner join cliente c on c.IdCliente = i.IdCliente " +
                        " inner join cuota cuo on cuo.IdCliente = c.IdCliente " +
                        "where c.IdCliente = " +
                    txtIdCliente.Text);

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;

                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    doc.actComprobante = reader.GetString(0);
                    doc.alumComprobante = reader.GetString(1);
                    carnet.alumComprobante = reader.GetString(1);
                    doc.montoComprobante = reader.GetFloat(2);
                    doc.fechaComprobante = reader.GetDateTime(3);
                    carnet.fechaComprobante = reader.GetDateTime(3);
                    doc.formaComprobante = reader.GetString(4);
                    int pagosAnteriores = reader.GetInt32(5);
                    doc.pagoRepetido = pagosAnteriores > 1;
                }
                else
                {
                    MessageBox.Show("CLIENTE INEXISTENTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            carnet.Show();
            this.Hide();
        }
    }
}
