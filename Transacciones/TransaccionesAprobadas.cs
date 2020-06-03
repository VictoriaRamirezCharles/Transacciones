using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
 class TransaccionesAprobadas:Transaccion
    {
         public List<string> transaccionesCanceladas { get; set; } = new List<string>();
       public TransaccionesAprobadas(int NumeroTransaccion, string NombreCliente, double Monto) :base(NumeroTransaccion,NombreCliente,Monto)
        {

        }
    }
}
