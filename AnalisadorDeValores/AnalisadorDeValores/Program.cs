using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, num, soma = 0, divPorCinco = 0, nulo = 0, cont_par = 0;
            double media;



            Console.WriteLine("Digite um numero para o limite da condição: ");
            n = Convert.ToInt16(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Escolha um numero: ");
                num = Convert.ToInt16(Console.ReadLine());

                soma = soma + num;

                if (num % 5 == 0)
                {
                    divPorCinco++;
                }

                if (num == 0)
                {
                    nulo++;

                }

                if (num % 2 == 0)
                {
                    cont_par = cont_par + num;

                }




            }

            media = soma / n;

            Console.WriteLine("========================================================");

            Console.WriteLine($"A soma é: {soma}");

            Console.WriteLine($"A media é: {media}");

            Console.WriteLine($"Quantidade de divisíveis por cinco: {divPorCinco} ");

            Console.WriteLine($"Quantidade de numeros nulos: {nulo}");

            Console.WriteLine($"A soma dos números pares é: {cont_par}");


            Console.ReadLine();






        }
    }
}
