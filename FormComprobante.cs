﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FormComprobante : Form
    {
        private FormMenuPrincipal _formMenuPrincipal;
        public FormComprobante(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            _formMenuPrincipal = formMenuPrincipal;
        }

        public string? actComprobante;
        public string? alumComprobante;
        public float montoComprobante;
        public DateTime fechaComprobante;
        public string? formaComprobante;
        public bool pagoRepetido;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true;

            MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _formMenuPrincipal.Show();
            this.Close();
        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void FormComprobante_Load(object sender, EventArgs e)
        {
            lblNombre.Text = alumComprobante;
            lblActividad.Text = actComprobante;
            lblFecha.Text = fechaComprobante.ToString("dd/MM/yyyy");
            lblMonto.Text = Convert.ToString(montoComprobante);
            lblForma.Text = formaComprobante;

            if (pagoRepetido)
            {
                label2.Visible = false;
                lblActividad.Visible = false;
            }
        }
    }
}
