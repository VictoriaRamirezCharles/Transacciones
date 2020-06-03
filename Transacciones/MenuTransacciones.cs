using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
    class MenuTransacciones
    {
        
            enum OpcionMenuTransacciones
            {
                ADD = 1,
                EDIT,
                DELETE,
                READ,
                EXIT,
                BACK
            }

            public void ImprimirMenu()
            {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            ServicioTransacciones servicioTransacciones = new ServicioTransacciones();
        
            try
                {
                Console.Clear();
                Console.WriteLine("***Transacciones***\n");
                Console.WriteLine(" 1- Registrar \n 2- Editar \n 3- Eliminar \n 4- Listar \n 5- Salir \n 6- Volver atras");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case (int)OpcionMenuTransacciones.ADD:
                            servicioTransacciones.Add();
                            break;
                        case (int)OpcionMenuTransacciones.EDIT:
                            servicioTransacciones.Edit();
                        break;
                        case (int)OpcionMenuTransacciones.DELETE:
                        servicioTransacciones.Delete();
                        break;
                        case (int)OpcionMenuTransacciones.READ:
                        servicioTransacciones.Read();
                        break;
                        case (int)OpcionMenuTransacciones.EXIT:
                            Console.WriteLine("Gracias por utilizar el sistema");
                            Console.ReadKey();
                            break;
                    case (int)OpcionMenuTransacciones.BACK:
                        menuPrincipal.ImprimirMenu();
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
