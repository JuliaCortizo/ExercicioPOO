using System;
using prjExercicios.Model;

namespace prjExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Veiculo veiculo = new Veiculo();
            do{
                Console.WriteLine("Por gentileza, escolha a ação que deseja fazer com seu veículo: " 
                + "\n" + "1 - Ligar"
                + "\n" + "2 - Acelerar"
                + "\n" + "3 - Frear"
                + "\n" + "4 - Abastecer"
                + "\n" + "5 - Pintar"
                + "\n" + "6 - Desligar"
                + "\n" + "0 - Sair da aplicação");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch(opcao){
                case 1: 
                    veiculo.ligar();
                break;
                case 2:
                    veiculo.acelerar();
                break;
                case 3: 
                    if(veiculo.Velocidade == 0){
                        Console.WriteLine("O carro está parado, não é possível frear!");
                    }else{
                        veiculo.frear();
                    }     
                break;
                case 4:
                    Console.WriteLine("Quantos litros deseja abastecer?");
                    int combustivel = Convert.ToInt32(Console.ReadLine());
                    veiculo.abastecer(combustivel);
                break;
                case 5:
                    Console.WriteLine("Qual a cor que deseja pintar?");
                    string cor = Console.ReadLine();
                    veiculo.pintar(cor);
                break;
                case 6:
                    veiculo.desligar();
                    break;    
                case 0:
                    Console.WriteLine("Saindo da aplicação...aperte qualquer tecla!");   
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;    
                }

            }while(opcao != 0);

            Console.ReadKey();
        }
    }
}
