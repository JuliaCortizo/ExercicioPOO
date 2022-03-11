using Exercicio2.Interfaces;

namespace Exercicio2.Model
{
    public abstract class Produto 
    {
        private string nome;
        private double preco;

        private int qtd;

        //Propriedades 
        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Qtd { get => qtd; set => qtd = value; }

        //Construtor verificar se tem que inicializar aqui, pq não pode instanciar
        public Produto(string nomeProd, double precoProd, int qtdProd){
            
        }
        
    }
}