using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
    class ServicioTransaccionEliminada : ITransaccion
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            Console.WriteLine("****Listado de las Transacciones Eliminadas****\n");
            foreach (string  item in Repositorio.Instance.TransaccionesEliminadas)
            {
                Console.WriteLine(item);

            }
        
            Console.ReadKey();
            MenuTransacciones menu = new MenuTransacciones();
            menu.ImprimirMenu();
        }
    }
}
