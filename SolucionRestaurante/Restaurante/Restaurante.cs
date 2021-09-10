using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Restaurante
    {
        private string razonSocial { get; set; }
        private string email { get; set; }

        public List<string> Restaurante { get; set; }
        public Restaurante(string razonSocial, string email)
        {
            this.razonSocial = razonSocial;
            this.email = email;

            Restaurante = new List<string>;
        }

        private bool AgregarSucursal(Sucursal sucursal)
        {
            bool existeSucursal = VerificarExisteSucursal(sucursal.razonSocial);
            if (existeSucursal)
            {
                return false;
                Console.WriteLine("Ya existe sucursal con la razon social asociada.");
            }

            string auxNombre = Validacion.PedirStrNoVacio("Ingrese nombre: ");
            string auxDomicilio = Validacion.PedirStrNoVacio("Ingrese domicilio: ");
            string auxNombreEncargado = Validacion.PedirStrNoVacio("Ingrese nombre del encargado: ");
            string auxTelefono = Validacion.PedirStrNoVacio("Ingrese telefono: ");

            Sucursal = new Sucursal(auxRazonSocial, auxNombre, auxDomicilio, auxNombreEncargado, auxTelefono);
            return true;
        }

        private bool VerificarExisteSucursal(auxRazonSocial)
        {
            foreach Sucursal sucursal in Sucursal
            {
                if Sucursal.razonSocial == auxRazonSocial
                {
                    return true;                    
                }
                return false;
            }
        }



    }
}
