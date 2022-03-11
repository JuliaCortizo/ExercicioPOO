using System;
using Exercicio7.Model;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor("Julia", 19, 1600);
            Gerente gerente = new Gerente("Clecio", 30, 6500);
            Supervisor supervisor = new Supervisor("Bira", 31, 5500);

            vendedor.Bonificacao();
            //imprimindo bonificação do vendedor e seus atributos
            Console.WriteLine($"A vendedora {vendedor.Nome} tem {vendedor.Idade} anos e o seu"
            + $" salário é {vendedor.Salario.ToString("C2")}. A sua bonificação é de {vendedor.Bonificacao().ToString("C2")}");

            //imprimindo bonificação do gerente e seus atributos
            Console.WriteLine($"O gerente {gerente.Nome} tem {gerente.Idade} anos e o seu"
            + $" salário é {gerente.Salario.ToString("C2")}. A sua bonificação é de {gerente.Bonificacao().ToString("C2")}");

             //imprimindo bonificação do supervisor e seus atributos
            Console.WriteLine($"O supervisor {supervisor.Nome} tem {supervisor.Idade} anos e o seu"
            + $" salário é {supervisor.Salario.ToString("C2")}. A sua bonificação é de {supervisor.Bonificacao().ToString("C2")}");
        }
    }
}
