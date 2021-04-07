using System;

namespace Ejercicio1
{
    class Program
    {
        public void retornar(ref int valor1, ref int valor2, ref int valor3, ref int valor4, ref int valor5)
        {
            int temp = valor1;
            valor1 = valor2;
            valor2 = valor3;
            valor3 = valor4;
            valor4 = valor5;
            valor5 = temp;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int v1 = 5;
            int v2 = 13;
            int v3 = 7;
            int v4 = 14;
            int v5 = 21;
            p.retornar(valor1: ref v1, valor2: ref v2, valor3: ref v3, valor4: ref v4, valor5: ref v5);

            Console.WriteLine("los valores iniciales son: {0} - {1} - {2} - {3} -{4}", v1, v2, v3, v4, v5);





            Console.ReadKey();
        }
    }
}
