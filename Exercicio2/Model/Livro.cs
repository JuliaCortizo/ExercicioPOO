using System;
using Exercicio2.Interfaces;

namespace Exercicio2.Model
{
    public class Livro : Produto, IImposto 
    {
        private string autor;
        private string tema;
        private int qtdPag;

        public Livro(string nomeProd, double precoProd, int qtdProd, string autorL, string temaL, int qtdPagL) : base(nomeProd, precoProd, qtdProd)
        {
            Nome = nomeProd;
            Preco = precoProd;
            Qtd = qtdProd;
            Autor = autorL;
            Tema = temaL;
            QtdPag = qtdPagL;
        }

        public string Autor { get => autor; set => autor = value; }
        public string Tema { get => tema; set => tema = value; }
        public int QtdPag { get => qtdPag; set => qtdPag = value; }

        public double CalculaImposto()
        {
            if(tema == "educativo"){      
                return 0;
            }else{
                return 0.10 * Preco;
            }
        }
    }
}