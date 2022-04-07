using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPU1_A3Eventos
{
    public partial class Form1 : Form
    {
        // Creé dos variales de tipo Int privadas para el evento Paint
        private int x;
        private int y;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Creé el evento Click del botón "Mostrar" para que las imagenes que agregue en un picturebox se mostraran
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            pbLouis1.Visible = true; // A la picturebox le puse la propiedad de visible y le asigné el valor verdadero para que se mostrara al dar click en el botón
            pbLouis2.Visible = true; 
        }
        // Este es el evento click que creé de manera accidental que al dar click en la foto se desaparece
        private void pbLouis1_Click(object sender, EventArgs e)
        {
            pbLouis1.Visible = false; // Esta picturebox le asigné la propiedad visible con un valor falso
        }
        // Este evento también lo cree de manera errone y hace lo mismo que el evento anterior
        private void pbLouis2_Click(object sender, EventArgs e)
        {
            pbLouis2.Visible = false; // Esta picturebox le asigné la propiedad visible con un valor falso
        }
        // El evento Paint en el form1 hace que se pinte o cree un texto al momento de abrir el form
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Cree la forma de dibujar el texto
            Font fuente = new Font("Simsun", 16); // cree un objeto y le di un valor especifico 
            g.DrawString("Hola, él es Louis Tomlinson", fuente, Brushes.White, x, y);// Decidí que mostrar al form, confirmé la fuente y puse el color del texto
        }
        // Cree el metodo para que al momento de pasar el mouse por la picturebox la imagen desaparezca
        private void pbLouis2_MouseMove(object sender, MouseEventArgs e)
        {
            pbLouis2.Visible = false; //a la picturebox le asigné nuevamente la propiedad visible para darle un valor falso
        }
        // Cree el metodo para que al momento de pasar el mouse por la picturebox la imagen desaparezca
        private void pbLouis1_MouseMove(object sender, MouseEventArgs e)
        {
            pbLouis1.Visible = false; //a la picturebox le asigné nuevamente la propiedad visible para darle un valor falso
        }
        // Cree el método MouseHover para que al momento de pasar sobre el botón aparezca un texto que yo escribí 
        private void btnVer_MouseHover(object sender, EventArgs e)
        {
            lblTexto.Text = "Puedes escuchar Walls en cualquier plataforma, gracias"; // aquí a la label le asigné el texto que yo escribí al momento de pasar sobre el botón
        }
        // Cree el método para preguntar el motivo por el cual el usuario desea salir de la ventana
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {   // cree un if para que se le notifique al usuario que saldrá de la página y le muestra dos opciones si y no
            if (MessageBox.Show("Deseas salir de esta ventana", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // esta línea hará que si el usuario desea cancelar la acción de salir
            }
        }
        // este método sirve para mostrar otro texto al momento de que el mouse salga del botón 
        private void btnVer_MouseLeave(object sender, EventArgs e)
        {   
            lblTexto.Text = "Pasa nuevamente sobre el botón 'ver texto' :) "; // aquí escribí el texto que quiero mostrar en la label
        }
    }
}
