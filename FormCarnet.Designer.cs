namespace ClubDeportivo
{
    partial class FormCarnet
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
            btnImprimir = new Button();
            lblFecha = new Label();
            label3 = new Label();
            lblNombre = new Label();
            lblComprobante = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(122, 280);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(101, 31);
            btnImprimir.TabIndex = 28;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(219, 179);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 25;
            lblFecha.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 179);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 21;
            label3.Text = "Fecha de Inscripcion:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(122, 131);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "label1";
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblComprobante.Location = new Point(104, 44);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(134, 20);
            lblComprobante.TabIndex = 18;
            lblComprobante.Text = "CARNET DE SOCIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 131);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 29;
            label1.Text = "Socio:";
            // 
            // FormCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 349);
            Controls.Add(label1);
            Controls.Add(btnImprimir);
            Controls.Add(lblFecha);
            Controls.Add(label3);
            Controls.Add(lblNombre);
            Controls.Add(lblComprobante);
            Name = "FormCarnet";
            Text = "FormCarnet";
            Load += FormCarnet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private Label lblFecha;
        private Label label3;
        private Label lblNombre;
        private Label lblComprobante;
        private Label label1;
    }
}