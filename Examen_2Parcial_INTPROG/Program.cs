using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2Parcial_INTPROG
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programa que realiza altas, cambios y bajas de CLIENTES (estatus> activo e inactivo)
             * Datos a obtener > Nombre completo, direccion, teléfono, código postal, estatus, correo electrónico)
             * REQUISITOS: Se podrá consultar los nombres de todos los clintes regitrados
             * Ademas realizar alta, cambios y existencias de PRODUCTOS 
             * Datos de producto > Nombre, descripcion, precio, cantidad en existencia, código de barras (10 digitos)
             * REQUISITOS: Se debera consultar los productos cuya existencia sea menor a 3
             */

            byte control = 0;

            string rutaClientes = @"C:\Users\david\Documents\IntProg\Examen_2Parcial_INTPROG\DB\clientes.txt";
            string rutaProductos = @"C:\Users\david\Documents\IntProg\Examen_2Parcial_INTPROG\DB\clientes.txt";

            do
            {
                Console.WriteLine("    ------------- PROGRAMA -------------");
                Console.WriteLine(" Ingrese al sistema que desea ingresar ");
                Console.WriteLine("   1. Clientes");
                Console.WriteLine("   2. Productos");
                Console.Write("     >  ");

                byte opcion = byte.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1:// Solucion para clientes
                        {
                            Console.Clear();
                            Console.WriteLine("    ------------- CLIENTES -------------");
                            Console.WriteLine(" Ingrese la opcion que desea realizar ");
                            Console.WriteLine("   1. Agregar Cliente");
                            Console.WriteLine("   3. Cambiar Datos de Cliente");
                            Console.WriteLine("   2. Eliminar Cliente");
                            Console.WriteLine("   4. Consultar Nombres");
                            Console.Write("     >  ");

                            byte opcionCliente = byte.Parse(Console.ReadLine());

                            switch (opcionCliente)
                            {
                                case 1:
                                    {
                                        break;
                                    }
                                case 2:
                                    {
                                        break;
                                    }
                                case 3:
                                    {
                                        break;
                                    }
                                case 4:
                                    {
                                        break;
                                    }
                                case 5:
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        Console.Write("   > la opción ingresada no es valida");
                                        break;
                                    }
                            }

                            break;
                        }
                    case 2: //Solucion para productos
                        {
                            Console.WriteLine("    ------------- PRODUCTOS -------------");
                            Console.WriteLine(" Ingrese la opcion que desea realizar ");
                            Console.WriteLine("   1. Agregar Producto");
                            Console.WriteLine("   3. Cambiar Nombre y Existencias de producto");
                            Console.WriteLine("   3. Consultar Producto con Existencias menor a 3");
                            Console.Write("     >  ");

                            byte opcionProducto = byte.Parse(Console.ReadLine());

                            switch (opcionProducto)
                            {
                                case 1:
                                    {
                                        break;
                                    }
                                case 2:
                                    {
                                        break;
                                    }
                                case 3:
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        Console.Write("   > la opción ingresada no es valida");
                                        break;
                                    }
                            }
                                    break;
                        }
                    default:
                        {
                            Console.Write("   > la opción ingresada no es valida");
                            break;
                        }
                }

                Console.WriteLine('\n' + "Ingrese 0 para salir de la aplicación o Ingrese 1 para mostrar nuevamente el menu");
                control = byte.Parse(Console.ReadLine());
                Console.Clear();

            } while (control != 0);
        }
    }
}
