using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
    public class Transaccion
    {

        public int NumeroTransaccion { get; set; } = 0;
        public string NombreCliente { get; set; }

        public double Monto { get; set; }

        public Transaccion(int NumeroTransaccion, string NombreCliente, double Monto)
        {
            this.NumeroTransaccion = NumeroTransaccion;
            this.NombreCliente = NombreCliente;
            this.Monto = Monto;
        }

        //    public  void ramdomNumbergenerator()
        //    {


        //            Random r = new Random();
        //        int n  = r.Next(100, 999);


        //      NumeroTransaccion=n+1;

        //        Console.WriteLine(NumeroTransaccion);

        //    }
        //}
    }
}