using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Conta
    {
       public int TipoConta { get; set; }// 1/2/3
       public int NumeroConta { get; set; }
       // string Senha { get; set; }
        CartaoCredito cartao;
       

        public Conta()
        {
            
        }
        public Conta(int tipoConta, int numeroConta)//, string senha)
        {
            TipoConta = tipoConta;
            NumeroConta = numeroConta;
           // Senha = senha;
            this.cartao = new CartaoCredito();//crio o objeto
            
        }
       
        public void ConsultarSaldo()
        {
            Console.Write("Informe de qual conta deseja consultar: 1-Poupança 2-Corrente");
            int copc = int.Parse(Console.ReadLine());
            if (copc == 1)
            {
                Poupanca poupanca = new Poupanca();
                poupanca.VerSaldo();
                //imprimir o saldo na tela 
            }
            else
            {
                if (copc == 2)
                {
                    Corrente corrente = new Corrente();
                    corrente.VerSaldo();
                    //imprime saldo na tela
                }
            }

        }
        public void ConsultarExtrato()
        {

        }
        public void Sacar()
        {
            Console.WriteLine(" Informe a agência que deseja realizar o saque: ");
            Agencia agencia = new Agencia();
            agencia.ImprimirAgencia();
            //lista de contas naquela agencia
            //imprime a lista
            //escolha a conta que deseja sacar
            Console.Write("\nInforme qual o número de sua conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write(" Informe se deseja sacar \n 1-conta poupança ou \n 2-conta corrente");
            int opcSaque = int.Parse(Console.ReadLine());
            if (opcSaque == 1)
            {
                Poupanca poupanca = new Poupanca();
                poupanca.Sacar(numConta);
            }
            else
            {
                if(opcSaque == 2)
                {
                    Corrente corrente = new Corrente();
                    corrente.Sacar(numConta);
                }
                else
                {
                    Console.Write("Opção inválida! ");
                }
            }
            
         

        }
        public void Depositar()
        {
            Console.WriteLine("Informe a agência que deseja realizar o deposito: ");
            Agencia agencia = new Agencia();
            agencia.ImprimirAgencia();
            //lista de contas naquela agencia
            //imprime a lista
            //escolha a conta que deseja depositar
            Console.Write("\nInforme o número da conta em que deseja depositar: ");
            int numConta=int.Parse(Console.ReadLine());
            Console.Write("Informe se deseja depositar 1-Conta Poupança 2-Conta Corrente");
            int opcDeposito=int.Parse(Console.ReadLine());
            if(opcDeposito == 1) 
            {
                Poupanca poupanca = new Poupanca();
                poupanca.Deposito(numConta);
            }
            else
            {
                if (opcDeposito == 2)
                {
                    Corrente corrente = new Corrente();
                    corrente.Deposito(numConta);
                }
                else
                {
                    Console.Write("Opção inválida!");
                }
            }
          

        }
        public void Transferir()
        {
            Console.WriteLine("Informe a agência que deseja realizar a transferência: ");
            Agencia agencia = new Agencia();
            agencia.ImprimirAgencia();
            //lista de contas naquela agencia
            //imprime a lista
            Console.Write("Informe qual o número de sua conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Informe de qual conta deseja realizar a transferência 1-Poupança 2-Corrente");
            int transfira = int.Parse(Console.ReadLine());
            if (transfira == 1)
            {
                Poupanca poupanca= new Poupanca();
                poupanca.Transferir(numConta);
            }
            else
            {
                if(transfira == 2)
                {
                    Corrente corrente = new Corrente();
                    corrente.Transferir(numConta);
                }
            }

           
        }
       /* public void EfetuarLogin()
        {

        }*/
    }
}
