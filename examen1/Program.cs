
int tamano = 15;
int[] numFact = new int[tamano];
string[] numplaca = new string[tamano];
string[] fechas = new string[tamano];
string[] horas = new string[tamano];
string[] tipoVehiculo = new string[tamano];
string[] tipoServiciocaseta = new string[tamano];
string opcions = string.Empty;
bool opcionValida = false;
int indice = 0;
int[] numPago = new int[tamano];
int contador1 = 1;
int contador2 = 0;
string[] nombres = new string[tamano];
string[] tipoServicio = new string[tamano];

int opcion = 0;
decimal[] montoPagar = new decimal[tamano];
decimal[] montoComision = new decimal[tamano];


bool encontrado = false;
int opcion2 = 0;
string fecha = string.Empty;




Menu();



void InicializarArreglos()
{
    numPago = Enumerable.Repeat(0, tamano).ToArray<int>();
    fechas = Enumerable.Repeat(" ", tamano).ToArray<string>();
    horas = Enumerable.Repeat(" ", tamano).ToArray<string>();
    nombres = Enumerable.Repeat(" ", tamano).ToArray<string>();
    numCaja = Enumerable.Repeat(0, tamano).ToArray<int>();
    tipoServicio = Enumerable.Repeat(" ", tamano).ToArray<string>();
    numFact = Enumerable.Repeat(0, tamano).ToArray<int>();
    montoPagar = Enumerable.Repeat(0m, tamano).ToArray<decimal>();
    montoComision = Enumerable.Repeat(0m, tamano).ToArray<decimal>();
    montoPagaCliente = Enumerable.Repeat(0m, tamano).ToArray<decimal>();
    vuelto = Enumerable.Repeat(0m, tamano).ToArray<decimal>();
    numFact = Enumerable.Repeat(0, tamano).ToArray<int>();
    numplaca = Enumerable.Repeat(" ", tamano).ToArray<string>();
    tipoVehiculo = Enumerable.Repeat(" ", tamano).ToArray<string>();
    fechas = Enumerable.Repeat(" ", tamano).ToArray<string>();
    horas = Enumerable.Repeat(" ", tamano).ToArray<string>();
    Console.WriteLine("Arreglos inicializados correctamente. Presione enter para continuar");
    Console.ReadKey();
    Console.Clear();
}

