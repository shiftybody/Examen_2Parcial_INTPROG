using System;
using System.IO;

namespace Examen_2Parcial_INTPROG
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaCliente = ("clientes.txt");
            string rutaProductos = ("productos.txt");

            // Si no existe creamos los archivos 
            if (!(File.Exists(rutaCliente)))
            {
                StreamWriter escritura = File.CreateText(rutaCliente);
                escritura.Close();
            }
            if (!(File.Exists(rutaProductos)))
            {
                StreamWriter escritura2 = File.CreateText(rutaProductos);
                escritura2.Close();
            }


            int control = 0;

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
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("    ------------- CLIENTES -------------");
                                Console.WriteLine(" Ingrese la opcion que desea realizar ");
                                Console.WriteLine("   1. Agregar Cliente");  // listo
                                Console.WriteLine("   3. Cambiar Datos de Cliente");   // listo
                                Console.WriteLine("   2. Eliminar Cliente");  // listo
                                Console.WriteLine("   4. Consultar Nombres");  // listo
                                Console.Write("     >  ");
                                byte opcionCliente = byte.Parse(Console.ReadLine());

                                switch (opcionCliente)
                                {

                                    case 1: //Agregar Cliente
                                        {

                                            StreamReader lectura = File.OpenText(rutaCliente);
                                            String contenido = lectura.ReadToEnd();
                                            lectura.Close();

                                            string[] ids = contenido.Split('\n');
                                            int id = ids.Length - 1;
                                            id++;



                                            String cliente;

                                            Console.Clear();
                                            Console.WriteLine("    ----------- AGREGAR CLIENTE -----------" + '\n');
                                            Console.Write("   > ID : " + id + '\n');
                                            cliente = id.ToString() + ",";
                                            Console.WriteLine("");

                                            Console.WriteLine("    Porfavor ingrese: ");

                                            Console.Write("   > NOMBRE COMPLETO: ");
                                            cliente = cliente + Console.ReadLine();
                                            Console.Write("   > DIRECCIÓN: ");
                                            cliente = cliente + "," + Console.ReadLine();
                                            Console.Write("   > TELÉFONO: ");
                                            cliente = cliente + "," + Console.ReadLine();
                                            Console.Write("   > CODIGO POSTAL: ");
                                            cliente = cliente + "," + Console.ReadLine();
                                            Console.WriteLine("   > ESTATUS : ACTIVO");
                                            cliente = cliente + "," + "ACTIVO";

                                            // validamos que solo se ingrese activo o inactivo 
                                            /*string temporal = null;
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
                                             } while (temporal != ("ACTIVO") || temporal != ("INACTIVO"));  */


                                            Console.Write("   > CORREO ELECTRONICO: ");
                                            cliente = cliente + "," + Console.ReadLine();


                                            StreamWriter escritura = File.AppendText(rutaCliente);
                                            escritura.WriteLine(cliente);
                                            escritura.Close();

                                            Console.WriteLine('\n' + "          Los valores ingresados se han almacenado corretamente");
                                            break;
                                        }
                                    case 2: // Modificar cliente
                                        {
                                            String cliente;
                                            Console.Clear();
                                            Console.WriteLine("    ----------- MODIFICAR CLIENTE -----------" + '\n');
                                            Console.WriteLine("    Porfavor ingrese: ");
                                            Console.Write("     >  ID  DEL CLIENTE: ");
                                            cliente = Console.ReadLine();

                                            StreamReader lectura = File.OpenText(rutaCliente);
                                            string contenido = lectura.ReadToEnd();
                                            lectura.Close();

                                            string[] clientes = contenido.Split('\n');

                                            for (int x = 0; x < clientes.Length; x++)
                                            {
                                                string[] linea = clientes[x].Split(',');

                                                if (linea[0].Trim().ToLower().Equals(cliente.ToLower()))
                                                {
                                                    if (linea[5].Equals("ACTIVO"))
                                                    {
                                                        Console.WriteLine("        CLIENTE ENCONTRADO" + '\n');

                                                        Console.WriteLine("   > NOMBRE: " + linea[1]);
                                                        Console.WriteLine("   > DIRECCIÓN: " + linea[2]);
                                                        Console.WriteLine("   > TELEFONO: " + linea[3]);
                                                        Console.WriteLine("   > CODIGO POSTAL: " + linea[4]);
                                                        Console.WriteLine("   > CORREO: " + linea[6]);

                                                        Console.WriteLine("        INGRESE NUEVOS DATOS:" + '\n');

                                                        cliente = linea[0] + ",";
                                                        Console.Write("   > NOMBRE COMPLETO: ");
                                                        cliente = cliente + Console.ReadLine();
                                                        Console.Write("   > DIRECCIÓN: ");
                                                        cliente = cliente + "," + Console.ReadLine();
                                                        Console.Write("   > TELÉFONO: ");
                                                        cliente = cliente + "," + Console.ReadLine();
                                                        Console.Write("   > CODIGO POSTAL: ");
                                                        cliente = cliente + "," + Console.ReadLine();
                                                        Console.WriteLine("   > ESTATUS : ACTIVO");
                                                        cliente = cliente + "," + "ACTIVO";
                                                        Console.Write("   > CORREO ELECTRONICO: ");
                                                        cliente = cliente + "," + Console.ReadLine();

                                                        clientes[x] = cliente;

                                                        StreamWriter escritura = File.CreateText(rutaCliente);

                                                        for (int y = 0; y < (clientes.Length - 1); y++)
                                                        {
                                                            escritura.WriteLine(clientes[y].Trim());
                                                        }

                                                        escritura.Close();

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine('\n' + "     EL CLIENTE QUE BUSCA HA SIDO ELIMINADO" + '\n');
                                                    }
                                                }

                                            }




                                            break;
                                        }
                                    case 3:
                                        {
                                            String cliente;
                                            Console.Clear();
                                            Console.WriteLine("    ----------- ELIMINAR CLIENTE -----------" + '\n');
                                            Console.WriteLine("    Porfavor ingrese: ");
                                            Console.Write("     >  ID  DEL CLIENTE A ELIMINAR : ");
                                            cliente = Console.ReadLine();

                                            StreamReader lectura = File.OpenText(rutaCliente);
                                            string contenido = lectura.ReadToEnd();
                                            lectura.Close();

                                            string[] clientes = contenido.Split('\n');

                                            for (int x = 0; x < clientes.Length; x++)
                                            {
                                                string[] linea = clientes[x].Split(',');

                                                if (linea[0].Trim().ToLower().Equals(cliente.ToLower()))
                                                {
                                                    if (linea[5].Equals("ACTIVO"))
                                                    {
                                                        Console.WriteLine("        CLIENTE ENCONTRADO" + '\n');

                                                        Console.WriteLine("   > NOMBRE: " + linea[1]);
                                                        Console.WriteLine("   > DIRECCIÓN: " + linea[2]);
                                                        Console.WriteLine("   > TELEFONO: " + linea[3]);
                                                        Console.WriteLine("   > CODIGO POSTAL: " + linea[4]);
                                                        Console.WriteLine("   > CORREO: " + linea[6]);

                                                        Console.Write('\n' + "        SEGURO QUE DESEA ELIMINAR AL CLIENTE ?   SI/NO : ");
                                                        string respuesta = Console.ReadLine().ToLower();


                                                        if (respuesta.Equals("si"))
                                                        {

                                                            cliente = linea[0] + "," + linea[1] + "," + linea[2] + "," + linea[3] + "," + linea[4] + "," + "INACTIVO," + linea[6];

                                                            clientes[x] = cliente;

                                                            StreamWriter escritura = File.CreateText(rutaCliente);

                                                            for (int y = 0; y < (clientes.Length - 1); y++)
                                                            {
                                                                escritura.WriteLine(clientes[y].Trim());
                                                            }

                                                            escritura.Close();

                                                            Console.WriteLine('\n' + "     EL CLIENTE A SIDO ELIMINADO" + '\n');

                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine('\n' + "     EL CLIENTE QUE BUSCA YA HA SIDO ELIMINADO" + '\n');
                                                    }
                                                }

                                            }
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("    ----------- CONSULTA DE CLIENTES -----------" + '\n');
                                            Console.WriteLine("    Los clientes ingresados actualmente son : " + '\n');


                                            StreamReader lectura = File.OpenText(rutaCliente);
                                            string contenido = lectura.ReadToEnd();
                                            lectura.Close();

                                            string[] clientes = contenido.Split('\n');

                                            for (int x = 0; x < clientes.Length - 1; x++)
                                            {

                                                string[] linea = clientes[x].Split(',');

                                                if (linea[5].Trim().Equals("ACTIVO"))
                                                {
                                                    Console.Write("          ID: " + linea[0] + "    NOMBRE: " + linea[1] + '\n');
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
                                Console.WriteLine("   2. Cambiar Nombre y Existencias de producto");  //
                                Console.WriteLine("   3. Consultar Producto con Existencias menor a 3");  // listo
                                Console.Write("     >  ");

                                byte opcionProducto = byte.Parse(Console.ReadLine());

                                switch (opcionProducto)
                                {
                                    case 1: //Agregar producto 
                                        {

                                            StreamReader lectura = File.OpenText(rutaProductos);
                                            String contenido = lectura.ReadToEnd();
                                            lectura.Close();

                                            string[] ids = contenido.Split('\n');
                                            int id = ids.Length - 1;
                                            id++;


                                            String producto;

                                            Console.Clear();
                                            Console.WriteLine("    ----------- AGREGAR PRODUCTO -----------" + '\n');

                                            Console.Write("   > ID : " + id + '\n');
                                            producto = id.ToString() + ",";
                                            Console.WriteLine("");

                                            Console.WriteLine("    Porfavor ingrese: ");
                                            Console.Write("   > NOMBRE: ");
                                            producto = producto + Console.ReadLine();
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
                                                if (temporal.Length == 10)
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

                                            string producto;
                                            Console.WriteLine("    Porfavor ingrese: ");
                                            Console.Write("     >  ID  DEL PRODUCTO: ");
                                            producto = Console.ReadLine();
                                            StreamReader lectura = File.OpenText(rutaProductos);
                                            string contenido = lectura.ReadToEnd();
                                            lectura.Close();

                                            string[] productos = contenido.Split('\n');

                                            for (int x = 0; x < productos.Length; x++)
                                            {
                                                string[] linea = productos[x].Split(',');

                                                if (linea[0].Trim().ToLower().Equals(producto.ToLower()))
                                                {
                                                        Console.WriteLine("        PRODUCTO ENCONTRADO" + '\n');

                                                        Console.WriteLine("   > NOMBRE: " + linea[1]);
                                                        Console.WriteLine("   > EXISTENCIAS: " + linea[4]);

                                                        Console.WriteLine('\n' +"        INGRESE NUEVOS DATOS:" + '\n');

                                                        Console.Write("   > NOMBRE : ");
                                                        string nombre = Console.ReadLine();
                                                        Console.Write("   > EXISTENCIAS: ");
                                                        string existencias = Console.ReadLine();


                                                        productos[x] = linea[0] + ',' + nombre + ','  + linea[2] + ',' + linea[3] + ',' + existencias + ',' + linea[5];

                                                        StreamWriter escritura = File.CreateText(rutaProductos);

                                                        for (int y = 0; y < (productos.Length - 1); y++)
                                                        {
                                                            escritura.WriteLine(productos[y].Trim());
                                                        }

                                                        escritura.Close();

                                                    Console.WriteLine("        PRODUCTO ACTUALIZADO:" + '\n');

                                                }

                                            }

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

                                                if (prod[4].Trim().Equals("1") || prod[4].Trim().Equals("2"))
                                                {
                                                    Console.WriteLine("   > ID: " + prod[0]);
                                                    Console.WriteLine("   > NOMBRE: " + prod[1]);
                                                    Console.WriteLine("   > DESCRIPCION: " + prod[2]);
                                                    Console.WriteLine("   > PRECIO: " + prod[3]);
                                                    Console.WriteLine("   > EXISTENCIA: " + prod[4]);
                                                    Console.WriteLine("   > CODIGO DE BARRAS: " + prod[5]);

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
