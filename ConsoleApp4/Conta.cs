using System.Dynamic;
using System.Globalization;

namespace Course
{
    class Conta
    {
       public int Contaid { get; private set; }
       public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int contaid, string nome)
        {
            Contaid = contaid;
            Nome = nome;
        }

        public Conta(int contaid, string nome, double saldo) : this (contaid, nome)
        {
            Saldo = saldo;
        }


        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }
        public void Saque (double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Contaid + ", Titular: " + Nome + ", Saldo: $ " + Saldo;
        }
    }

}