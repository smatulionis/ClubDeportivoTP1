namespace ClubDeportivo
{
    partial class FormVencimiento
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
            btnVolver = new Button();
            lblVencimiento = new Label();
            dtgvActividad = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(342, 108);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 31);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblVencimiento.Location = new Point(78, 46);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(365, 20);
            lblVencimiento.TabIndex = 18;
            lblVencimiento.Text = "Socios con vencimiento de cuota en el día de la fecha";
            // 
            // dtgvActividad
            // 
            dtgvActividad.AllowUserToDeleteRows = false;
            dtgvActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividad.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dtgvActividad.Location = new Point(27, 182);
            dtgvActividad.Name = "dtgvActividad";
            dtgvActividad.ReadOnly = true;
            dtgvActividad.RowTemplate.Height = 25;
            dtgvActividad.Size = new Size(474, 167);
            dtgvActividad.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "IdSOCIO";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "NOMBRE";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "APELLIDO";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "FECHA ÚLTIMO PAGO";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // FormVencimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 421);
            Controls.Add(btnVolver);
            Controls.Add(lblVencimiento);
            Controls.Add(dtgvActividad);
            Name = "FormVencimiento";
            Text = "FormVencimiento";
            Load += FormVencimiento_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblVencimiento;
        private DataGridView dtgvActividad;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}