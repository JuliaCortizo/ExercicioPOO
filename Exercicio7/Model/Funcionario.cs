namespace Exercicio7.Model
{
    public class Funcionario
    {
        private string nome;
        private int idade;
        private double salario;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Salario { get => salario; set => salario = value; } 

        public Funcionario(string nomeF, int idadeF, double salarioF){
            this.Nome = nomeF;
            this.Idade = idadeF;
            this.Salario = salarioF;
        }

        public virtual double Bonificacao(){
            return Salario;
        }
    }
}