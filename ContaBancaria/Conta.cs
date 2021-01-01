using System;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public string Numero { get; private set; }
        private string _nome;
        public double Saldo { get; private set; }
        public Conta(string numero, string nome)
        {
            Numero = numero;
            _nome = nome;
        }
        public Conta(string numero, string nome, double valorInicial) : this(numero, nome)
        {
            Saldo = valorInicial;
        }

        public string Nome
        {
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
            get { return _nome; }
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo -= saque + 5;
        }

        public override string ToString()
        {
            return ("Conta " + Numero + ", Titular: " + Nome + ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
