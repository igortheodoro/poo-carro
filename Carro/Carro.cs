using System;

namespace Carro
{
    class Carro
    {
        private int Marca, Portas;
        private string Placa, Modelo, Tipo;

        public Carro(int Marca, int Portas, string Placa, string Modelo, string Tipo){
            this.Marca = Marca;
            this.Portas = Portas;
            this.Placa = Placa;
            this.Modelo = Modelo;
            this.Tipo = Tipo;
        }
        public string getPlaca(){
            return Placa;
        }

        public int getMarca(){
            return Marca;
        }

        public string getModelo(){
            return Modelo;
        }

        public int getPortas(){
            return Portas;
        }

        public string getTipo(){
            return Tipo;
        }
    }
}
