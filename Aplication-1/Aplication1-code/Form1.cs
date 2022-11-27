using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//En este proyecto:
//1.Creamos el proyecto.
//2. Analizamos los archivos que nos creo el Proyecto.
//3. Cambiamos el nombre del Form1, con la propiedad Name.
//4. Cambiamos el titulo del Formulario, con la propiedad Text.
//5. Cambiamos el color de fondo del Formulario, con la propiedad BackColor.
//6. Cambiamos la posición del Formulario, con la propiedad StartPosition.
//7. Cambiamos la vista inicial del Formulario (Normal, Minimizado o Maximizado), con
//la propiedad WindowState.
//8. Manejar el evento Load del Formulario. 
    //a.DobleClick sobre el Formulario carga el método del evento Load por defecto.
    //b.Mostramos un Mensaje con MessageBox.Show.
//9.Manejar el evento FormClosed del Formulario.
    //a. Mostramos un Mensaje con MessageBox.Show.
//10.No mostrar el botón de minimizar .del Formulario.
//11.No mostrar el botón de maximizar del Formulario.
//12.Modificar el valor de la propiedad Opacity --no causa ningun efecto por el momento.


namespace Aplication1_code
{
    public partial class frmFormApp : Form
    {
        public frmFormApp()
        {
            InitializeComponent();
        }

        //8
        private void frmFormApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to C#");
        }

        private void frmFormApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Goodbye!");
        }

        //Al dispararse el evento Click, se cambie el color del Formulario. 
        //- Cancelamos las líneas de código anteriores y colocamos el código para cambiar el color de fondo del TextBox
        //(Propiedad BackColor) si el TextBox se encuentra vació
        private void btnControl1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención");
            //this.BackColor = Color.Coral;
            if (txtApellido.Text == "") //tambien podria escribirse  (txtApellido.Text.Lenght == 0)
            {
                txtApellido.BackColor = Color.Red;
            }else
                txtApellido.BackColor = SystemColors.Control;

        }

        //-.Manejar el evento Click .del Formulario. Determinar que botón del Mouse se pulso. 
        //Repasar el eventArgs y la herencia y relacion a la hora de generarse un evento.
        //parameter EventArgs = evento especificado que se va a agregar +event.
        private void frmFormApp_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e; //instancio la clase y accedo a sus metodos y props. Esta escrito entre llaves con
            //la "e" al final, lo que indica que es REDUNDANTE. Revisar ese concepto. 
            
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención"); //el segundo parametro es el nombre del cartel emergente
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        //
        //-Manejar el evento MouseMove del Control Label. Lo elijo desde el form1.cs[Diseño]
        //-Cambiamos el color de la propiedad BackColor
        //-Cambiar el estilo del cursor al dispararse el eventos MouseMove 
        
        private void lblInfo1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.BackColor = Color.Orchid; //cambia el color de la ventana: this referencia a la ventana en la que estamos trabajando.
            lblInfo1.BackColor = Color.Orchid;
            lblInfo1.Cursor = Cursors.Hand; //Cursors obtiene una coleccion de todos los cursores disponibles
        }
        //
        //-Al dispararse el evento MouseLeave, se restablezca el color de fondo de la etiqueta (label).
        //-Cambiar el estilo del cursor al dispararse el evento MouseLeave.
        private void lblInfo1_MouseLeave(object sender, EventArgs e)
        {
            lblInfo1.BackColor = SystemColors.Control; //devuelve el color de la apariencia del boton 3d, por eso el gris
            lblInfo1.Cursor = Cursors.Arrow; //muy sutil 
        }

        //Manejar el evento KeyPress, para ingresar solo Números 
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e) //se puede obtener el eventArg asociado solo utilizando la e
        {
            //los valores que se utilizan estan relacionados con los caracteres ASCII; ESTUDIARLO
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8) //acepta tambien ';' y ':'
                e.Handled = true;
        }

        //Manejar el evento Leave del nuevo Control TextBox.Para mostrar cuantos
        //caracteres se ingresaron una vez que el control pierde el foco.
        private void txtNuevo_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("El textBox tiene " + txtNuevo.Text.Length + " caracteres"); //con el tab
        }
    }
}


//con los eventos, podemos modificar PROPIEDADES del objeto propiamente dicho, pero tambien podemos ejecutar LOGICA