using System;
using Exercicio2.Interfaces;

namespace Exercicio2.Model
{
    public class Videogame : Produto, IImposto
    {
        private string marca;
        private string modelo;
        private bool isUsado;

        public Videogame(string nomeProd, double precoProd, int qtdProd, string marcaV, string modeloV, bool isUsadoV) : base(nomeProd, precoProd, qtdProd)
        {
            Nome = nomeProd;
            Preco = precoProd;
            Qtd = qtdProd;
            Marca = marcaV;
            Modelo = modeloV;
            IsUsado = isUsadoV;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public bool IsUsado { get => isUsado; set => isUsado = value; }

        public double CalculaImposto()
        {
            if(isUsado == true){
                return 0.25 * Preco;
            }else{
                return 0.45 * Preco;          
            }
        }
    }
}