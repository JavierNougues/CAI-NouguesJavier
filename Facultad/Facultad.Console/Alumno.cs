using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Console
{
    abstract class Alumno : Persona
    {
        //Variable
        int credencial;


        //Atributos
        private int _codigo;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;


        //Constructor
        public Alumno(int codigo, string nombre, string apellido, DateTime fechaNac) : base(nombre, apellido, fechaNac)
        {
            _codigo = codigo;
            _nombre = nombre;
            _apellido = apellido;
            _fechaNac = fechaNac;
        }


        //Propiedades
        public int Codigo { set { _codigo = value; } get { return _codigo; } }
        public int Credencial { get { return credencial; } }

        //Metodos
        public override void GetCredencial()
        {

        }

        /*
        public string ToString()
        {
            return;
        }
        */
    }
}
