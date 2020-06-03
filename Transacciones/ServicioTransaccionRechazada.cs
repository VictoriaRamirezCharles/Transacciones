using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
    class ServicioTransaccionRechazada : ITransaccion
    {
    
        private MenuTransacciones menuTransacciones;
        public ServicioTransaccionRechazada()
        {
   
            menuTransacciones = new MenuTransacciones();
        }
        public void Add()
        {
            try
            {
                int ntransaccion = Repositorio.Instance.numeroTransaccionRechazada.LastOrDefault();

                bool isValid = IsValid(ntransaccion);
                if (isValid)
                {
                    Console.WriteLine("Transaccion #:" + ntransaccion);
                    Repositorio.Instance.numeroTransaccionRechazada.Add(ntransaccion);
                }
                else
                {
                    ntransaccion++;
                    Repositorio.Instance.numeroTransaccionRechazada.Add(ntransaccion);
                    Console.WriteLine("Transaccion #:" + ntransaccion);
                }
                Console.WriteLine("Nombre del cliente: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Monto de la Transaccion ");
                double monto = Convert.ToDouble(Console.ReadLine());

                TransaccionesRechazadas nuevoTransaccion = new TransaccionesRechazadas(ntransaccion, nombre, monto);

                Repositorio.Instance.transaccionesRechazadas.Add(nuevoTransaccion);
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
                Repositorio.Instance.TransaccionesEliminadas.Add("Transaccion #" + opcion);
                Repositorio.Instance.transaccionesRechazadas.RemoveAt(opcion - 1);

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
                else { 
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
                
                TransaccionesRechazadas transacionEditada = new TransaccionesRechazadas(opcion, nombre, monto);

                Repositorio.Instance.transaccionesRechazadas[opcion - 1] = transacionEditada;

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
            Console.WriteLine("****Listado de las Transacciones Rechazadas****\n");
            foreach (TransaccionesRechazadas item in Repositorio.Instance.transaccionesRechazadas)
            {
                Console.WriteLine(" #" + item.NumeroTransaccion + " Nombre Cliente: " + item.NombreCliente + " Monto: " + item.Monto + "\n");



            }
          

        }

        public int GetByIndex(int index)
        {
            return Repositorio.Instance.numeroTransaccionRechazada[index];
        }


        public bool IsValid(int transaccion)
        {

            int num = Repositorio.Instance.numeroTransaccionRechazada.LastOrDefault();


            if (transaccion == num)
            {
                return false;
            }

            return true;
        }
    }
}
