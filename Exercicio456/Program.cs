using System;
using System.Collections.Generic;
using Exercicio456.Model;

namespace Exercicio456
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa pessoa1 = new Pessoa("João", 15);
            Pessoa pessoa2 = new Pessoa("Leandro", 21);
            Pessoa pessoa3 = new Pessoa("Paulo", 17);
            Pessoa pessoa4 = new Pessoa("Jessica", 18);

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2); 
            pessoas.Add(pessoa3);
            pessoas.Add(pessoa4);
            
            Pessoa pessoa0 = new Pessoa(pessoas);
            pessoa0.NomePessoaMaisVelha();
            pessoa0.ExclusaoIdadeMenor18();
            pessoa0.ConsultaJessica();

        }
    }
}
