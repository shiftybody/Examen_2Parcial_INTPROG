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
            string rutaProductos = @"C:\Users\david\Documents\IntProg\Examen_2Parcial_INTPROG\DB\productos.txt";

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
                            Console.WriteLine("   1. Agregar Cliente");  // listo
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

                                            do  // validamos que solo se ingrese activo o inactivo 
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


                                            StreamWriter escritura = File.AppendText(rutaClientes); // es posible que utilice constructores más veces de las que debería xd 
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
                            Console.WriteLine("   1. Agregar Producto");  // listo
                            Console.WriteLine("   3. Cambiar Nombre y Existencias de producto");  //
                            Console.WriteLine("   3. Consultar Producto con Existencias menor a 3");  // listo
                            Console.Write("     >  ");

                            byte opcionProducto = byte.Parse(Console.ReadLine());

                            switch (opcionProducto)
                            {
                                case 1: //Agregar producto 
                                    {
                                            String producto;
                                            Console.Clear();
                                            Console.WriteLine("    ----------- AGREGAR PRODUCTO -----------" + '\n');
                                            Console.WriteLine("    Porfavor ingrese: ");
                                            Console.Write("   > NOMBRE: ");
                                            producto = Console.ReadLine();
                                            Console.Write("   > DESCRIPCIÓN: ");
                                            producto = producto + "," + Console.ReadLine();
                                            Console.Write("   > PRECIO: ");
                                            producto = producto + "," + Console.ReadLine();
                                            Console.Write("   > CANTIDAD EN EXISTENCIA: ");
                                            producto = producto + "," + Console.ReadLine();

                                            string temporal = null;

                                            do
                                            {
                                                Console.Write("   > CÓDGIO DE BARRAS (1O DIGITOS): "); // validmos que el codigo de barras sea de 10 digitos
                                                temporal = Console.ReadLine().ToUpper();
                                                if (temporal.Length == 10 )
                                                {
                                                    producto = producto + "," + temporal;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("      > NUMERO DE CARACTERES INCORRECTO ( 10 DIGITOS )");
                                                }
                                            } while (temporal.Length != 10);


                                            StreamWriter escritura = File.AppendText(rutaProductos);
                                            escritura.WriteLine(producto);
                                            escritura.Close();

                                            Console.WriteLine('\n' + "          Los valores ingresados se han almacenado corretamente");

                                            break;
                                    }
                                case 2: //Cambiar Nombre y Existencias de producto
                                    {
                                            Console.Clear();
                                            Console.WriteLine("----------- CAMBIAR NOMBRE Y EXISTENCAS -----------" + '\n');

                                            StreamReader lectura = File.OpenText(rutaProductos); 
                                            String cambio = lectura.ReadToEnd();
                                            lectura.Close();

                                            string[] productos = cambio.Split('\n');



                                            break;
                                    }
                                case 3: //Consultar existencias menor a 3
                                        {
                                            Console.Clear();
                                            Console.WriteLine("----------- CONSULTA DE EXISTENCIAS < 3 -----------" + '\n');

                                            StreamReader lectura = File.OpenText(rutaProductos);
                                            String consulta = lectura.ReadToEnd();
                                            lectura.Close();

                                            string[] productos = consulta.Split('\n');

                                            for (int x = 0; x < productos.Length - 1; x++)
                                            {

                                                string[] prod = productos[x].Split(',');

                                                if (prod[3].Trim().Equals("1") || prod[3].Trim().Equals("2"))
                                                {

                                                    Console.WriteLine("   > NOMBRE: " + prod[0]);
                                                    Console.WriteLine("   > DESCRIPCION: " + prod[1]);
                                                    Console.WriteLine("   > PRECIO: " + prod[2]);
                                                    Console.WriteLine("   > EXISTENCIA: " + prod[3]);
                                                    Console.WriteLine("   > CODIGO DE BARRAS: " + prod[4]);

                                                }
                                                else
                                                {
                                                    Console.WriteLine(" NO EXISTEN PRODUCTOS EN EXISTENCIA < 3");
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

                if (control == 1) // para cuando en algún retorno de control el valor ya es != de 0 y que cierre el do-while para finalizar el programa 
                {
                   // estos casos fueron creados para conseguir el movimiento entre el menú principal y las opciones
                   // del cliente o producto sin recurrir a metodos o funciones. 
                }
                else
                {
                    if (control == 0) // si aun no tenemos un valor de control asignado verificiamos si es igual a cero 
                    {
                        // si el valor es diferente de 0 cerramos el programa 
                    }
                    else // si no es diferente de cero le preguntamos si quiere volver a mostrar el menu principal 
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
