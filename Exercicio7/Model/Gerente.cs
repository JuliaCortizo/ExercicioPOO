namespace Exercicio7.Model
{
    public class Gerente : Funcionario
    {
        private double valorBonificacao;

        public double ValorBonificacao { get => valorBonificacao; set => valorBonificacao = value;}
      
        public Gerente(string nomeF, int idadeF, double salarioF) : base(nomeF, idadeF, salarioF)
        {
        
            this.ValorBonificacao = 10000;

        }

        public override double Bonificacao()
        {
            return base.Bonificacao() + ValorBonificacao;
        }
    }
}