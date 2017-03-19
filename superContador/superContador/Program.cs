using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superContador
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha=0;

            int j = 0;
            while (true) { 


            Console.WriteLine("=======================");
            Console.WriteLine("|     M E N U         |");
            Console.WriteLine("=======================");
            Console.WriteLine("|   [1] De 1 a 10     |");
            Console.WriteLine("|   [2] De 10 a 1     |");
            Console.WriteLine("|   [3] Sair          |");         

                Console.WriteLine("Escolha um numero do menu: ");
                escolha = Convert.ToInt16(Console.ReadLine());

                if (escolha == 3)
                {
                    Console.WriteLine("SAINDO...");
                    break;
                }

                if (escolha == 1)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write($"{i}.. ");

                    }
                }


                else if (escolha == 2)
                {
                    for (int i = 10; i > 0; i--)
                    {
                        Console.Write($"{i}.. ");
                    }
                }
                
                
            j++;
            
        }



        Console.ReadLine();
        }
    }
}