void RealizarPagos()
{

    Console.WriteLine("Bienvenido al programa control de peajes.");
    opcions = string.Empty;
    opcionValida = false;

    while (!opcionValida)
    {
        Console.WriteLine("Si desea realizar un pago digite 'si', o si no quiere realizar un pago digite 'no'");
        opcions = Console.ReadLine().ToLower();
        if (opcions.Equals("si"))
        {
            if (opcions.Equals("si"))
            {
                Console.WriteLine($"Digite los datos del camnion ");
            
                Console.WriteLine("Digite el numero de factura .?");
                numFact[contador2] = int.Parse(Console.ReadLine());

                //Numero de placa
                Console.WriteLine("Digite el numero de placa .?");
                numplaca[contador2] = Console.ReadLine().ToUpper();
        
                {


                    //Fecha
                    bool fechaValida = false;
                    DateTime fechaIngresada = DateTime.MinValue;
                    while (!fechaValida)//Validador de formato de fecha y asignador de la misma en el vector.
                    {
                        Console.WriteLine("Por favor, ingresa una fecha en formato dd/MM/yyyy:");
                        string fechaTexto = Console.ReadLine();

                        try
                        {
                            fechaIngresada = DateTime.ParseExact(fechaTexto, "dd/MM/yyyy", null);
                            fechaValida = true;
                            fechas[contador2] = fechaIngresada.ToShortDateString();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Formato de fecha incorrecto. Por favor, intenta de nuevo.");
                        }
                    }

                    //Hora
                    string formatoHora = "HH:mm"; // Formato de hora deseado (24 horas)
                    DateTime horaIngresada; bool formatoCorrecto = false;
                    while (!formatoCorrecto)
                    {
                        Console.WriteLine("Por favor ingrese la hora en formato HH:mm (24 horas): ");
                        string hora = Console.ReadLine();

                        if (DateTime.TryParseExact(hora, formatoHora, null, System.Globalization.DateTimeStyles.None, out horaIngresada))
                        {
                            formatoCorrecto = true;
                            Console.WriteLine("Hora ingresada correctamente: " + horaIngresada.ToString("HH:mm"));
                            horas[contador2] = hora;
                        }
                        else
                        {
                            Console.WriteLine("Formato de hora incorrecto. Por favor, inténtelo nuevamente.");
                        }
                    }

                    Console.WriteLine("Digite el tipo vehículo: \n 1-Moto. 2-Vehículo Liviano. 3-Camión o Pesado. 4-Autobús");
                    opcion = 0;
                    opcionValida = false;
                    do
                    {
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out opcion))
                        {
                            switch (opcion)
                            {
                                case 1:
                                    tipoServicio[contador2] = "1-Moto";
                                    opcionValida = true;
                                    break;
                                case 2:
                                    tipoServicio[contador2] = "2-Vehículo Livian";
                                    opcionValida = true;
                                    break;
                                case 3:
                                    tipoServicio[contador2] = "3-Camión o Pesadoa";
                                    opcionValida = true;
                                    break;
                                case 4:
                                    tipoServicio[contador2] = "4-Autobús";
                                    opcionValida = true;
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                        }
                    } while (!opcionValida);

              

             

                    if (opcion == 1)
                    {
                        montoComision[contador2] = 500;
                    }
                    else if (opcion == 2)
                    {
                        montoComision[contador2] = 700;
                    }
                    else if (opcion == 3)
                    {
                        montoComision[contador2] = 2700;
                    }
                    else if (opcion == 4)
                    {
                        montoComision[contador2] = 3700;
                    }

                    //Numero de Caseta
                    Console.WriteLine("Digite el numero de caseta: \n 1=caseta 1. 2=caseta 2.3=caseta 3");
                    opcion = 0;
                    opcionValida = false;
                    do
                    {
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out opcion))
                        {
                            switch (opcion)
                            {
                                case 1:
                                    tipoServiciocaseta[contador2] = "1=caseta 1";
                                    opcionValida = true;
                                    break;
                                case 2:
                                    tipoServiciocaseta[contador2] = "2=caseta 2";
                                    opcionValida = true;
                                    break;
                                case 3:
                                    tipoServiciocaseta[contador2] = "3=caseta 3";
                                    opcionValida = true;
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                        }
                    } while (!opcionValida);

                    //Monto 
                 
                    Console.WriteLine($"El monto a pagar por el vehiculo es es de: {montoComision[contador2]}");
     

                    indice++;
                    contador1++;
                    contador2++;
                    Console.WriteLine($"¿Desea continuar ingresando datos? Digite 'si' para continuar, o digite 'no' para salir");
                    opcions = Console.ReadLine().ToLower();
                    opcionValida = false;

                }
                else
                {
                    Console.WriteLine("Vectores llenos, no se pueden ingresar mas datos.");// Si la referencia es mayor a los tamaños del arreglo, el sistema se va a salir automaticamente.
                    break;
                }
            }
            else if (opcions.Equals("no"))//opcion para salir y limpiar pantalla.
            {
                Console.WriteLine("Saliendo del sistema de pagos. Digite cualquier tecla para salir.");
                Console.WriteLine($"Digite 'No' para salir completamente.'");
                Console.ReadKey();
                break;
            }
            else
            {
                throw new Exception("El texto ingresado no corresponde a ninguna de las opciones. Por favor intentelo de nuevo.Presione cualquier tecla para continuar... ");
            }

        }
        else if (opcions.Equals("no"))
        {
            Console.WriteLine("Saliendo del sistema de pagos. Digite cualquier tecla para salir.");
            Console.ReadKey();
            Console.Clear();
            opcionValida = true;
        }
        else
        {
            Console.WriteLine("opcion invalida");
        }
    }
}
void ConsultarCarro()
{

    encontrado = false;
    Console.WriteLine("Digite el numero de placa a consultar");
    opcion2 = int.Parse(Console.ReadLine());

    for (int i = 0; i < numplaca.Length; i++)
    {
        if (opcion2 == numplaca[i] && opcion2 > 0)
        {
            Console.WriteLine("Reporte");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Numero de factura:    {numFact[i]}");
            Console.WriteLine($"Fecha:             {fechas[i]}          Hora: {horas[i]}");
            Console.WriteLine($"                                                               ");
            Console.WriteLine($"Numero de placa:            {numplaca[i]}           Nombre: {tipoVehiculo[i]}");
            Console.WriteLine($"Numero de factura:    {montoPagar[i]}");
            Console.WriteLine($"Numero de factura:    {tipoServiciocaseta[i]}");
            encontrado = true;
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
            Console.Clear();
            break;
        }
    }
    if (!encontrado)
    {
        Console.WriteLine("El numero de pago no se encuentra registrado. Presione una tecla para salir y por favor ingrese nuevamente.");
        Console.ReadKey();
        Console.Clear();
    }
    opcion2 = 0;
}
void Menu()
{
    int opcion;
    bool opcionValida = false;

    do
    {
        Console.WriteLine("***************Programa control de peaje de una autopista  ***************");
        Console.WriteLine("1- Inicializar vectores.");
        Console.WriteLine("2- Ingresar Paso Vehicular.");
        Console.WriteLine("3- Consulta de vehículos x Número de Placa");
        Console.WriteLine("4- Modificar Datos Vehículos x número de Placa.");
        Console.WriteLine("5- Eliminar pagos.");
        Console.WriteLine("6- 5.Reporte Todos los Datos de los vectores");
        Console.WriteLine("7- Salir.");
        Console.WriteLine("Digite la opcion deseada.");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: InicializarArreglos(); break;
            case 2: RealizarPagos(); break;
            case 3: ConsultarCarro(); break;
            case 4:; break;
            case 5: break;
            case 6: break;
            case 7: Console.WriteLine("Gracias por utilizar nuestro sistema, cierre la ventana para salir."); break;
        }
    } while (opcion < 7 && opcion > 0);

    if (opcion > 7 || opcion < 1)
    {
        Console.WriteLine("El numero digitado no corresponde a ninguna de las opciones, cierre el programa y vuelva a abrirlo para intentarlo de nuevo.");
    }
    Console.ReadLine();
}