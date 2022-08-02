using Logica;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {

        private LEstudiantes estudiante;
        private Librarys librarys;

        public Form1()
        {
           InitializeComponent();
           librarys = new Librarys();

            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellido);
            listTextBox.Add(textBoxCedula);
            listTextBox.Add(textBoxEmail);

            var listLabel = new List<Label>();
            listLabel.Add(labelReNombre);
            listLabel.Add(labelReApellido);
            listLabel.Add(labelReCedula);
            listLabel.Add(labelReEmail);

            Object[] objetos = {pictureBoxImage};

            estudiante = new LEstudiantes(listTextBox , listLabel, objetos);
        }      
      

        private void pict(object sender, EventArgs e)
        {// pictureBox
            librarys.uploadimage.CargarImagen(pictureBoxImage);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {// textchanged apellidos
            if (textBoxApellido.Text != (""))
            {
                labelReApellido.Text = "";
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        { // keypress apellidos
            librarys.textboxEvent.textKeyPress(e);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {// keypress nombre
            librarys.textboxEvent.textKeyPress(e);
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {// textchanged nombre
            if (textBoxNombre.Text != (""))
            {
                labelReNombre.Text = "";
            }
        }

        private void textBoxCedula_KeyPress(object sender, KeyPressEventArgs e)
        {// keypress cedula
            librarys.textboxEvent.numberKeyPress(e);
        }

        private void textBoxCedula_TextChanged(object sender, EventArgs e)
        {// textchanged cedula
            if (textBoxCedula.Text != (""))
            {
                labelReCedula.Text = "";
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {// keypress email

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {// textchanged email
            if (textBoxEmail.Text != (""))
            {
                labelReEmail.Text = "";
            }
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            estudiante.Registrar();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

     
    }
}
