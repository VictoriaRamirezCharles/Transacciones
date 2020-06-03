using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
    class Repositorio
    {
        public List<string> TransaccionesEliminadas { get; set; } = new List<string>();
        public List<string> TransaccionesCanceladas { get; set; } = new List<string>();
        public List<TransaccionesAprobadas> transaccionesAprobadas { get; set; } = new List<TransaccionesAprobadas>();
        public List<TransaccionesRechazadas> transaccionesRechazadas { get; set; } = new List<TransaccionesRechazadas>();
        public List<int> numeroTransaccionAprobada { get; set; } = new List<int>();
        public List<int> numeroTransaccionRechazada { get; set; } = new List<int>();
        public static Repositorio Instance { get; } = new Repositorio();

        private Repositorio()
        {
        }
    }
}
