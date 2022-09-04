using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Poupanca : Conta
    {
        double Saldo { get; set; }
        double deposite;

        public Poupanca()
        {

        }
        public void Sacar(int numConta)
        {
            Console.Write("Informe quanto deseja sacar: ");
            double saque = double.Parse(Console.ReadLine());

            if (Saldo == 0 || Saldo < saque)
            {
                Console.Write("Saque indisponível! Motivo: saldo insuficiente!");

            }
            else
            {
                Saldo = Saldo - saque;
                Console.WriteLine("Saque efetuado! ");
                Console.Write("Saldo: " + Saldo);
            }
        }
        public bool Deposito(int numConta)
        {
            Console.Write("Informe o valor que deseja depositar: ");
            deposite = double.Parse(Console.ReadLine());
            this.Saldo +=  deposite;
            Console.Write("Depósito efetuado!\n Saldo: " + Saldo);
            return true;
        }

        public void Transferir(int numConta)
        {
            Console.Write("Informe o valor que deseja transferir: ");
            double deposite = double.Parse(Console.ReadLine());
            if (Saldo == 0 || Saldo < deposite)
            {
                Console.Write("Saque indisponível!\n Motivo: saldo insuficiente!");

            }
            else
            {
                Saldo = Saldo - deposite;
                Console.WriteLine("Saldo Conta: " + numConta + " é: " + Saldo);
                Console.Write("Informe o número da conta que deseja creditar: ");
                int numContaCredite = int.Parse(Console.ReadLine());
                Saldo = Saldo + deposite;
                Console.Write("Saldo na conta " + numContaCredite + " é: " + Saldo);
                Console.Write("Transferência efetuada!");
            }

        }

        public void VerSaldo()
        {

            Console.Write("Saldo: " + this.Saldo);
        }

    }
}
