using System;
using System.Collections.Generic;

namespace Exercicio3.Model
{
    public class Guerreiro : Personagem
    {
        private List<String> habilidades;
        public Guerreiro(string nomeP, int vidaP, int manaP, float xpP, int inteligenciaP, int forcaP, int levelP) : base(nomeP, vidaP, manaP, xpP, inteligenciaP, forcaP, levelP)
        {
        }

        public List<string> Habilidades { get => habilidades; set => habilidades = value; }

        public override void LvlUp()
        {
            Level += 1;
            Xp += 20;
            Console.WriteLine($"Parabéns! O seu guerreiro subiu para o nível {Level} e ganhou mais pontos de vida e força!");
            Console.WriteLine($"Seus atributos de vida subiram de {Vida} -> {Vida += 30} e Força subiu de {Forca} -> {Forca += 40}");
            Console.WriteLine($"Quantidade de XP: " + Xp);
            Console.WriteLine("----------------------------------------------------------------------");
        }
        
        public override double attack(){
           return base.attack() + (Forca * Level);  
        }
    }
}