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

            Console.Write("Deseja solicitar a abertura de uma conta? \n1-SIM\n2-NÃO");
            int resp = int.Parse(Console.ReadLine());
            Console.Write("Renda: ");
            cliente.Renda = double.Parse(Console.ReadLine());
            Console.Write("Estudante(SIM/NÃO) ");
            cliente.Estudante = Console.ReadLine().ToUpper();
            Console.Write("Perfil(Univesritário,Normal,Vip): ");
            cliente.Perfil = Console.ReadLine();

            switch (resp)
            {
                case 1:
                    Console.Write("Solicitação de abertura de conta encaminhada!");
                    return true;

                    break;
                case 2:
                    Console.Write("Solicitação de abertura de conta não realizada!");
                    return false;
                    break;
                default:
                    Console.Write("Opção inválida");
                    return false;
                    break;
            }
        }
        public bool SolicitarEmprestimo()
        {
            Console.Write("Deseja solicitar um empréstimo? \n1-SIM\n2-NÃO");
            int resp = int.Parse(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    Console.Write("Solicitação de empréstimo encaminhada!");
                    return true;
                    break;
                case 2:
                    Console.Write("Solicitação de empréstimo não realizada");
                    return false;
                    break;
                default:
                    Console.Write("Opção inválida");
                    return false;
                    break;
            }

        }
        public bool SolicitarDesbloquearCartao()
        {
            Console.Write("Deseja solicitar um desbloqueio de cartão? \n1-SIM\n2-NÃO");
            int resp = int.Parse(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    Console.Write("Solicitação de desbloqueio de cartão encaminhada!");
                    Thread.Sleep(2000);
                    Console.Write("\nDesbloqueio realizado!");
                    return true;
                    break;
                case 2:
                    Console.Write("Solicitação de desbloqueio de cartão não realizada");
                    return false;
                    break;
                default:
                    Console.Write("Opção inválida");
                    return false;
                    break;
            }
        }

    }
}
