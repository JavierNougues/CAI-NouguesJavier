using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Sucursal
    {
        private string razonSocial { get; set; }
        private string nombre { get; set; }
        private string domicilio { get; set; }
        private string nombreEncargado { get; set; }
        private string telefonoContacto { get; set; }

        public List<string> Empleado { get; set; }


        public Sucursal(string razonSocial, string nombre, string domicilio, string nombreEncargado, string telefonoContacto)
        {
            this.razonSocial = razonSocial;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.nombreEncargado = nombreEncargado;
            this.telefonoContacto = telefonoContacto;

            Personal = new List<string>;
        }

        private bool AgregarEmpleado(Empleado empleado)
        {
            bool existeEmpleado = VerficarSiExisteEmpleado(empleado.dni);
            if (existeEmpleado)
            {
                return false;
                Console.WriteLine("Ya existe empleado con el dni asociado.");
            }
            string auxNombre = Validacion.PedirStrNoVacio("Ingrese su nombre: ");
            string auxApellido = Validacion.PedirStrNoVacio("Ingrese su apellido: ");
            string auxDomicilio = Validacion.PedirStrNoVacio("Ingrese su domicilio: ");
            string auxTelefonoContacto = Validacion.PedirStrNoVacio("Ingrese su telefono de contacto: ");

            Personal = new Personal(auxdni, auxNombre, auxApellido, auxDomicilio, auxTelefonoContacto);
            return true;
        }

        private bool VerficarSiExisteEmpleado(string auxdni)
        {
            foreach Empleado empleado in Empleado
            {
                if empleado.dni == auxdni
                {
                    return true;                    
                }
                return false;
            }
        }

        private void MostrarInfoSucursal()
        {
            Console.WriteLine("Nombre de la sucursal: " + this.nombre);
            Console.WriteLine("Sucursal radicada en: " + this.domicilio);
            Console.WriteLine("Telefono de contacto: " + this.telefonoContacto);
            Console.WriteLine("Encargado a nombre de la sucursal: " + this.nombreEncargado);
        }

 
    }
}
