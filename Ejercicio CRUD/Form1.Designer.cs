namespace Ejercicio_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPrincipal = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnRefresh = new Button();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            SuspendLayout();
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Location = new Point(36, 83);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.RowHeadersWidth = 51;
            dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrincipal.Size = new Size(605, 327);
            dgvPrincipal.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(36, 30);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(200, 30);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(364, 30);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(677, 83);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(111, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Conectar BD";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(528, 30);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(111, 29);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefrescar);
            Controls.Add(btnRefresh);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPrincipal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPrincipal;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnRefresh;
        private Button btnRefrescar;
    }
}
