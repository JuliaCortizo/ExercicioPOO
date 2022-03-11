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
             Console.WriteLine("Parabéns! O seu guerreiro subiu de nível e ganhou mais pontos de vida e força!");
            Console.WriteLine($"Seus atributos de vida subiram de {Vida} -> {Vida += 30} e Força subiu de {Forca} -> {Forca += 40}");
        }
        
        public override double attack(){
           return base.attack() + (Forca * Level);  
        }
    }
}