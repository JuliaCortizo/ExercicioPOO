using System;

namespace Exercicio3.Model
{
    public class Personagem
    {
        private static int qtdPersonagem;
        private string nome;
        private int vida;
        private int mana;
        private float xp;
        private int inteligencia;
        private int forca;
        private int level;

        public int QtdPersonagem { get => qtdPersonagem; set => qtdPersonagem = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Vida { get => vida; set => vida = value; }
        public int Mana { get => mana; set => mana = value; }
        public float Xp { get => xp; set => xp = value; }
        public int Inteligencia { get => inteligencia; set => inteligencia = value; }
        public int Forca { get => forca; set => forca = value; }
        public int Level { get => level; set => level = value; }


        public Personagem(string nomeP, int vidaP, int manaP, float xpP, int inteligenciaP, int forcaP, int levelP){
            this.QtdPersonagem += 1; 
            this.Nome = nomeP;
            this.Vida = vidaP;
            this.Mana = manaP;
            this.Xp = xpP;
            this.Inteligencia = inteligenciaP;
            this.Forca = forcaP;
            this.Level = levelP;
            
        }

        public virtual void LvlUp(){

        }
        public virtual double attack(){
            Random aleatorio = new Random();
            return aleatorio.Next(0, 300);
        }

        public void MostrarQtdPersonagem(){
            Console.WriteLine($"A quantidade de personagens criadas no jogo é: " + QtdPersonagem);
        }
        
    }
}