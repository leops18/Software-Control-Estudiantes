using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //condicion que solo permite ingresar datos solo de tipo texto
            if (char.IsLetter(e.KeyChar)){ e.Handled = false; }

            // condicion que permite no dar salto de linea cuando se da enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }

            //condicion que permite utilizar tecla borrar
            else if(char.IsControl(e.KeyChar)){ e.Handled = false; }

            //condicion que permite utilizar tecla espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            else { e.Handled = true; }
        }

        public void numberKeyPress(KeyPressEventArgs e)
        {
            //condicion que permite ingresar datos de tipo numeral
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }

            // condicion que permite no dar salto de linea cuando se da enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }

            //condicion que no permite ingresar datos de tipo texto
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }

            //condicion que permite utilizar tecla borrar
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }

            //condicion que permite utilizar tecla espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            else { e.Handled = true; }
        }
   public bool comprobarFormatoEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    
    }
}
