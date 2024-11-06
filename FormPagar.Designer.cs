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
            btnCarnet = new Button();
            cboTarjeta = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdCliente.Location = new Point(22, 24);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(177, 20);
            lblIdCliente.TabIndex = 0;
            lblIdCliente.Text = "Ingrese Id de Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(83, 57);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(49, 23);
            txtIdCliente.TabIndex = 1;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.Cyan;
            btnPagar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.Blue;
            btnPagar.Location = new Point(43, 128);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(101, 31);
            btnPagar.TabIndex = 14;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = Color.Cyan;
            btnComprobante.Enabled = false;
            btnComprobante.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprobante.ForeColor = Color.Blue;
            btnComprobante.Location = new Point(43, 179);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(101, 31);
            btnComprobante.TabIndex = 15;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Cyan;
            btnVolver.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.Blue;
            btnVolver.Location = new Point(325, 226);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 31);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPago.Location = new Point(269, 42);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(105, 15);
            lblFormaPago.TabIndex = 17;
            lblFormaPago.Text = "Forma de Pago";
            // 
            // chkEfectivo
            // 
            chkEfectivo.AutoSize = true;
            chkEfectivo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkEfectivo.Location = new Point(278, 70);
            chkEfectivo.Name = "chkEfectivo";
            chkEfectivo.Size = new Size(76, 19);
            chkEfectivo.TabIndex = 20;
            chkEfectivo.Text = "Efectivo";
            chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = Color.Cyan;
            btnCarnet.Enabled = false;
            btnCarnet.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarnet.ForeColor = Color.Blue;
            btnCarnet.Location = new Point(43, 226);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(101, 31);
            btnCarnet.TabIndex = 22;
            btnCarnet.Text = "Carnet";
            btnCarnet.UseVisualStyleBackColor = false;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // cboTarjeta
            // 
            cboTarjeta.FormattingEnabled = true;
            cboTarjeta.Items.AddRange(new object[] { "1 cuota", "3 cuotas", "6 cuotas" });
            cboTarjeta.Location = new Point(336, 95);
            cboTarjeta.Name = "cboTarjeta";
            cboTarjeta.Size = new Size(90, 23);
            cboTarjeta.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(278, 98);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 24;
            label1.Text = "Tarjeta";
            // 
            // FormPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(450, 290);
            Controls.Add(label1);
            Controls.Add(cboTarjeta);
            Controls.Add(btnCarnet);
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
        private Button btnCarnet;
        private ComboBox cboTarjeta;
        private Label label1;
    }
}