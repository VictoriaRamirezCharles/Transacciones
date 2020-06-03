using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
    class MenuPrincipal
    {
        enum OpcionMenuPrincipal
        {
            TRANSACCIONES = 1,
            EXIT
        }

        public void ImprimirMenu()
        {
            MenuTransacciones menuTransacciones = new MenuTransacciones();

            try
            {
                Console.Clear();
                Console.WriteLine("***Menu Principal***\n");
                Console.WriteLine(" 1-Transacciones \n 2- Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)OpcionMenuPrincipal.TRANSACCIONES:
                        menuTransacciones.ImprimirMenu();
                        break;
                    case (int)OpcionMenuPrincipal.EXIT:
                        Console.WriteLine("Gracias por utilizar el sistema");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Debe introducir una opcion valida");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Debe introducir una opcion valida");
                Console.ReadKey();
                ImprimirMenu();
            }
        }

    }
}
