using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Corrente : Conta
    {
        double LimiteChequeEspecial { get; set; }
        double Saldo { get; set; }
        List<double> depositoList { get; set; }
        List<double> saqueList { get; set; }
      //  List<double> tranferencialist { get; set; }

        public Corrente()
        {
           depositoList = new List<double>();
            saqueList = new List<double>();
            //tranferencialist = new List<double>();
        }

        public void Saque()
        {
            Console.Write("Informe quanto deseja sacar: ");
            double saque = double.Parse(Console.ReadLine());
            Corrente corrente = new Corrente();
            corrente.ConsultarLimiteChequeEspecial();
            Saldo = (Saldo + LimiteChequeEspecial);

            if (Saldo == 0 || Saldo < saque)
            {
                Console.Write("Saque indisponível!\n Motivo: saldo insuficiente!");

            }
            else
            {
                Saldo = Saldo - saque;
                Console.Write("Saque efetuado!");
                Console.WriteLine("Saldo: " + Saldo);
                saqueList.Add(saque);
            }
        }
        public bool Deposito()
        {
            Console.Write("Informe o valor que deseja depositar: ");
            double deposite = double.Parse(Console.ReadLine());
            ConsultarLimiteChequeEspecial();
            //  this.Saldo += (LimiteChequeEspecial + deposite);
            Saldo += deposite;
            depositoList.Add(deposite);
            Console.Write("Depósito efetuado!\n Saldo: " + Saldo);
            return true;
        }
        public void ConsultarLimiteChequeEspecial()//Defino o limite da conta com base no perfil do cliente
        {
            if (LimiteChequeEspecial != 0)
            {
                return;
            }

                Console.Write("Informe o tipo de conta(1-Universitária 2-Normal 3-Vip)");
                int TipoConta = int.Parse(Console.ReadLine());

                if (TipoConta == 1)
                {
                    LimiteChequeEspecial = 100;

                }
                else if (TipoConta == 2)
                {
                    LimiteChequeEspecial = 150;
                    //  Console.Write("Saldo: " + (Saldo + LimiteChequeEspecial));
                }
                else if (TipoConta == 3)
                {
                    LimiteChequeEspecial = 10000;
                    // Console.Write("Saldo: " + (Saldo + LimiteChequeEspecial));
                }
                Saldo += LimiteChequeEspecial;
        }
       /*public void RealizarPagamento()
        {

        }*/
      /*  public void RealizarEmprestimos()
        {
            
            Cliente cliente = new Cliente();
          

           
  
        }        */
       /* public void Transfira()
        {
            Console.Write("Informe o valor que deseja transferir: ");
            double deposite = double.Parse(Console.ReadLine());
            Corrente corrente = new Corrente();
            corrente.ConsultarLimiteChequeEspecial();
            Saldo = Saldo + LimiteChequeEspecial;
            if (Saldo == 0 || Saldo < deposite)
            {
                Console.Write("Saque indisponível!\n Motivo: saldo insuficiente!");

            }
            else
            {
                Saldo = Saldo - deposite;
                Console.WriteLine("Saldo Conta na conta que realizou a transferencia é: " + Saldo);
                Console.Write("Informe o número da conta que deseja creditar: ");
                int numContaCredite = int.Parse(Console.ReadLine());
                corrente.ConsultarLimiteChequeEspecial();
                Saldo = Saldo + LimiteChequeEspecial;
                Saldo = Saldo + deposite;
                Console.Write("Saldo na conta que foi creditado é: " + Saldo);
                tranferencialist.Add(deposite);
                Console.Write("Transferência efetuada!");

            }



        }*/
        public void VerSaldo()
        {
            ConsultarLimiteChequeEspecial();
            Console.Write("Saldo: "+Saldo);
        }
        public void ConsultarExtrato()
        {
            Console.Write("\nDepositos: " + depositoList.Count);
            Console.Write("\nSaques: " + saqueList.Count);
           // Console.Write("\nTransferências: " + tranferencialist.Count);
        }
    }
}
