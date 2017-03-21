using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seletorDePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo, corCabelo, sair;
            int idade, i = 0, contMaiorDezoito, contMasc = 0, contFem = 0;


            while (true)
            {

                Console.WriteLine("===========================");
                Console.WriteLine("Seletor de Pessoas");
                Console.WriteLine("===========================");

                Console.WriteLine("Qual o sexo? [M/F]");  //sexo
                sexo = Console.ReadLine();


                Console.WriteLine("Qual a idade? ");      //idade
                idade = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Qual a cor do cabelo? "); //cor do cabelo
                Console.WriteLine("--------------------------");
                Console.WriteLine("[1] Preto");
                Console.WriteLine("[2] Castanho");
                Console.WriteLine("[3] Loiro");
                Console.WriteLine("[4] Ruivo");
                corCabelo = Console.ReadLine();

                if (idade > 18 && sexo == "M" && corCabelo == "2")
                {
                    contMasc = contMasc + 1;
                }
                else if (sexo == "F" && idade >= 25 && idade <= 30 && corCabelo == "3")
                {
                    contFem = contFem + 1;
                }

                    Console.WriteLine("Quer continuar? [S/N]");
                sair = Console.ReadLine();   
                
                if (sair == "N")
                {
                    Console.WriteLine($"Total de homens com mais de 18 e cabelos castanhos: {contMasc}");
                    Console.WriteLine($"Total de mulheres entre 25 e 30 e cabelos loiros: {contFem}");
                    break;

                }    
               
            }

            Console.ReadLine();
        }

          
    }
}
