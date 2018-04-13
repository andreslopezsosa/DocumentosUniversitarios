using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Andres Lopez Sosa 14-SISN-1-048 seccion 908

            /* PROGRAMA PARA HACER OPERACIONES CON DOS NUMEROS */

            Console.WriteLine("Operaciones aritmeticas soportadas:");
            Console.WriteLine();
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicacion");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Exponenciacion");
            Console.WriteLine();
            Console.Write("Ingrese el codigo de la operacion deseada: ");
            int operacion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Ingrese el primer numero: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            float numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (operacion)
            {
                case 1:
                    float Sum = numero1 + numero2;
                    Console.WriteLine("Resultado: "+ Sum);
                    break;
                case 2:
                    float Res = numero1 - numero2;
                    Console.WriteLine("Resultado: " + Res);
                    break;
                case 3:
                    float Mul = numero1 * numero2;
                    Console.WriteLine("Resultado: " + Mul);
                    break;
                case 4:
                    float Div = numero1 / numero2;
                    Console.WriteLine("Resultado: " + Div);
                    break;
                case 5:
                    int i;
                    float Exp = numero1;
                    for (i = 1; i < numero2; i++)
                    {
                        Exp = Exp * numero1;
                    }
                    Console.WriteLine("Resultado: " + Exp);
                    break;                
            }

            Console.WriteLine();
            Console.WriteLine("Andres Lopez Sosa 14-SISN-1-048 Seccion 0908");
            Console.ReadKey();
        }
    }
}
