namespace Exercicio7.Model
{
    public class Supervisor : Funcionario
    {
        private double valorBonificacao;

        public double ValorBonificacao { get => valorBonificacao; set => valorBonificacao = value; }
        public Supervisor(string nomeF, int idadeF, double salarioF) : base(nomeF, idadeF, salarioF)
        {
          
            this.ValorBonificacao = 5000;
        }

        public override double Bonificacao()
        {
            return base.Bonificacao() + ValorBonificacao;
        }
    }
}