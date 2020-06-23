using System;
using System.Collections.Generic;

namespace Aula23Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add( new Produto(1, "Iphone", 4000f ));
            produtos.Add( new Produto(2, "S9", 2000f ));
            produtos.Add( new Produto(3, "Galaxy", 1700f ));
            produtos.Add( new Produto(4, "Nokia", 1000f ));

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach(Produto p in produtos){
                System.Console.WriteLine($"Informações do produto \nNome: {p.Nome} \nPreço: {p.Preco}");
            }

            System.Console.WriteLine("_______________________________");
            System.Console.WriteLine("                               ");

            List<Cartao> cartoes = new List<Cartao>();

            cartoes.Add( new Cartao("Fernando","2343838228", "Visa", "5/1/2008", 643));
            cartoes.Add( new Cartao("Luísa","453833454", "MasterCard", "06/06/2029", 434));
            cartoes.Add( new Cartao("Ana Claudia", "6252362328", "Elo", "07/07/2029", 873 ));
            cartoes.Add( new Cartao("Rafael", "80937282399", "Hipercard", "08/08/2029", 839 ));
            
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            foreach(Cartao t in cartoes){
                System.Console.WriteLine($"Informações do cartão \nTitular: {t.Titular} \nNúmero: {t.Numero} \nBandeira: {t.Bandeira} \nVencimento: {t.Vencimento} \nCVV: {t.CVV}");
            }
        }
    }
}
