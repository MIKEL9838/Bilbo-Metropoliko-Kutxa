using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//IMPORTANTE: https://github.com/programacion-desde-cero/BancoTierraMedia
// https://www.youtube.com/watch?v=lY1Z0Hgo288
//Links con los códigos y el video para realizar este proyecto

namespace BilboMetropolikoKutxa
{
    public partial class Hasiera : Form
    {
        public Hasiera()
        {
            InitializeComponent();
        }

        private void Hasiera_Click(object sender, EventArgs e)
        {

        }

        private void maileguEskaintza_Click(object sender, EventArgs e)
        {

        }     //Kode hau akats bat izan da.

        private void Irten_Click(object sender, EventArgs e)
        {
            this.Close(); //Kode honen bidez botoia sakatuz applikazioa ixten da.
        }

        private void Hasiera_Load(object sender, EventArgs e)
        {
            maileguEskaintza.Enabled = false; //Para que el botón esté deshabilitado antes de insertar cualquier nombre
        }

        private void kontrolBotoiak() //Código de MÉTODO para el botón de mailegu eskaintza para su activación
        {
            if(zureIzena.Text.Trim() != string.Empty && zureIzena.Text.All(Char.IsLetter))
            {
                maileguEskaintza.Enabled = true; //Si lo escrito en el TextBox son todo letras entonces el botón se activa
                errorProvider1.SetError(zureIzena, "");
            }
            else
            {
                if (!(zureIzena.Text.All(Char.IsLetter))) //Si no se escribe nada o se añade otro componente no aceptado no se activará el botón.
                {
                    errorProvider1.SetError(zureIzena, "Izena soilik izan ditzake hizkiak");
                }
                else
                {
                    errorProvider1.SetError(zureIzena, "Zure izena txertatu behar duzu");
                
                maileguEskaintza.Enabled = false;
                zureIzena.Focus();
            }
        }
    }
        private void zureIzena_TextChanged(object sender, EventArgs e)
        {
            kontrolBotoiak(); //Su método es el control que está situado arriba.
        } //Este código sirve para que el botón de Maileguak se habilite, es un MÉTODO.

        private void maileguEskaintza_Click_1(object sender, EventArgs e)
        {
            using (Maileguak maileguEskaintza = new Maileguak(zureIzena.Text))

                maileguEskaintza.ShowDialog();
        }
    }
}
