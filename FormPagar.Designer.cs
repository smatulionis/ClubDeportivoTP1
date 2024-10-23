namespace ClubDeportivo
{
    partial class FormPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIdCliente = new Label();
            txtIdCliente = new TextBox();
            btnPagar = new Button();
            btnComprobante = new Button();
            btnVolver = new Button();
            lblFormaPago = new Label();
            chkEfectivo = new CheckBox();
            chkTarjeta = new CheckBox();
            btnCarnet = new Button();
            SuspendLayout();
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdCliente.Location = new Point(90, 57);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(145, 20);
            lblIdCliente.TabIndex = 0;
            lblIdCliente.Text = "Ingrese Id de Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(135, 93);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(51, 23);
            txtIdCliente.TabIndex = 1;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(111, 161);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(101, 31);
            btnPagar.TabIndex = 14;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Location = new Point(111, 212);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(101, 31);
            btnComprobante.TabIndex = 15;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(316, 235);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 31);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormaPago.Location = new Point(330, 78);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(87, 15);
            lblFormaPago.TabIndex = 17;
            lblFormaPago.Text = "Forma de Pago";
            // 
            // chkEfectivo
            // 
            chkEfectivo.AutoSize = true;
            chkEfectivo.Location = new Point(346, 106);
            chkEfectivo.Name = "chkEfectivo";
            chkEfectivo.Size = new Size(68, 19);
            chkEfectivo.TabIndex = 20;
            chkEfectivo.Text = "Efectivo";
            chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // chkTarjeta
            // 
            chkTarjeta.AutoSize = true;
            chkTarjeta.Location = new Point(346, 131);
            chkTarjeta.Name = "chkTarjeta";
            chkTarjeta.Size = new Size(60, 19);
            chkTarjeta.TabIndex = 21;
            chkTarjeta.Text = "Tarjeta";
            chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnCarnet
            // 
            btnCarnet.Enabled = false;
            btnCarnet.Location = new Point(111, 259);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(101, 31);
            btnCarnet.TabIndex = 22;
            btnCarnet.Text = "Carnet";
            btnCarnet.UseVisualStyleBackColor = true;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // FormPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 312);
            Controls.Add(btnCarnet);
            Controls.Add(chkTarjeta);
            Controls.Add(chkEfectivo);
            Controls.Add(lblFormaPago);
            Controls.Add(btnVolver);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(txtIdCliente);
            Controls.Add(lblIdCliente);
            Name = "FormPagar";
            Text = "FormPagar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdCliente;
        private TextBox txtIdCliente;
        private Button btnPagar;
        private Button btnComprobante;
        private Button btnVolver;
        private Label lblFormaPago;
        private CheckBox chkEfectivo;
        private CheckBox chkTarjeta;
        private Button btnCarnet;
    }
}