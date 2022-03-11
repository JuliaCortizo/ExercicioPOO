using System;
using System.Collections.Generic;

namespace Exercicio3.Model
{
    public class Mago : Personagem
    {
        private List<string> magias;
        public Mago(string nomeP, int vidaP, int manaP, float xpP, int inteligenciaP, int forcaP, int levelP) : base(nomeP, vidaP, manaP, xpP, inteligenciaP, forcaP, levelP)
        {
            

        }

        public List<string> Magias { get => magias; set => magias = value; }

        public override double attack()
        {
            return base.attack() + (Inteligencia * Level);
        }

        public override void LvlUp()
        {
            Console.WriteLine("Parabéns! O seu mago subiu de nível e ganhou mais pontos de inteligência e mana!");
            Console.WriteLine($"Seus atributos de mana subiram de {Mana} -> {Mana += 30} e Inteligencia subiu de {Inteligencia} -> {Inteligencia += 40}");
        }
    }    
      
      
}
