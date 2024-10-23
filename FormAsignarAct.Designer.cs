namespace ClubDeportivo
{
    partial class FormAsignarAct
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
            dtgvActividad = new DataGridView();
            lblActividades = new Label();
            label1 = new Label();
            txtIdCliente = new TextBox();
            btnVolver = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).BeginInit();
            SuspendLayout();
            // 
            // dtgvActividad
            // 
            dtgvActividad.AllowUserToDeleteRows = false;
            dtgvActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividad.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dtgvActividad.Location = new Point(54, 124);
            dtgvActividad.Name = "dtgvActividad";
            dtgvActividad.ReadOnly = true;
            dtgvActividad.RowTemplate.Height = 25;
            dtgvActividad.Size = new Size(455, 184);
            dtgvActividad.TabIndex = 0;
            dtgvActividad.CellClick += dtgvActividad_CellClick;
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblActividades.Location = new Point(199, 25);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(124, 20);
            lblActividades.TabIndex = 1;
            lblActividades.Text = "Asignar actividad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 84);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Id Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(117, 81);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(101, 23);
            txtIdCliente.TabIndex = 3;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(408, 73);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 31);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "IdACTIVIDAD";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "ACTIVIDAD";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "MONTO";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "CUPO";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // FormAsignarAct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 370);
            Controls.Add(btnVolver);
            Controls.Add(txtIdCliente);
            Controls.Add(label1);
            Controls.Add(lblActividades);
            Controls.Add(dtgvActividad);
            Name = "FormAsignarAct";
            Text = "FormAsignarAct_Load";
            Load += FormAsignarAct_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvActividad;
        private Label lblActividades;
        private Label label1;
        private TextBox txtIdCliente;
        private Button btnVolver;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}