namespace ClubDeportivo
{
    partial class FormMenuPrincipal
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
            lblUsuario = new Label();
            btnInscribir = new Button();
            btnSalir = new Button();
            btnAsignarAct = new Button();
            btnPagar = new Button();
            btnVencimiento = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(66, 34);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 19);
            lblUsuario.TabIndex = 0;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.Cyan;
            btnInscribir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.ForeColor = Color.Blue;
            btnInscribir.Location = new Point(31, 82);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(258, 91);
            btnInscribir.TabIndex = 1;
            btnInscribir.Text = "Inscribir Cliente";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Cyan;
            btnSalir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Blue;
            btnSalir.Location = new Point(260, 353);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 46);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAsignarAct
            // 
            btnAsignarAct.BackColor = Color.Cyan;
            btnAsignarAct.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignarAct.ForeColor = Color.Blue;
            btnAsignarAct.Location = new Point(339, 82);
            btnAsignarAct.Name = "btnAsignarAct";
            btnAsignarAct.Size = new Size(258, 91);
            btnAsignarAct.TabIndex = 3;
            btnAsignarAct.Text = "Asignar Actividad";
            btnAsignarAct.UseVisualStyleBackColor = false;
            btnAsignarAct.Click += btnAsignarAct_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.Cyan;
            btnPagar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.Blue;
            btnPagar.Location = new Point(31, 223);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(258, 91);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVencimiento
            // 
            btnVencimiento.BackColor = Color.Cyan;
            btnVencimiento.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVencimiento.ForeColor = Color.Blue;
            btnVencimiento.Location = new Point(339, 223);
            btnVencimiento.Name = "btnVencimiento";
            btnVencimiento.Size = new Size(258, 91);
            btnVencimiento.TabIndex = 5;
            btnVencimiento.Text = "Listar socios con vencimiento de cuota";
            btnVencimiento.UseVisualStyleBackColor = false;
            btnVencimiento.Click += btnVencimiento_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(628, 436);
            Controls.Add(btnVencimiento);
            Controls.Add(btnPagar);
            Controls.Add(btnAsignarAct);
            Controls.Add(btnSalir);
            Controls.Add(btnInscribir);
            Controls.Add(lblUsuario);
            ForeColor = Color.Black;
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            Load += FormMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Button btnInscribir;
        private Button btnSalir;
        private Button btnAsignarAct;
        private Button btnPagar;
        private Button btnVencimiento;
    }
}