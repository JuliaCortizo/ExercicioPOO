namespace Exercicio7.Model
{
    public class Vendedor : Funcionario
    {
        private double valorBonificacao;

        public double ValorBonificacao{ get => valorBonificacao; set => valorBonificacao = value; }
        public Vendedor(string nomeF, int idadeF, double salarioF) : base(nomeF, idadeF, salarioF)
        {
        
            this.ValorBonificacao = 3000;
        }

        public override double Bonificacao()
        {
            return base.Bonificacao() + ValorBonificacao;
        }
    }
}