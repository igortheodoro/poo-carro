using System;

namespace Carro
{
    class Banco
    {
        private Carro[] Vet;
        private int Index = 0;

        public Banco(int Tamanho){
          Vet = new Carro[Tamanho];
        }

        public void Inserir(Carro Obj){
          Vet[Index] = Obj;
          Index++;
        }

        public void getCarros(){
          for(int i = 0; i < Vet.Length; i++)
            System.Console.WriteLine("Marca: {0} \n Placa: {1} \n Modelo: {2} \n Portas: {3} \n Tipo: {4}", Vet[i].getMarca(), Vet[i].getPlaca(), Vet[i].getModelo(), Vet[i].getPortas(), Vet[i].getTipo());
        }

        public void getPlacaKia(){
          for(int i = 0; i < Vet.Length; i++)
            if(Vet[i].getMarca() == 6 && Vet[i].getModelo().ToUpper() == "STINGER")
              System.Console.WriteLine(Vet[i].getPlaca());
        }

        public void getPlacaFiat(){
          for(int i = 0; i < Vet.Length; i++)
            if(Vet[i].getMarca() == 2 && Vet[i].getPortas() == 4)
              System.Console.WriteLine("Placa: {0}, Modelo: {1}", Vet[i].getPlaca(), Vet[i].getModelo());
        }

        public int getGM(){
          int cont = 0;
            for(int i = 0; i < Vet.Length; i++)
              if(Vet[i].getMarca() == 4)
                cont++;

          return cont;
        }

        public int getVeloster(){
          int cont = 0;

          for(int i = 0; i < Vet.Length; i++)
            if(Vet[i].getModelo().ToUpper() == "VELOSTER TURBO")
                cont++;

          return cont;
        }

        public string getMenosCarros(){
          int[] vetorMarca = new int[7]{0,0,0,0,0,0,0};
          string[] marcas = new string[7]{"", "Ford", "Fiat", "VW", "GM", "Hyundai", "Kia" };

          for(int i = 0; i < Vet.Length; i++){
            for(int j = 1; j <= 6; j++){
              if(Vet[i].getMarca() == j)
              vetorMarca[j]++;
            }
          }
          
          int menor = 0, posicao = 0;

          for(int i = 1; i <= 6; i++){
            if(i==1){
              menor = vetorMarca[i];
              posicao = i;
            }

            if(vetorMarca[i] < menor){
              menor = vetorMarca[i];
              posicao = i;
            }
          }

          return marcas[posicao];
        }

        public int getPicapes(){
          int cont = 0;
          for(int i = 0; i < Vet.Length; i++)
            if(Vet[i].getMarca() == 2 && Vet[i].getTipo().ToUpper() == "PICAPE")
              cont++;
            
          return cont;
        }


    }
}
