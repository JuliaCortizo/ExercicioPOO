using System;

namespace prjExercicios.Model
{
    public class Veiculo
    {
        private string marca;
        private string modelo;
        private string placa;
        private string cor;
        private string km;
        private bool isLigado = false;
        private int litrosCombustivel = 0;
        private int velocidade = 0;
        private double preco;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Km{ get => km; set => km = value; }
        public bool IsLigado { get => isLigado; set => isLigado = value; }
        public int LitrosCombustivel { get => litrosCombustivel; set => litrosCombustivel = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public double Preco { get => preco; set => preco = value; }

        public void acelerar(){
            if(isLigado == true){
                velocidade += 20;
                Console.WriteLine($"A velocidade atual do seu veículo é: {velocidade} km/h");                   
            }else{
                Console.WriteLine("O veículo está desligado, por gentileza ligar antes de acelerar!");
            }   
        }

        public void abastecer(int combustivel){
            int limiteTanque = 60;

            if(litrosCombustivel + combustivel <= limiteTanque){
                litrosCombustivel += combustivel;
                Console.WriteLine($"O seu tanque está com {litrosCombustivel} litros");
            }else{
                Console.WriteLine($"O limite do tanque é de: {limiteTanque} e você só pode abastecer mais {limiteTanque - litrosCombustivel} litros!");
            }
        }

        public void frear(){
            velocidade -= 20;   
            Console.WriteLine($"A velocidade atual do seu veículo é: {velocidade} km/h");   
        }

        public void pintar(string corPintada){
            cor = corPintada;
            Console.WriteLine($"A cor do seu carro é: {cor}");            
        }

        
        public void ligar(){
            
            if(isLigado == true){
                Console.WriteLine("Veículo já estava ligado!");   
            }else{
                isLigado = true;
                Console.WriteLine("Veículo ligado agora!");
            }    
        }

        public void desligar(){
            if(isLigado == false){
                Console.WriteLine("Veículo já está desligado!");
            }else{
                if(velocidade > 0){
                    Console.WriteLine("Não é possível desligar o veículo em movimento!");
                }else{
                    isLigado = false;
                    Console.WriteLine("Veículo está desligado agora!");
                }    
            }   
        }

    }
}