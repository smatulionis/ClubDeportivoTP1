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
        private FormComprobante doc;
        public FormCarnet carnet = new FormCarnet();

        public FormPagar()
        {
            InitializeComponent();
            doc = new FormComprobante(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal principal = new FormMenuPrincipal();
            principal.Show();
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

            if (!chkEfectivo.Checked && cboTarjeta.SelectedIndex == -1)
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

                // Consultar monto de la Actividad
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

                string formaPago;
                if (chkEfectivo.Checked)
                {
                    formaPago = "Efectivo";
                }
                else
                {
                    formaPago = cboTarjeta.SelectedItem.ToString();
                }

                E_Cuota cuota = new E_Cuota(Convert.ToInt32(txtIdCliente.Text), formaPago);

                respuesta = Clientes.identificarTipoCliente(cuota.IdCliente);

                bool esnumero = int.TryParse(respuesta, out int codigoCliente);
                if (esnumero)
                {
                    // Modificar monto de cuota según sea Socio o No Socio
                    if (codigoCliente == 1) // Socio
                    {
                        if (chkEfectivo.Checked)
                        {
                            cuota.modificarMonto((float)(cuota.Monto * 0.90));
                        }
                    }
                    else if (codigoCliente == 2) // No Socio
                    {
                        if (chkEfectivo.Checked)
                        {
                            cuota.modificarMonto((float)(montoActividad * 0.90));
                        }
                        else
                        {
                            cuota.modificarMonto(montoActividad);
                        }
                    }
                    else
                    {
                        MessageBox.Show("CLIENTE INEXISTENTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Datos.Cuota nuevaCuota = new Datos.Cuota();
                    respuesta = nuevaCuota.pagarCuota(cuota);

                    bool esnumeroCuota = int.TryParse(respuesta, out int codigoCuota);
                    if (esnumeroCuota)
                    {
                        if (codigoCuota == -1)
                        {
                            MessageBox.Show("CLIENTE NO ESTA INSCRIPTO EN NINGUNA ACTIVIDAD", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            btnComprobante.Enabled = true;
                            if (codigoCliente == 1)
                            {
                                btnCarnet.Enabled = true;
                            }
                            MessageBox.Show("CUOTA ABONADA CON ÉXITO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }                          
                }
                else
                {
                    MessageBox.Show("Error al procesar el pago: " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Consulta para generar datos de Comprobante y Carnet
                query = ("select NombreActividad, concat(Nombre, ' ', Apellido), " +
                         "(select cu.Monto from cuota cu where cu.IdCliente = c.IdCliente order by cu.IdCuota desc limit 1) as MontoUltimaCuota, " +
                         "(select cu.Fecha from cuota cu where cu.IdCliente = c.IdCliente order by cu.IdCuota desc limit 1) as FechaUltimaCuota, " +
                         "(select cu.FormaPago from cuota cu where cu.IdCliente = c.IdCliente order by cu.IdCuota desc limit 1) as FormaPagoUltimaCuota, " +
                         "(select min(cu.Fecha) from cuota cu where cu.IdCliente = c.IdCliente) as FechaPrimeraCuota " +
                         "from actividad a " +
                         "inner join inscripcion i on a.IdActividad = i.IdActividad " +
                         "inner join cliente c on c.IdCliente = i.IdCliente " +
                         "inner join cuota cuo on cuo.IdCliente = c.IdCliente " +
                         "where c.IdCliente = " + txtIdCliente.Text);

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;

                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    carnet.idSocio = txtIdCliente.Text;
                    doc.actComprobante = reader.GetString(0);
                    doc.alumComprobante = reader.GetString(1);
                    carnet.alumComprobante = reader.GetString(1);
                    doc.montoComprobante = reader.GetFloat(2);   
                    doc.fechaComprobante = reader.GetDateTime(3);
                    doc.formaComprobante = reader.GetString(4);    
                    carnet.fechaComprobante = reader.GetDateTime(5); 
                    doc.pagoRepetido = carnet.fechaComprobante.Date < DateTime.Now.Date;
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
