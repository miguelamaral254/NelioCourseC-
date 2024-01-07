using System;
using System.Globalization;

namespace Banco
{
    class Conta
    {
        public int NumeroConta { get; protected set; }
        public string Titular { get; set; }
        public double DepInicial { get; set; }

        public double Saldo { get; private set; }

        public Conta(int numeroConta, string titular, double depInicial)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            AdicionarSaldo(depInicial);

        }

        public void AdicionarSaldo(double valor)
        {
            Saldo += valor;
        }
        public void SaqueSaldo(double valor)
        {   double taxSaque = 5.0;
            Saldo -= valor + taxSaque;
        }
        public override string ToString()
        {
            return "Conta: " +
            NumeroConta +
            ", Titular: " +
            Titular +
            ", Saldo: R$ " +
            Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}