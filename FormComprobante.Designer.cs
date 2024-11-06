namespace ClubDeportivo
{
    partial class FormComprobante
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
            lblComprobante = new Label();
            lblNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblActividad = new Label();
            lblFecha = new Label();
            lblForma = new Label();
            lblMonto = new Label();
            btnImprimir = new Button();
            SuspendLayout();
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblComprobante.Location = new Point(52, 31);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(267, 24);
            lblComprobante.TabIndex = 0;
            lblComprobante.Text = "COMPROBANTE DE PAGO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(32, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(47, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 129);
            label2.Name = "label2";
            label2.Size = new Size(180, 15);
            label2.TabIndex = 2;
            label2.Text = "Se inscribe en la actividad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 169);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 217);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 4;
            label4.Text = "Forma de Pago:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(229, 217);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 5;
            label5.Text = "Monto: $";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblActividad.Location = new Point(229, 129);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(47, 15);
            lblActividad.TabIndex = 6;
            lblActividad.Text = "label1";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.Location = new Point(183, 169);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 15);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "label1";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblForma.Location = new Point(147, 217);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(47, 15);
            lblForma.TabIndex = 8;
            lblForma.Text = "label1";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonto.Location = new Point(298, 217);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(47, 15);
            lblMonto.TabIndex = 9;
            lblMonto.Text = "label1";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.Cyan;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Blue;
            btnImprimir.Location = new Point(138, 270);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(101, 31);
            btnImprimir.TabIndex = 17;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // FormComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(368, 337);
            Controls.Add(btnImprimir);
            Controls.Add(lblMonto);
            Controls.Add(lblForma);
            Controls.Add(lblFecha);
            Controls.Add(lblActividad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(lblComprobante);
            Name = "FormComprobante";
            Text = "FormComprobante";
            Load += FormComprobante_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComprobante;
        private Label lblNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblActividad;
        private Label lblFecha;
        private Label lblForma;
        private Label lblMonto;
        private Button btnImprimir;
    }
}