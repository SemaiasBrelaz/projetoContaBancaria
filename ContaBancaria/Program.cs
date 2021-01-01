using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Entre com o numero da Conta: ");
            string numero = Console.ReadLine();
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (S/N)? ");
            char condi = Char.Parse(Console.ReadLine());
            if (condi == 's' || condi == 'S')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoInicial = Double.Parse(Console.ReadLine());
                conta = new Conta(numero, nome, depositoInicial);
                
            }
            else
            {
                conta = new Conta(numero, nome);
            }
            Console.WriteLine("Dados da Conta Atualiado: ");
            Console.WriteLine(conta);
            Console.Write("Entre com o valor para deposito: ");
            double Deposito = double.Parse(Console.ReadLine());
            conta.Deposito(Deposito);
            Console.WriteLine(conta);

            Console.Write("Entre com o valor para Saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine(conta);
            Console.WriteLine("Fim");

        }
    }
}
