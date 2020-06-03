using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
    class ServicioTransacciones:ITransaccion
    {
        
        ServicioTransaccionAprobada servicioTransaccionAprobada;
        ServicioTransaccionRechazada servicioTransaccionRechazada;
        ServicioTransaccionCancelada servicioTransaccionCancelada;
        ServicioTransaccionEliminada servicioTransaccionEliminada;
   

        public ServicioTransacciones()
        {

            servicioTransaccionAprobada = new ServicioTransaccionAprobada();
            servicioTransaccionRechazada = new ServicioTransaccionRechazada();
            servicioTransaccionCancelada = new ServicioTransaccionCancelada();
            servicioTransaccionEliminada = new ServicioTransaccionEliminada();

        }

        public void Add()
        {

            Console.WriteLine("Que tipo de Transaccion desea realizar?\n 1-Transacciones Aprobada\n 2-Transacciones Rechazada\n");
            int transaccionTipo =Convert.ToInt32(Console.ReadLine());

            switch (transaccionTipo)
            {
                case 1:
                    servicioTransaccionAprobada.Add();
                    break;
                case 2:
                    servicioTransaccionRechazada.Add();
                    break;

                default:
                    Console.WriteLine("*******Debe elegir un tipo de Transaccion*******");
                    break;
            }
            Console.ReadKey();
        }


        public void Delete()
        {
            Console.WriteLine("Que tipo de Transaccion desea Eliminar?\n 1-Transacciones Aprobada\n 2-Transacciones Rechazada\n");
            int transaccionTipo = Convert.ToInt32(Console.ReadLine());

            switch (transaccionTipo)
            {
                case 1:
                    servicioTransaccionAprobada.Delete();
                    break;
                case 2:
                    servicioTransaccionRechazada.Delete();
                    break;

                default:
                    Console.WriteLine("*******Debe elegir un tipo de Transaccion*******");
                    break;
            }
            Console.ReadKey();
        }

        public void Edit()
        {
            Console.WriteLine("Que tipo de Transaccione desea Editar?\n 1-Transacciones Aprobada\n 2-Transacciones Rechazada\n");
            int transaccionTipo = Convert.ToInt32(Console.ReadLine());

            switch (transaccionTipo)
            {
                case 1:
                    servicioTransaccionAprobada.Edit();
                    break;
                case 2:
                    servicioTransaccionRechazada.Edit();
                    break;

                default:
                    Console.WriteLine("*******Debe elegir un tipo de Transaccion*******");
                    break;
            }
            Console.ReadKey();
        }

        public void Read()
        {
            Console.WriteLine("Que tipo de Transaccion desea Listar?\n 1- Transacciones Aprobada\n 2- Transacciones Rechazada\n 3- Transacciones Eliminadas \n 4- Transacciones Canceladas");
            int transaccionTipo = Convert.ToInt32(Console.ReadLine());

            switch (transaccionTipo)
            {
                case 1:
                    servicioTransaccionAprobada.Read();
                    break;
                case 2:
                    servicioTransaccionRechazada.Read();
                    break;
                case 3:
                    servicioTransaccionEliminada.Read();
                    break;
                case 4:
                    servicioTransaccionCancelada.Read();
                    break;
                default:
                    Console.WriteLine("*******Debe elegir un tipo de Transaccion*******");
                    break;
            }
            Console.ReadKey();
        }
      
    }
}
