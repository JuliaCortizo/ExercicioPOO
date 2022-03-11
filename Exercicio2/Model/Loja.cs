using System;
using System.Collections.Generic;

namespace Exercicio2.Model
{
    public class Loja
    {
        private string nome;
        private string cnpj;
        private List<Livro> livros;
        private List<Videogame> videoGames;

        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public List<Livro> Livros { get => livros; set => livros = value;}
        public List<Videogame> VideoGames { get => videoGames; set => videoGames = value; }

        public Loja(string nomeL, string cnpjL, List<Livro> livrosL, List<Videogame> videoGamesL){
            Nome = nomeL;
            Cnpj = cnpjL;
            Livros = livrosL;
            VideoGames = videoGamesL;
        }

        double totalItens = 0;

        public void ListaLivros(){
            string retorno = "";
            if(livros.Count == 0){
                Console.WriteLine("A loja não tem livros no seu estoque!");
            }else{
                foreach(Livro livro in livros){
                    retorno += "Título: " + livro.Nome + ", preço: " + livro.Preco.ToString("C2") + ", quantidade: " + livro.Qtd + " em estoque." + "\n";
                    totalItens += livro.Preco * livro.Qtd;
                }
                Console.WriteLine("Estes são os livros disponíveis na loja: " + "\n" + retorno);
            }
        }

        public void ListaVideoGames(){
            string retorno = "";
            if(videoGames.Count == 0){
                Console.WriteLine("A loja não tem video-games no seu estoque!");
            }else{
                foreach(Videogame game in videoGames){
                    retorno += "Video-game: " + game.Modelo + ", preço: " + game.Preco.ToString("C2") + ", quantidade: " + game.Qtd + " em estoque." + "\n";
                    totalItens += game.Preco * game.Qtd;
                }
                Console.WriteLine("Estes são os video-games disponíveis na loja: " + "\n" + retorno);
            }        
        }

        public double calculaPatrimonio(){
            return totalItens;
        }
    
    }
}