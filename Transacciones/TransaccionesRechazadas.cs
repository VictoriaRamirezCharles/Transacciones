using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
   public class TransaccionesRechazadas:Transaccion
    {
        List<TransaccionesEliminadas> transaccionessEliminadas { get; set; } = new List<TransaccionesEliminadas>();
        public TransaccionesRechazadas(int NumeroTransaccion, string NombreCliente, double Monto) :base(NumeroTransaccion,NombreCliente,Monto)
        {

        }
    }
}
