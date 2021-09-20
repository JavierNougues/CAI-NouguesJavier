using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Console
{
    abstract class Persona
    {
		//Variables
		DateTime edad;
		DateTime fechaActual = DateTime.Now;
		string nombreCompleto;

		//Atributos
		private string _nombre;
		private string _apellido;
		private DateTime _fechaNac;

		//Constructor
        public Persona(string nombre, string apellido, DateTime fechaNac)
        {
            _nombre = nombre;
            _apellido = apellido;
            _fechaNac = fechaNac;
        }

        //Propiedades
        public string Nombre { set { _nombre = value; } get { return _nombre; } }
		public string Apellido { set { _apellido = value; } get { return _apellido; } }
		public DateTime Edad { set { _fechaNac = value; } get { return edad; } }

		//Metodos
		public virtual void GetCredencial()
		{

		}

		public virtual string GetNombreCompleto()
		{
			return nombreCompleto;
		}

		private DateTime GetEdad()
        {
			//Revisar conversion
			//edad = fechaActual.Subtract(_fechaNac);
			return edad;
		}
	}
}
