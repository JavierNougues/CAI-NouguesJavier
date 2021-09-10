using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Personal
    {
        private string dni { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string domicilio { get; set; }
        private string telefonoContacto { get; set; }

       
        public Personal(string nombre, string apellido, string domicilio, string telefonoContacto, string dni)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefonoContacto = telefonoContacto;
        }

        public void MostrarInfoEmpleado()
        {
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Apellido: " + this.apellido);
            Console.WriteLine("Empleado radicado en: " + this.domicilio);
            Console.WriteLine("Telefono de contacto: " + this.telefonoContacto);
        }
    }
}
