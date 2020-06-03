using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
    class ServicioTransaccionAprobada : ITransaccion
    {
        MenuTransacciones menuTransacciones;
   
        public ServicioTransaccionAprobada()
        {

            menuTransacciones = new MenuTransacciones();

        }

        public void Add()
        {
            Console.WriteLine("Transaccion Aprobada\n");
            try 
            {
                int ntransaccion = Repositorio.Instance.numeroTransaccionAprobada.LastOrDefault();

                bool isValid = IsValid(ntransaccion);
                    if (isValid)
                    {
                    Console.WriteLine("Transaccion #:" + ntransaccion);
                    Repositorio.Instance.numeroTransaccionAprobada.Add(ntransaccion);
                }
                else
                {
                    ntransaccion++;
                    Repositorio.Instance.numeroTransaccionAprobada.Add(ntransaccion);
                    Console.WriteLine("Transaccion #:" + ntransaccion);
                }
                Console.WriteLine("Nombre del cliente: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Monto de la Transaccion ");
                double monto = Convert.ToDouble(Console.ReadLine());

                TransaccionesAprobadas nuevoTransaccion = new TransaccionesAprobadas(ntransaccion, nombre, monto);

                Repositorio.Instance.transaccionesAprobadas.Add(nuevoTransaccion);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Se ha agregado con exito");
                Console.WriteLine("---------------------------------");
                Console.ReadKey();
                menuTransacciones.ImprimirMenu();
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("****Introduzca una opcion Valida****\n");
                Console.ReadKey();
                Add();
            }
        }

        public void Delete()
        {
            try
            {
                Read();

                Console.WriteLine("Seleccione la transaccion que desea eliminar\n");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Repositorio.Instance.TransaccionesCanceladas.Add("Transaccion #"+opcion);
                Repositorio.Instance.transaccionesAprobadas.RemoveAt(opcion - 1);
               
                menuTransacciones.ImprimirMenu();

            }
            catch (Exception e)
            {

                Console.WriteLine("****Seleccione una opcion Valida****\n");
                Console.ReadKey();
                menuTransacciones.ImprimirMenu();
            }
            Console.ReadKey();
            menuTransacciones.ImprimirMenu();

        }

        public void Edit()
        {
            try
            {
                string nombre = "";
                double monto = 0.0;
                Console.Clear();
                Read();
            
                Console.WriteLine("Seleccione la transaccion que desea editar");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (Repositorio.Instance.numeroTransaccionAprobada.Contains(opcion))
                {


                    Console.WriteLine("Nombre del Cliente:");
                    nombre = Console.ReadLine();

                    Console.WriteLine("Monto: ");
                    monto = Convert.ToDouble(Console.ReadLine());



                }
                else
                {

                    Console.WriteLine("Este numero de Transaccion no existe");
                    Console.ReadKey();
                    Console.WriteLine("Desea realizar otra busqueda s/n");
                    string busqueda = Console.ReadLine();

                    if (busqueda == "s")
                    {
                        Console.Clear();
                        Edit();
                    }
                    else
                    {
                        menuTransacciones.ImprimirMenu();
                    }

                }

                TransaccionesAprobadas transacionEditada = new TransaccionesAprobadas(opcion, nombre, monto);

                Repositorio.Instance.transaccionesAprobadas[opcion - 1] = transacionEditada;

                menuTransacciones.ImprimirMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine("****Seleccione una opcion Valida****\n");
                Console.ReadKey();
                Edit();
            }
        }

        public void Read()
        {
           
            Console.WriteLine("****Listado de las Transacciones Aprobadas****\n");
            foreach (TransaccionesAprobadas item in Repositorio.Instance.transaccionesAprobadas)
            {
                Console.WriteLine(" #" + item.NumeroTransaccion + " Nombre Cliente: " + item.NombreCliente + " Monto: " + item.Monto + "\n");

            }

         
        }

        //public void CancelarTransaccion(int IndexAP, TransaccionesCanceladas aprobadas)
        //{

        //    Repositorio.Instance.transaccionesAprobadas[IndexAP].transaccionesCanceladas.Add(aprobadas);
        //}
            public TransaccionesAprobadas GetByIndex(int index)
        {
            return Repositorio.Instance.transaccionesAprobadas[index];
        }

        public bool IsValid(int transaccion)
        {

            int num = Repositorio.Instance.numeroTransaccionAprobada.LastOrDefault();


            if (transaccion == num)
            {
                return false;
            }

            return true;
        }

    }
}
