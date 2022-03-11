using System;
using System.Collections.Generic;
using Exercicio2.Model;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            Videogame ps4 = new Videogame("PS4", 1800, 100, "Sony", "Slim", false);
            Videogame ps4Usado = new Videogame("PS4", 1000, 7, "Sony", "Slim", true);
            Videogame xbox = new Videogame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<Videogame> games = new List<Videogame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "12345678", livros, games);

            
            double impostoL2 = l2.CalculaImposto();
            double impostoL3 = l3.CalculaImposto();

            if(impostoL2 == 0)
            {
                Console.WriteLine($"Livro educativo não tem imposto: {l2.Nome}");
            }else{
                Console.WriteLine($"O valor dos impostos do livro {l2.Nome} é de {impostoL2.ToString("N2")}");
            } 

            if(impostoL3 == 0)
            {
                Console.WriteLine($"Livro educativo não tem imposto: {l3.Nome}");
            }else{
                Console.WriteLine($"O valor dos impostos do livro {l3.Nome} é de {impostoL3.ToString("N2")}");
            } 

            Console.WriteLine($"Imposto do {ps4Usado.Nome} {ps4Usado.Modelo} usado é de {ps4Usado.CalculaImposto().ToString("N2")}");
            Console.WriteLine($"Imposto do {ps4.Nome} {ps4.Modelo} é de {ps4.CalculaImposto().ToString("N2")}");                  
            Console.WriteLine("------------------------------------------------------------------");
            americanas.ListaLivros();
            Console.WriteLine("------------------------------------------------------------------");
            americanas.ListaVideoGames();
            Console.WriteLine("------------------------------------------------------------------");
            
            Console.WriteLine("O patrimônio da loja é de " + americanas.calculaPatrimonio().ToString("C2"));
            Console.ReadKey();
         
        }
    }
}
