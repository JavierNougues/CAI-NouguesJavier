using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Console
{
    abstract class Empleado : Persona
    {
        //Variables
        DateTime fechaActual = DateTime.Now;


        //Atributos
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;

        private DateTime _fechaIngreso;
        private int _legajo;
        private static List<Salarios> _salario;


        //Cosntructor
        public Empleado(DateTime fechaIngreso, int legajo, string nombre, string apellido, DateTime fechaNac) : base(nombre, apellido, fechaNac)
        {
            _fechaIngreso = fechaIngreso;
            _legajo = legajo;
            _nombre = nombre;
            _apellido = apellido;
            _fechaNac = fechaNac;

            _salario = new List<Salarios>();
        }


        //Propiedades
        public DateTime FechaIngreso { set { _fechaIngreso = value; } get { return _fechaIngreso; } }
        public DateTime Antiguedad { set { _fechaIngreso = value; } get { return _fechaIngreso; } }
        public DateTime FechaNacimiento { set { _fechaNac = value; } get { return _fechaNac; } }
        public int Legajo { set { _legajo = value; } get { return _legajo; } }
        //public int Salario { set { _salario = value; } get { return _salario; } }
        //Falta ultimo salario.


        //Metodos
        private DateTime CalcularAntiguedad()
        {
            //Revisar conversion
            // fechaActual.Subtract(_fechaIngreso);
            return;
        }

        public void AgregarSalario()
        {

        }

        public virtual void GetCredencial()
        {
            
        }

        public override string GetNombreCompleto()
        {
            return nombreCompleto;
        }

        /*
        public string ToString()
        {
            return;
        }
        */
    }
}
