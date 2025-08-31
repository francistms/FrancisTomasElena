using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_CRUD
{
    public partial class Form2 : Form
    {
        private int? Id;
        public Form2(int? id= null)
        {
            InitializeComponent();
            this.Id = id;

            if (id != null)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            Personas personas = new Personas();
            Persona personita = personas.ObtenerID(Id);

            txtNombre.Text = personita.Nombre;
            txtApellido.Text = personita.Apellido;
            txtMail.Text = personita.Mail;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Personas persona = new Personas();

            try
            {
                if(Id == null)
                {
                    persona.Agregar(txtNombre.Text, txtApellido.Text, txtMail.Text);
                    MessageBox.Show("Persona agregada con éxito");
                }
                else
                {
                    persona.Editar(txtNombre.Text, txtApellido.Text, txtMail.Text, (int)Id);
                    MessageBox.Show("Persona editada con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar" + ex.Message);
            }
        }
    }
}
