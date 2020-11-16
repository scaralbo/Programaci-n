using System;
using System.Diagnostics.CodeAnalysis;

namespace EjerciciosTodos3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ej 4.1.1.1
            /*
            int[] num = new int[4];
            double media;
            

            Console.Write("numero 1: ");
            num[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("numero 2: ");
            num[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("numero 3: ");
            num[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("numero 4: ");
            num[3] = Convert.ToInt32(Console.ReadLine());

            
            media = (num[0] + num[1] + num[2] + num[3]) / 4;
            Console.WriteLine("media: {0} ", media);


            //Ej 4.1.1.2

            float[] num = new float[5];
            Console.Write("n1: ");
            num[0]= Convert.ToSingle(Console.ReadLine());
            Console.Write("n2: ");
            num[1] = Convert.ToSingle(Console.ReadLine());
            Console.Write("n3: ");
            num[2] = Convert.ToSingle(Console.ReadLine());
            Console.Write("n4: ");
            num[3] = Convert.ToSingle(Console.ReadLine());
            Console.Write("n5: ");
            num[4] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("{0} {1} {2} {3} {4} ",num[4],num[3],num[2],num[1],num[0]);

            //Ej 4.1.2.1

            int[] diasmes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.Write("un dia: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("un mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());

            int total;
            total = dia + diasmes[mes];
            Console.WriteLine("dia {0} + mes {1} = total: {2} ",dia,diasmes[mes-1], total);
            

            int[] diasmes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.Write("un mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            mes--;
            try
            {
                Console.WriteLine("dias mes: {0}", diasmes[mes]);

            }
            catch (Exception)
            {
                Console.WriteLine("mes desconocido");
                
            }


            //Ej 4.1.3.1

            int[] num = new int[6];
            
            Console.Write("num 1: ");
            num[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("num 2: ");
            num[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("num 3: ");
            num[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("num 4: ");
            num[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("num 5: ");
            num[4] = Convert.ToInt32(Console.ReadLine());
            Console.Write("num 6: ");
            num[5] = Convert.ToInt32(Console.ReadLine());

            

            for (int i = 5; i >=0; i--)
            {

                Console.Write("{0} ", num[i]);
            }

            //Ej 4.1.3.2

            Console.WriteLine("cuantos num vas a introducir ");
            int total = Convert.ToInt32(Console.ReadLine());

            double suma=0;
            double media=0;
            int[] num = new int[total];

            for (int i = 0; i < total; i++)
            {
                Console.Write("num {0}: ",i+1);
                num[i] = Convert.ToInt32(Console.ReadLine());
                suma += num[i];
            }
                media = suma / total;

                Console.WriteLine("media {0} ", media);

            //Ej 4.1.3.3

            Console.Write("Introduce una cantidad de números: ");
            int total = Convert.ToInt32(Console.ReadLine());

            double[] num = new double[total];
            double suma = 0;
            double media;
            for (int i = 0; i < total; i++)
            {
                Console.Write("Número {0}: ", i + 1);
                num[i] = Convert.ToDouble(Console.ReadLine());
                suma += num[i];

            }
            media = suma / total;
            Console.WriteLine("la media es {0} ", media);

            Console.Write("Los números: ");
            for (int i = 0; i < total; i++)
            {
                if (num[i]>media)
                {
                    Console.Write("{0} ", num[i]);
                }
                
            }
            Console.WriteLine(",están por encima de la media");

            //Ej 4.1.3.4

            int[] diasmeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes,dia;
            int diasano = 0;
            
            Console.Write("Indica un mes del 1 al 12: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indica un día: ");
            dia = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <=mes; i++)
            {
                diasano +=diasmeses[i];
                
            }
            if (dia < diasmeses[mes])
            {
                diasano += dia - diasmeses[mes];
            }
            Console.WriteLine("dias que lleva el año: {0}",diasano);
            
            //Ej 4.1.3.5

            Console.Write("Día del 1 al 31: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mes del 1 al 12: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            mes--;

            int[] diasmeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int diasTotal = 0;
            for (int i = mes; i < diasmeses.Length-1 ; i++)
            {
                diasTotal += diasmeses[i];
                
            }
            if (dia<diasmeses[mes])
            {
                diasTotal += diasmeses[mes] - dia;
            }
            Console.WriteLine("dias totales q quedan: {0} ", diasTotal);
            
            //otra forma como la del ejercicio anterior.

            Console.Write("Día del 1 al 31: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mes del 1 al 12: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            mes--;

            int[] diasmeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int diasTotal = 0;

            for (int i = 0; i <= mes; i++)
            {
                diasTotal += diasmeses[i];
            }
            if (dia<diasmeses[mes])
            {
                diasTotal += dia - diasmeses[mes];
            }

            int diasFaltan;
            diasFaltan = 365 - diasTotal;
            Console.WriteLine("días q faltan: {0}", diasFaltan);


            //Ej 4.1.3.6 (bool)


            string[] nombre1 = new string[2];
            string nombre2;
            bool nombre_buscar = false;
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Introduce el nombre numero {0}: ",i+1);
                nombre1[i] = Console.ReadLine();

            }
            
            do
            {
                Console.WriteLine("Teclea otro nombre: ");
                nombre2 = Console.ReadLine();

                for (int i = 0; i < 2; i++)
                {
                    if (nombre2==nombre1[i])
                    {
                        Console.WriteLine("Nombre introducido está repetido");
                        nombre_buscar = true;
                        break;
                    }
                }
                if (nombre_buscar==false && nombre2!="fin")
                {
                    Console.WriteLine("Nombre introducido no se encuentra dentro");
                }
                nombre_buscar = false;


                
            } while (nombre2!="fin");


            
            
            //Ej 4.1.3.7

            string[] nombre = new string[5];
            int i;

            for ( i = 0; i < 5; i++)
            {
                Console.Write("Introduce un nombre {0}: ",i+1);
                nombre[i] = Console.ReadLine();

                if (nombre[i] == "")
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Lista de Nombres:");
            for (int j = 0; j < i; j++)
            {
                
                    Console.WriteLine("Nombre {0}: {1}",j+1, nombre[j]);
                
            }
            Console.WriteLine();


            //Ej 4.1.3.8

            int[] vector = new int[3];

            Console.WriteLine("Introduce los valores de un vector de 3 componentes");

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Introduce número {0}: ", i + 1);
                vector[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("El vector es: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0} ", vector[i]);

            }
            Console.WriteLine();
            double suma_cuadrados=0;
            for (int i = 0; i < vector.Length; i++)
            {
                suma_cuadrados += Math.Pow(vector[i],2);

            }
            Console.WriteLine("la suma de los cuadrados del vector es {0}", suma_cuadrados);
            
            
            double modulo=0;
            modulo= Math.Sqrt(suma_cuadrados);
            Console.WriteLine("el módulo es: {0}", modulo);*/



            //Ej 4.4.3.9

            int[] v1 = new int[3];
            int[] v2 = new int[3];

            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write("Número {0} v1: ",i+1 ,v1[i]);
                v1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write("Número {0} v2: ", i + 1, v2[i]);
                v2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma =0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("la suma del vector {0}: {1} ",i+1, v1[i] + v2[i]);
                suma += v1[i] + v2[i];
            }
            Console.WriteLine("La suma de los vectores {0} ", suma);

            /*
            int[] vector1 = new int[3];
            int[] vector2 = new int[3];
            int[] vector_suma = new int[3];
            
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Introduce el vector {0}", i + 1);

                for(int j=0;j<3;j++)
                {
                    Console.Write(" componente {0}: ", j + 1);

                    if (i == 0)
                        vector1[j] = Convert.ToInt32(Console.ReadLine());
                    else
                        vector2[j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("La suma de ambos vectores es: ");

            for (int i = 0; i < 3; i++)
            {
                vector_suma[i] = vector1[i] + vector2[i];
                Console.Write("x{0}+y{0}={1} ", i + 1, vector_suma[i]);
            }*/























        }
    }
}
