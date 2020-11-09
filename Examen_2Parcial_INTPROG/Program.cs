using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

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
                Console.WriteLine("   3. SALIR DE LA APLICACION");
                Console.Write("     >  ");

                byte opcion = byte.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1:// Solucion para clientes
                        {
                            byte controlClientes = 0;
                            do { 
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

                                case 1: //Agregar Cliente
                                    {
                                            String cliente;
                                            Console.Clear();
                                            Console.WriteLine("    ----------- AGREGAR CLIENTE -----------" + '\n');
                                            Console.WriteLine("    Porfavor ingrese: ");
                                            Console.Write("   > NOMBRE COMPLETO: ");
                                            cliente = Console.ReadLine();
                                            Console.Write("   > DIRECCIÓN: ");
                                            cliente = cliente + "," + Console.ReadLine();
                                            Console.Write("   > TELÉFONO: ");
                                            cliente = cliente + "," + Console.ReadLine();
                                            Console.Write("   > CODIGO POSTAL: ");
                                            cliente = cliente + "," + Console.ReadLine();

                                            string temporal = null;

                                            do
                                            {
                                                Console.Write("   > ESTATUS (ACTIVO/INACTIVO): ");
                                                temporal = Console.ReadLine().ToUpper();
                                                if (temporal.Equals("ACTIVO") || temporal.Equals("INACTIVO"))
                                                {
                                                    cliente = cliente + "," + temporal;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("      > ESTATUS NO VALIDO VUELVA A INGRESAR ");
                                                }
                                            } while (temporal != ("ACTIVO") || temporal != ("INACTIVO"));


                                                Console.Write("   > CORREO ELECTRONICO: ");
                                            cliente = cliente + "," + Console.ReadLine();


                                            StreamWriter escritura = File.AppendText(rutaClientes);
                                            escritura.WriteLine(cliente);
                                            escritura.Close();

                                            Console.WriteLine('\n' + "          Los valores ingresados se han almacenado corretamente");
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
                                Console.WriteLine('\n' + "      Ingrese 0 para volver al menu PRINCIPAL o ");
                                Console.WriteLine("      Ingrese 1 para mostrar nuevamente el menu CLIENTES");
                                controlClientes = byte.Parse(Console.ReadLine());
                                if (controlClientes == 0)
                                {
                                    control = 1;
                                }
                                Console.Clear();

                            } while (controlClientes != 0);

                            break;
                        }
                    case 2: //Solucion para productos
                        {
                            byte controlProductos = 0;
                            do
                            {
                            Console.Clear();
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
                                Console.WriteLine('\n' + "Ingrese 0 para volver al menu PRINCIPAL o Ingrese 1 para mostrar nuevamente el menu CLIENTES");
                                controlProductos = byte.Parse(Console.ReadLine());
                                if (controlProductos == 0)
                                {
                                    control = 1;
                                }
                                Console.Clear();

                            } while (controlProductos != 0);

                            break;
                        }
                    case 3:
                        {
                            control = 0;
                            break;
                        }
                    default:
                        {
                            Console.Write("   > la opción ingresada no es valida");
                            break;
                        }
                }

                if (control == 1)
                {
                    
                }
                else
                {
                    if (control == 0) 
                    {

                    }
                    else
                    {
                        Console.WriteLine('\n' + "Ingrese 0 para salir de la aplicación o Ingrese 1 para mostrar nuevamente el menu");
                        control = byte.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    
                }

            } while (control != 0);
        }
    }
}
