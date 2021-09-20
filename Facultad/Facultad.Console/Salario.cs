using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Console
{
    class Salarios 
    {


        //Atributos
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;


        //Propiedades
        private double Bruto { set { _bruto = value; } get { return _bruto; } }
        private string CodigoTransferencia { set { _codigoTransferencia = value; } get { return _codigoTransferencia; } }
        private double Descuentos { set { _descuentos = value; } get { return _descuentos; } }
        private DateTime Fecha { set { _fecha = value; } get { return _fecha; } }


        //Metodos
        public double GetSalarioNeto()
        {
            return;
        }

        private double Salario()
        {

        }
    }
}
