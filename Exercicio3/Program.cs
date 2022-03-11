using System;
using Exercicio3.Model;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro guerreiro1 = new Guerreiro("Garen", 100, 0, 50, 70, 50, 2);
            Guerreiro guerreiro2 = new Guerreiro("VI", 130, 0, 400, 95, 320, 10);
            Mago mago1 = new Mago("Veigar", 100, 30, 60, 120, 20, 4);
            Mago mago2 = new Mago("Ahri", 100, 470, 260, 160, 40, 15);
            
            mago1.LvlUp();
            mago2.LvlUp();
            guerreiro1.LvlUp();
            guerreiro2.LvlUp();

            Console.WriteLine($"Os atributos de ataque do seu mago {mago1.Nome} é: {mago1.attack()}");
            Console.WriteLine($"Os atributos de ataque do seu mago {mago2.Nome} é: {mago2.attack()}");
            Console.WriteLine($"Os atributos de ataque do seu guerreiro {guerreiro1.Nome} é: {guerreiro1.attack()}");
            Console.WriteLine($"Os atributos de ataque do seu guerreiro {guerreiro2.Nome} é: {guerreiro2.attack()}");
            Console.WriteLine("----------------------------------------------------------------------");
           
            Personagem personagem = new Personagem();
            personagem.MostrarQtdPersonagem();
        }
    }
}
