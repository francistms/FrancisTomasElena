namespace Ejercicio_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Personas unaPersona = new Personas();

            if (unaPersona.correcto())
            {
                MessageBox.Show("Conexión Exitosa");
            }
            else
            {
                MessageBox.Show("Conexión fallida");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            Personas unaPersona = new Personas();
            dgvPrincipal.DataSource = unaPersona.Get();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Refrescar();
        }

        #region AYUDANTE
        private int? ConseguirID()
        {
            try
            {
                return int.Parse(dgvPrincipal.Rows[dgvPrincipal.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? Id = ConseguirID();

            if (Id != null)
            {
                Form2 formEditar = new Form2(Id);
                formEditar.ShowDialog();
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = ConseguirID();

            try
            {
                if (Id != null)
                {
                    Personas personita = new Personas();
                    personita.Eliminar((int)Id);
                    Refrescar();
                }
            }
            catch(Exception  ex)
            {
                MessageBox.Show("Ocurrio un error al eliminar" + ex.Message);
            }
        }
    }
}
