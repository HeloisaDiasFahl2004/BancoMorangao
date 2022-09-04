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
       // double LimiteConta { get; set; }

        public Corrente()
        {

        }
        public void Sacar(int numConta)
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
                Console.WriteLine("Saldo" + Saldo);
            }
        }
        public void Deposito(int numConta)
        {
            Console.Write("Informe o valor que deseja depositar: ");
            double deposite = double.Parse(Console.ReadLine());
            Corrente corrente = new Corrente();
            corrente.ConsultarLimiteChequeEspecial();
            Saldo = (Saldo + LimiteChequeEspecial) + deposite;
            Console.Write("Depósito efetuado!\n Saldo: " + Saldo);
        }
        public void ConsultarLimiteChequeEspecial()//Defino o limite da conta com base no perfil do cliente
        {
            Console.Write("Informe o tipo de conta(1-Universitária 2-Normal 3-Vip)");
            int TipoConta = int.Parse(Console.ReadLine());
           // Conta conta = new Conta();
          //  conta.TipoConta = Tipo;
            if (TipoConta == 1)
            {
                LimiteChequeEspecial = 100;
                Console.Write("Saldo: " + (Saldo + LimiteChequeEspecial));
            }
            else
            {
                if (TipoConta == 2)
                {
                    LimiteChequeEspecial = 150;
                   Console.Write("Saldo: " + (Saldo + LimiteChequeEspecial));
                }
               else if (TipoConta == 3)
                {
                    LimiteChequeEspecial = 10000;
                   Console.Write("Saldo: " + (Saldo + LimiteChequeEspecial));
                }
                else
                {
                    Console.Write("Opção inválida!");
                }
            }

        }
        public void RealizarPagamento()
        {

        }
        public void RealizarEmprestimos()
        {

        }
        public void ConsultarEmprestimo()
        {
            Funcionario funcionario = new Funcionario();
            if (funcionario.AprovarEmprestimo())
            {
                //Saldo = Saldo + empreste;
            }
        }

        public void Transferir(int numConta)
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
                Console.WriteLine("Saldo Conta: " + numConta + " é: " + Saldo);
                Console.Write("Informe o número da conta que deseja creditar: ");
                int numContaCredite = int.Parse(Console.ReadLine());
                //  corrente = new Corrente();
                corrente.ConsultarLimiteChequeEspecial();
                Saldo = Saldo + LimiteChequeEspecial;
                Saldo = Saldo + deposite;
                Console.Write("Saldo na conta " + numContaCredite + " é: " + Saldo);
                Console.Write("Transferência efetuada!");
            }
         


        }

        internal void VerSaldo()
        {
            Corrente corrente = new Corrente();
            corrente.ConsultarLimiteChequeEspecial();
           //Saldo = (Saldo + LimiteChequeEspecial);
         //   Console.Write("Saldo: " + Saldo);
        }
    }
}
