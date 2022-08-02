using Data;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LEstudiantes : Conexion
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;
        private Librarys librarys;

        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
           librarys = new Librarys();
            image = (PictureBox)objetos[0];
        }
        public void Registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "Este campo es requerido";
                listLabel[0].ForeColor = Color.Red;
                listLabel[0].Focus();
            }
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "Este campo es requerido";
                    listLabel[1].ForeColor = Color.Red;
                    listLabel[1].Focus();
                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "Este campo es requerido";
                        listLabel[2].ForeColor = Color.Red;
                        listLabel[2].Focus();
                    }
                    else
                    {
                        if (listTextBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "Este campo es requerido";
                            listLabel[3].ForeColor = Color.Red;
                            listLabel[3].Focus();
                        }
                        else
                        {
                            if (librarys.textboxEvent.comprobarFormatoEmail(listTextBox[3].Text))
                            {
                                var user = _Estudiante.Where(u => u.email.Equals(listTextBox[3].Text)).ToList();
                                if (user.Count.Equals(0))
                                {
                                  
                                }
                                else
                                {
                                    listLabel[3].Text = "Email ya esta registrado";
                                    listLabel[3].ForeColor = Color.Red;
                                    listLabel[3].Focus();
                                }
                            }
                            else
                            {
                                listLabel[3].Text = "Email no valido";
                                listLabel[3].ForeColor = Color.Red;
                                listLabel[3].Focus();
                            }
                        }
                    }
                }
            }
        }
        private void Save()
        {
            BeginTransactionAsync();
            try
            {
                var imageArray = librarys.uploadimage.ImageToByte(image.Image);
                var db = new Conexion();
                db.Insert(new Estudiante()
                {
                    nombre = listTextBox[0].Text,
                    apellido = listTextBox[1].Text,
                    ced = listTextBox[2].Text,
                    email = listTextBox[3].Text,
                    image = imageArray
                });

                int data = Convert.ToInt16("k");

                CommitTransaction();
            }
            catch (Exception)
            {
                RollbackTransaction();
            }
        }
    }
}
