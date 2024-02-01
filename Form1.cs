using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonas
{
    public partial class Form1 : Form
    {
        //se crea un nuevo espacio para todos los datos
        //Clse objeto
        //Instanciar la clase 
        Persona persona = new Persona();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            persona.Dpi = textBoxDpi.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;
            
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelFecha.Text = persona.FechaNacimiento.ToShortDateString();
            labelDpi.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;   
            labelFecha.Visible = true;
        }

        private void PrimeraMayuscula_Click(object sender, EventArgs e)
        {
            //persona.PrimeraMaryuscula();
            int edad = persona.edad();
            String edadActual = edad.ToString();
            persona.normalizarNombre();
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelFecha.Text = edadActual;

            
        }
    }
}
