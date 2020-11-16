using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Práctica 1

            int contador = 0;
            int numero = 0;
            string operacion;
            bool contadorCorrecto;

            //Repetir hasta que introduzca s para salir

            do
            {

                //Repeticion del numero 1
                do
                {
                    contadorCorrecto = false;

                    try
                    {
                        Console.Write("Introduce un número: ");
                        contador = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("--> Número incorrecto");
                        contadorCorrecto = true;
                    }

                } while (contadorCorrecto);



                //Repeticion de la operacion

                bool operacionCorrecta;

                do
                {
                    operacionCorrecta = false;

                    Console.Write("Introduce una operación o s para salir: ");
                    operacion = Console.ReadLine();

                    switch (operacion)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                        case "=":
                        case "s":
                            break;
                        default:
                            Console.WriteLine("--> Operación incorrecta");
                            operacionCorrecta = true;
                            break;

                    }

                } while (operacionCorrecta);






                //Repeticion de numero 2

                bool numeroCorrecto;


                do
                {
                    numeroCorrecto = false;

                    try
                    {
                        Console.Write("Introduce un número: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("--> Número incorrecto");
                        numeroCorrecto = true;
                    }

                } while (numeroCorrecto);







                switch (operacion)
                {
                    case "+":
                        contador += numero;

                        break;
                    case "-":
                        contador -= numero;

                        break;
                    case "*":
                        contador *= numero;

                        break;
                    case "/":
                        contador /= numero;

                        break;

                }












            } while (operacion != "s");


            Console.WriteLine("Fin del programa");




        }
    }
}
        }
    }
}
