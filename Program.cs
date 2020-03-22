using System;

namespace Carro
{
    class Program
    {
         static void gerarCarro(int tamanho, Banco bancoDados){

            int marca, portas;
            string placa, modelo, tipo;
            string letras = "AEIOUBCDFGHJKLMNPQRSTVWXYZ";
            string numeros = "0123456789";
            string[] modelos = new String[5]{"Gol", "Stinger", "Veloster Turbo", "Uno", "Siena"};
            string[] tipos = new string[5]{"Esportivo", "Hatch", "Sedã", "Picape", "Suv"};
            Carro obj;
            
            for(int i = 0; i < tamanho; i++){

                Random random = new Random();
                
                 marca = random.Next(1,7);

                 portas = random.Next(1,5);

                 placa = "" + letras[random.Next(0,26)] 
                 + letras[random.Next(0,26)] 
                 + letras[random.Next(0,26)] 
                 + numeros[random.Next(0,9)] 
                 + numeros[random.Next(0,9)] 
                 + numeros[random.Next(0,9)];

                 modelo = modelos[random.Next(0,5)];

                 tipo = tipos[random.Next(0,5)];

                 obj = new Carro(marca, portas, placa, modelo, tipo);
                 bancoDados.Inserir(obj);
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a quantidade de carros: ");
            int quantidade = int.Parse(Console.ReadLine());

            while(quantidade > 300){
                System.Console.WriteLine("Digite a quantidade de carros: ");
                quantidade = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Marcas: (1) - Ford; (2) - Fiat; (3) - VW; (4) - GM; (5) - Hyundai; (6) - Kia");

            Banco bancoCarros = new Banco(quantidade);

            gerarCarro(quantidade, bancoCarros);

            // Imprimir todos os carros do sistema
            bancoCarros.getCarros(); 

            // Imprimir a placa dos carros modelo Singer
            System.Console.WriteLine("Placas dos carros modelo Stinger da KIA: ");
            bancoCarros.getPlacaKia();

            // Imprimir modelo e placa dos Fiat quatro portas
            System.Console.WriteLine("Modelo e placa Fiat 4 portas: ");
            bancoCarros.getPlacaFiat();

            // Quantidade carros GM
            System.Console.WriteLine("Temos {0} carros da marca GM.", bancoCarros.getGM());

            // Quantidade Veloster Turbo
            System.Console.WriteLine("Há {0} Veloster Turbo.", bancoCarros.getVeloster());

            // Marca com menos carros cadastrados
            System.Console.WriteLine("{0} é a marca com menos carros cadastrados.", bancoCarros.getMenosCarros());

            // Picapes Ford
            System.Console.WriteLine("Há {0} Picapes da Ford", bancoCarros.getPicapes());
        }
    }
}
