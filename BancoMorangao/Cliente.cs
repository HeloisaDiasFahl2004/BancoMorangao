using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Cliente : Pessoa
    {
        public double Renda { get; set; }
        public string Perfil { get; set; }
        public string Estudante { get; set; }
        public int tipoConta { get; set; }
        public Cliente()//já vem da classe mãe
        {

        }

        /*public Cliente(string nome, DateTime dataNascimento, long telefone, long cpf, long rg, double renda, string estudante, string perfil) : base(nome, dataNascimento, telefone, cpf, rg)
        {
            Renda = renda;
            Perfil = perfil;
            Estudante = estudante;
        }*/
        
        public bool SolicitarAberturaConta(Cliente cliente)
        {
                    Console.Write("Renda: ");
                    cliente.Renda = double.Parse(Console.ReadLine());
                    Console.Write("Estudante(SIM/NÃO) ");
                    cliente.Estudante = Console.ReadLine().ToUpper();
                    Console.Write("Perfil(1-Univesritário\n2-Normal\n3-Vip): ");
                    cliente.Perfil = Console.ReadLine();

                    Console.Write("Solicitação de abertura de conta encaminhada!");

            //lista de solicitação de abertura de conta.add

            Funcionario funcionario = new Funcionario();
            funcionario.AnalisarSolicitacaoAberturaConta(cliente);

           
                    return true;
        
        }
        public bool SolicitarEmprestimo(Cliente cliente)
        {
            Console.WriteLine("Informe o valor do empréstimo: ");
            double Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu perfil: \n1-Universitário\n2-Normal\n3-VIP");
           int tipoConta = int.Parse(Console.ReadLine());
            //lista de solicitação de empréstimo.add

            Console.Write("Solicitação de empréstimo encaminhada!");
           
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

    }
}
