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
            btnInscribir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscribir.Location = new Point(87, 101);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(258, 91);
            btnInscribir.TabIndex = 1;
            btnInscribir.Text = "Inscribir Cliente";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(583, 51);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(84, 35);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnInscribir);
            Controls.Add(lblUsuario);
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
    }
}