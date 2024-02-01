using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonas
{
    internal class Persona
    {
        //Campo
        //privados para cumplir con el encapsulado
        String dpi;
        String nombre;
        String apellido;
        DateTime fechaNacimiento;
        String nombreNormal;
        String apellidoNormal;

        //Encapsulado
        public String Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        //set es asignar
        //metodos: acciones que se arealizan

        //constructor de la clase, codigo que se ejecuta al crearse un objeto de esta clase
        //por ejemplo iniciaizar variables
        public Persona()
        {
            dpi = "";
            nombre = "";
            apellido = "";
            //inicializar con la fecha de hoy
            fechaNacimiento = DateTime.Now;
        }
        public void PrimeraMaryuscula()
        {
            if (nombre.Length > 0)
            {
                StringBuilder nombreMayuscula = new StringBuilder(nombre);
                nombreMayuscula[0] = char.ToUpper(nombreMayuscula[0]);
                nombre = nombreMayuscula.ToString();
            }
            if (apellido.Length > 0)
            {
                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString();
            }
        }

        public int edad()
        {
            //Calcular edad
            DateTime fechaActual = DateTime.Today;
            if (fechaNacimiento > fechaActual)
            {
                //no se puede ya que se ingreso una fecha mayor que la actual
                return -1;
            }
            else
            {
                int edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }

                return edad;
            }
        }
        public void normalizarNombre()
        {
            if (nombre.Length > 0)
            {
                nombre = nombre.Trim();
                string nombreSinSigno = "";
                foreach(char caracter in nombre)
                {
                    if(char.IsLetter(caracter))
                    {
                        nombreSinSigno += caracter;
                    }
                }
                nombre = nombreSinSigno;
                nombreNormal = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre);
                nombre = nombreNormal.ToString();
                
            }
            if (apellido.Length > 0)
            {
                apellido = apellido.Trim();
                string apellidoSinSigno = "";
                foreach (char caracter in apellido)
                {
                    if (char.IsLetter(caracter))
                    {
                        apellidoSinSigno += caracter;
                    }
                }
                apellido = apellidoSinSigno;
                apellidoNormal = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(apellido);
                apellido = apellidoNormal.ToString();
            }
        }
    }
}
