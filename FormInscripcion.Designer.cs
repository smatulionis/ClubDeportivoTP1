namespace ClubDeportivo
{
    partial class FormInscripcion
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
            lblInscripcion = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipo = new Label();
            lblDocumento = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            cboTipo = new ComboBox();
            lblAst1 = new Label();
            lblAst2 = new Label();
            lblAst3 = new Label();
            lblAst4 = new Label();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblCliente = new Label();
            cboCliente = new ComboBox();
            label1 = new Label();
            chkApto = new CheckBox();
            SuspendLayout();
            // 
            // lblInscripcion
            // 
            lblInscripcion.AutoSize = true;
            lblInscripcion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblInscripcion.Location = new Point(143, 29);
            lblInscripcion.Name = "lblInscripcion";
            lblInscripcion.Size = new Size(139, 24);
            lblInscripcion.TabIndex = 0;
            lblInscripcion.Text = "INSCRIPCION";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(30, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(29, 138);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(59, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(30, 200);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(35, 15);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(202, 200);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(80, 15);
            lblDocumento.TabIndex = 4;
            lblDocumento.Text = "Documento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(125, 136);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(260, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(284, 197);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(107, 23);
            txtDocumento.TabIndex = 7;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Libreta " });
            cboTipo.Location = new Point(82, 198);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(84, 23);
            cboTipo.TabIndex = 8;
            // 
            // lblAst1
            // 
            lblAst1.AutoSize = true;
            lblAst1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAst1.Location = new Point(391, 98);
            lblAst1.Name = "lblAst1";
            lblAst1.Size = new Size(12, 15);
            lblAst1.TabIndex = 9;
            lblAst1.Text = "*";
            // 
            // lblAst2
            // 
            lblAst2.AutoSize = true;
            lblAst2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAst2.Location = new Point(391, 136);
            lblAst2.Name = "lblAst2";
            lblAst2.Size = new Size(12, 15);
            lblAst2.TabIndex = 10;
            lblAst2.Text = "*";
            // 
            // lblAst3
            // 
            lblAst3.AutoSize = true;
            lblAst3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAst3.Location = new Point(172, 197);
            lblAst3.Name = "lblAst3";
            lblAst3.Size = new Size(12, 15);
            lblAst3.TabIndex = 11;
            lblAst3.Text = "*";
            // 
            // lblAst4
            // 
            lblAst4.AutoSize = true;
            lblAst4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAst4.Location = new Point(391, 197);
            lblAst4.Name = "lblAst4";
            lblAst4.Size = new Size(12, 15);
            lblAst4.TabIndex = 12;
            lblAst4.Text = "*";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Cyan;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.Blue;
            btnIngresar.Location = new Point(36, 343);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(101, 31);
            btnIngresar.TabIndex = 13;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Cyan;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.Blue;
            btnLimpiar.Location = new Point(161, 343);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 31);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Cyan;
            btnVolver.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.Blue;
            btnVolver.Location = new Point(284, 343);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 31);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.Location = new Point(30, 237);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(52, 15);
            lblCliente.TabIndex = 16;
            lblCliente.Text = "Cliente";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Items.AddRange(new object[] { "Socio", "No Socio" });
            cboCliente.Location = new Point(82, 235);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(84, 23);
            cboCliente.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(172, 235);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 18;
            label1.Text = "*";
            // 
            // chkApto
            // 
            chkApto.AutoSize = true;
            chkApto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkApto.Location = new Point(36, 285);
            chkApto.Name = "chkApto";
            chkApto.Size = new Size(96, 19);
            chkApto.TabIndex = 19;
            chkApto.Text = "Apto Físico";
            chkApto.UseVisualStyleBackColor = true;
            // 
            // FormInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(430, 408);
            Controls.Add(chkApto);
            Controls.Add(label1);
            Controls.Add(cboCliente);
            Controls.Add(lblCliente);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(lblAst4);
            Controls.Add(lblAst3);
            Controls.Add(lblAst2);
            Controls.Add(lblAst1);
            Controls.Add(cboTipo);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblInscripcion);
            Name = "FormInscripcion";
            Text = "FormInscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInscripcion;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipo;
        private Label lblDocumento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private ComboBox cboTipo;
        private Label lblAst1;
        private Label lblAst2;
        private Label lblAst3;
        private Label lblAst4;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblCliente;
        private ComboBox cboCliente;
        private Label label1;
        private CheckBox chkApto;
    }
}