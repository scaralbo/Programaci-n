using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            // ---------------------------------------
            // Óscar Martín Albo
            // Curso DAM
            // Modalidad Presencial
            // Práctica nº 1
            // ---------------------------------------
            
            
            string operacion;
            bool numCorrecto;
            int resultado = 0;
            int numero = 0;


            //Repetir hasta que introduzca s para salir

            do
            {

                    //Pedir número (contador)

                do
                {
                    numCorrecto = false;
                    try
                    {

                        Console.Write("Introduce un número: ");
                        resultado = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("--> Número incorrecto");
                        numCorrecto = true;
                    }

                } while (numCorrecto);

                //Repetir operación y número siguiente

                do
                {

                    //Pedir la operación

                    bool operacionCorrecta;
                    do
                    {
                        operacionCorrecta = false;

                        Console.Write("Introduce una operación: ");
                        operacion = Console.ReadLine();

                        //if (operacion != "+" && )

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


                    //Introducir siguiente número


                    if (operacion!="=" && operacion!="s")
                    {
          

                        do
                        {
                            numCorrecto = false;
                            try
                            {

                                Console.Write("Introduce un número: ");
                                numero = Convert.ToInt32(Console.ReadLine());

                            }
                            catch (Exception)
                            {
                                Console.WriteLine("--> Número incorrecto");
                                numCorrecto = true;
                            }

                        } while (numCorrecto);


                        //Hacer el cálculo

                        switch (operacion)
                        {
                            case "+":
                                resultado += numero;
                                break;
                            case "-":
                                resultado -= numero;
                                break;
                            case "*":
                                resultado *= numero;
                                break;
                            case "/":
                                resultado /= numero;
                                break;
                        }


                    }


                } while (operacion != "=" && operacion != "s");





                


                //Sacar el valor después de =

                
                if (operacion == "=")
                {
                    
                    Console.WriteLine("El resultado es {0}",resultado);
                }

                

                if (operacion == "s")
                {
                    Console.WriteLine("El resultado es {0}",resultado);
                    Console.WriteLine("\nFIN DEL PROGRAMA");
                }

                resultado = 0;
                Console.WriteLine();



            } while (operacion != "s");





        }
    }
}




            


            
            







