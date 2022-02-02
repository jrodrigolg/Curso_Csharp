using System;
using System.Globalization;

namespace ExercicioPoo2 {
    class Produto {
        private string _nome ;
        public double Valor { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() {

        }
        public Produto(string nome, double valor, int quantidade) {
            _nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }
        
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        
        public double ValorTotalEmEstoque() {
            return Valor * Quantidade;
        }
        public override string ToString() {

            return $"{_nome}, $ " +
                   $"{Valor.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"{Quantidade} unidades, Total: $ " +
                   $"{ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)} ";

        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
    }
}
