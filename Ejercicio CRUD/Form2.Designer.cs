namespace Ejercicio_CRUD
{
    partial class Form2
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblMail = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtMail = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(49, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(49, 102);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(49, 173);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(41, 20);
            lblMail.TabIndex = 2;
            lblMail.Text = "Mail:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(49, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(49, 134);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 4;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(49, 205);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(125, 27);
            txtMail.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(49, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 308);
            Controls.Add(btnGuardar);
            Controls.Add(txtMail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblMail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblMail;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtMail;
        private Button btnGuardar;
    }
}