using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Cliente : Pessoa
    {
        public double Renda { get; set; }
        public string Estudante { get; set; }
        public int tipoConta { get; set; }
      
        public Conta conta { get; set; }
        public Cliente()//já vem da classe mãe
        {

        }
        public void ImprimirCliente()
        {
            Console.Write("\nRenda: " + this.Renda);
            Console.Write("\nTipo Conta: " + this.tipoConta);

        }
        public void SolicitarAberturaConta()
        {
            Console.Write("Renda: ");
            this.Renda = double.Parse(Console.ReadLine());
            Console.Write("Estudante(SIM/NÃO) ");
            this.Estudante = Console.ReadLine().ToUpper();
            Console.WriteLine("O gerente irá definir o tipo ideal de conta para você. ");
         //   Console.Write("Perfil(1-Univesritário\n2-Normal\n3-Vip): ");
         //   this.Perfil = Console.ReadLine();
          
            //bool aceitaConta = AbreConta(this.Renda,this.Estudante);
            //if (aceitaConta)
            //{
            //    //lista de aberturas de contas
            //    exp abra = new exp(this);
            //    contaAberta.contasAbertas.Add(abra); //atribuição por referencia, recebo objeto instanciado e só dentro da variavel recebo o valor
            //    Console.Write("\nSolicitação de abertura de conta encaminhada!");
            //}
            Console.Write("Solicitação encaminhada!");
           

        }
        /*public bool SolicitarEmprestimo(Emprestimo emprestimo)
        {
            Console.WriteLine("Informe o valor do empréstimo: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu perfil: \n1-Universitário\n2-Normal\n3-VIP");
            int tipoConta = int.Parse(Console.ReadLine());

            bool aprova = ValidaEmp(valor, tipoConta);
            if (aprova)
            {
                //lista de solicitação de empréstimo.add
                teste ajude = new teste(this, valor);
                emprestimo.emprestimos.Add(ajude);
            }
            return true;
        }
        public bool SolicitarDesbloquearCartao()
        {
            Console.Write("Deseja solicitar um desbloqueio de cartão? \n1-SIM\n2-NÃO");
            int resp = int.Parse(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    Console.Write("Solicitação de desbloqueio de cartão encaminhada!");
                    Thread.Sleep(200);
                    Console.Write("Aguarde .");
                    Thread.Sleep(200);
                    Console.Write(" .");
                    Thread.Sleep(200);
                    Console.Write(" .");
                    Console.Write("\nDesbloqueio realizado!");
                   
                    return true;

                case 2:
                    Console.Write("Solicitação de desbloqueio de cartão não realizada");
                    return false;

                default:
                    Console.Write("Opção inválida");
                    return false;

            }
        }
        private bool ValidaEmp(double valor, int tipoConta)//validações para fazer a solicitação 
        {
            if ((valor <= 500) && (tipoConta == 1))
            {
                Console.WriteLine("Empréstimo aguardando aprovação do gerente");
                return true;
            }
            if ((valor > 500) && (tipoConta == 1))
            {
                Console.WriteLine("Pedido não realizado! Não está de acordo com os requisitos pré estabelecidos");
                return false;
            }
            if ((valor <= 500) && (tipoConta == 2))
            {
                Console.WriteLine("Empréstimo aguardando aprovação do gerente");
                return true;
            }
            if ((valor > 500) && (tipoConta == 2))
            {
                Console.WriteLine("Pedido não realizado! Não está de acordo com os requisitos pré estabelecidos");
                return false;
            }
            if ((valor <= 50000) && (tipoConta == 3))
            {
                Console.WriteLine("Empréstimo aguardando aprovação do gerente");
                return true;
            }
            if ((valor > 50000) && (tipoConta == 3))
            {
                Console.WriteLine("Pedido não realizado! Não está de acordo com os requisitos pré estabelecidos");
                return false;
            }
            return false;
        }
       */
    }
}
