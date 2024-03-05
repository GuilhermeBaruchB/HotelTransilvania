using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o valor da diaria do hotel Transilvânia? ");
            int Diaria = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos adultos irão na viagem? ");
            int Adulto = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas crianças irão na viagem? ");
            int Crianca = int.Parse(Console.ReadLine());

            int ValorDiaria = Adulto * Diaria + ((Crianca * Diaria) / 2);
            Console.WriteLine("O valor da diaria da sua viagem sera de: R$" + ValorDiaria);

            Console.WriteLine("Quantos dias sera a sua viagem? ");
            int Tempo = int.Parse(Console.ReadLine());

            int ValorViagem = ValorDiaria * Tempo;

            Console.WriteLine("O valor total da sua viagem sera de: R$" + ValorViagem);

            Console.WriteLine("Quantas parcelas você gostaria de fazer? ");
            int Parcelas = int.Parse(Console.ReadLine());

            int ValorParcela = ValorViagem / Parcelas;

            Console.WriteLine("O valor de cada parcela sera de: R$" + ValorParcela);
            int ValorHora = int.Parse(Console.ReadLine());
        }
    }
}
