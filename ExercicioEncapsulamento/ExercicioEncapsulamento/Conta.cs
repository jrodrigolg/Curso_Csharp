using System;


namespace ExercicioEncapsulamento {
    internal class Conta {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get;private set; }

        public Conta(int numero, string nome, double saldo) {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }
        public void Saque(double valor) { 
            Saldo -= (valor+5);
        }
        public override string ToString() {
            return $"Conta: {Numero}, Titular: {Nome}, Saldo: {Saldo:F2}";
        }

    }
}
