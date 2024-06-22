using System;

public Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string opcionSeleccionadaTemporal;
            int opcionSeleccionada = 0;
            int x;
            float y;
            string numero1Temporal, numero2Temporal;
            float numero1, numero2, resultado;

            while (opcionSeleccionada != 5)
            {
                Console.WriteLine("1. Realizar suma de dos números.");
                Console.WriteLine("2. Realizar resta de dos números.");
                Console.WriteLine("3. Realizar multiplicación de dos números.");
                Console.WriteLine("4. Realizar división de dos números.");
                Console.WriteLine("5. Salir.");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Ingrese una opción:");

                opcionSeleccionadaTemporal = Console.ReadLine();

                if (int.TryParse(opcionSeleccionadaTemporal, out x))
                {
                    opcionSeleccionada = int.Parse(opcionSeleccionadaTemporal);

                    switch (opcionSeleccionada)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el primer valor:");
                            numero1Temporal = Console.ReadLine();
                            Console.WriteLine("Ingrese el segundo valor:");
                            numero2Temporal = Console.ReadLine();

                            if (!(float.TryParse(numero1Temporal, out y)) || !(float.TryParse(numero2Temporal, out y)))
                            {
                                Console.WriteLine("Los valores ingresados no son incorrectos");
                            }
                            else
                            {
                                numero1 = float.Parse(numero1Temporal);
                                numero2 = float.Parse(numero2Temporal);

                                resultado = numero1 + numero2;

                                Console.WriteLine("La suma es: " + resultado);
                            }

                            break;
                        case 2:
                            Console.WriteLine("Ingrese el primer valor:");
                            numero1Temporal = Console.ReadLine();
                            Console.WriteLine("Ingrese el segundo valor:");
                            numero2Temporal = Console.ReadLine();

                            if (!(float.TryParse(numero1Temporal, out y)) || !(float.TryParse(numero2Temporal, out y)))
                            {
                                Console.WriteLine("Los valores ingresados no son incorrectos");
                            }
                            else
                            {
                                numero1 = float.Parse(numero1Temporal);
                                numero2 = float.Parse(numero2Temporal);

                                resultado = numero1 - numero2;

                                Console.WriteLine("La resta es: " + resultado);
                            }

                            break;
                        case 3:
                            Console.WriteLine("Ingrese el primer valor:");
                            numero1Temporal = Console.ReadLine();
                            Console.WriteLine("Ingrese el segundo valor:");
                            numero2Temporal = Console.ReadLine();

                            if (!(float.TryParse(numero1Temporal, out y)) || !(float.TryParse(numero2Temporal, out y)))
                            {
                                Console.WriteLine("Los valores ingresados no son incorrectos");
                            }
                            else
                            {
                                numero1 = float.Parse(numero1Temporal);
                                numero2 = float.Parse(numero2Temporal);

                                resultado = numero1 * numero2;

                                Console.WriteLine("La multiplicación es: " + resultado);
                            }

                            break;
                        case 4:
                            Console.WriteLine("Ingrese el primer valor:");
                            numero1Temporal = Console.ReadLine();
                            Console.WriteLine("Ingrese el segundo valor:");
                            numero2Temporal = Console.ReadLine();

                            if (!(float.TryParse(numero1Temporal, out y)) || !(float.TryParse(numero2Temporal, out y)))
                            {
                                Console.WriteLine("Los valores ingresados no son incorrectos");
                            }
                            else
                            {
                                numero1 = float.Parse(numero1Temporal);
                                numero2 = float.Parse(numero2Temporal);

                                if (numero2 == 0)
                                {
                                    Console.WriteLine("No se puede dividir entre 0");
                                }
                                else
                                {
                                    resultado = numero1 / numero2;

                                    Console.WriteLine("La división es: " + resultado);
                                }
                            }

                            break;
                        case 5:


                            break;

                        default:
                            Console.WriteLine("La opción asignada no está definida en el menú.");

                            break;
                    }
                }
                else
                {
                    opcionSeleccionada = 0;

                    Console.WriteLine("El valor ingresado no es correcto");
                }

                if (opcionSeleccionada != 5)
                {
                    Console.ReadLine();
                }

                Console.Clear();
            }
        }
    }
}
