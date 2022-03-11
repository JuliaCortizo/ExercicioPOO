using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio456.Model
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private List<Pessoa> pessoas;
      
        public Pessoa(string nomeP, int idadeP)
        {
            this.Nome = nomeP;
            this.Idade = idadeP;         
        }
        public Pessoa (List<Pessoa> pessoasL){
            this.Pessoas = pessoasL;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public List<Pessoa> Pessoas { get => pessoas; set => pessoas = value; }

        public void NomePessoaMaisVelha(){
            
            if (Pessoas.Count > 0){
                int maiorIdade = 0;
                string nomeMaisVelha = "";
                foreach(Pessoa p in Pessoas){
                    if(p.Idade > maiorIdade){
                        maiorIdade = Convert.ToInt32(p.Idade);  
                        nomeMaisVelha = p.Nome;     
                                       
                    }   
                }
                Console.WriteLine($"O nome da pessoa mais velha é: {nomeMaisVelha}");    
            }else{
                Console.WriteLine("Esta lista não contém itens");
            }
    
        }

        public void ExclusaoIdadeMenor18(){
            int qtdPessoasLista = Pessoas.Count;
            //Remove todas as pessoas da lista onde a idade é menor que 18 anos
            Pessoas.RemoveAll(p => p.Idade < 18);   
            Console.WriteLine("Quantidade total de pessoas na lista antes da exclusão: " + qtdPessoasLista + "\n"); 
            Console.WriteLine("Quantidade de pessoas com idade maior ou igual a 18 anos: " + Pessoas.Count.ToString() 
            + " tais quais: " + "\n"); 
            foreach(Pessoa p in Pessoas){
                Console.WriteLine(p.Nome);
            } 
        }

        public void ConsultaJessica(){
           foreach(Pessoa p in Pessoas){
               if(p.Nome == "Jessica"){
                   Console.WriteLine("A idade de jéssica é: " + p.Idade);
               }
           }
        }

 
    }
}