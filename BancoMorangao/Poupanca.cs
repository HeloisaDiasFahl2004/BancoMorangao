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
        List<double> depositoList { get; set; }
        List<double> saqueList { get; set; }
      //  List<double> tranferencialist { get; set; }


        public Poupanca()
        {
            depositoList = new List<double>();
            saqueList = new List<double>();
            //tranferencialist = new List<double>();
        }
        public void Saque()
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
                saqueList.Add(saque);
            }
        }
        public bool Deposito()
        {
            Console.Write("Informe o valor que deseja depositar: ");
            deposite = double.Parse(Console.ReadLine());
            this.Saldo +=  deposite;
            Console.Write("Depósito efetuado!\n Saldo: " + Saldo);
            depositoList.Add(deposite);
            return true;
        }
        /*public void Transfira()
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
                Console.WriteLine("Saldo Conta que realizou a transferencia é: " + Saldo);
                Console.Write("Informe o número da conta que deseja creditar: ");
                int numContaCredite = int.Parse(Console.ReadLine());
                Saldo = Saldo + deposite;
                Console.Write("Saldo na conta que foi creditado é: " + Saldo);
                tranferencialist.Add(deposite);
                Console.Write("Transferência efetuada!");

            }

        }*/
        public void VerSaldo()
        {
           
            Console.Write("Saldo: " + this.Saldo);
        }
        public void ConsultarExtrato()
        {
            Console.Write("\nDepositos: " + depositoList.Count);
            Console.Write("\nSaques: " + saqueList.Count);
          //  Console.Write("\nTransferências: " + tranferencialist.Count);
        }

    }
}
