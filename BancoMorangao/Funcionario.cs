using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Funcionario : Pessoa
    {
        string Cargo { get; set; }
        Agencia numeroAgencia;


        public Funcionario()
        {

        }
        public Funcionario(string nome, DateTime dataNascimento, long telefone, long cpf, long rg, string cargo, Agencia numeroAgencia) : base(nome, dataNascimento, telefone, cpf, rg)
        {
            Cargo = cargo;
            this.numeroAgencia = new Agencia();
        }

        public void CadastrarFuncionario()
        {
            Console.Write("Informe seu cargo: ");
            this.Cargo = Console.ReadLine().ToUpper();
            Console.Write("Agencia");
            Agencia numeroAgencia = new Agencia();
            numeroAgencia.CadastrarAgencia();
        }
        public void VerificarTipoFuncionario()
        {
            if (Cargo == "GERENTE")
            {
                Gerente gerente = new Gerente();
                Console.Write("Informe que função deseja realizar \n1-Aprovar Solicitações de Aberturas de Contas \n2-Aprovar Solicitações de Empréstimos ");
                int funcGerente = int.Parse(Console.ReadLine());
                switch (funcGerente)
                {
                    case 1:
                        gerente.AprovarAberturaConta();

                        break;
                    case 2:
                        gerente.AprovarEmprestimo();

                        break;
                    default:
                        Console.Write("Opção inválida!");
                        break;
                }
            }
            else
            {
                Console.Write("Funcionário Normal");
            }
        }
        public bool VerificarTipoContaComBaseNaRenda(Cliente cliente)
        {
            double rendaUni = 1000;
            double rendaNormal = 1000;
            int perfil;

            if (cliente.SolicitarAberturaConta() == true)
            {
                if ((cliente.Renda <= rendaUni) && (cliente.Estudante.Equals("SIM")))
                {
                    Console.Write("Perfil cliente está de acordo com o cliente universitário(1)");
                    perfil = 1;
                    return true;
                }
                else
                {
                    if (cliente.Renda <= rendaNormal)
                    {
                        Console.Write("Perfil cliente está de acordo com o cliente normal(2)");
                        perfil = 2;
                        return true;
                    }
                    else
                    {
                        Console.Write("Perfil cliente está de acordo com o cliente VIP(3)");
                        perfil = 3;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool VerificarEmprestimo(Cliente cliente)
        {
            int perfil = 0;
            if (cliente.SolicitarEmprestimo() == true)
            {
                Console.WriteLine("Informe o valor do empréstimo: ");
                double valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe seu perfil: \n1-Universitário\n2-Normal\n3-VIP");
                perfil = int.Parse(Console.ReadLine());
                if ((valor < 500) && (perfil == 1))
                {
                    Console.WriteLine("Empréstimo aguardando aprovação do gerente");
                    return true;
                }
                if ((valor > 500) && (perfil == 1))
                {
                    Console.WriteLine("Pedido não realizado! Não está de acordo com os requisitos pré estabelecidos");
                    return false;
                }
                if ((valor < 500) && (perfil == 2))
                {
                    Console.WriteLine("Empréstimo aguardando aprovação do gerente");
                    return true;
                }
                if ((valor > 500) && (perfil == 2))
                {
                    Console.WriteLine("Pedido não realizado! Não está de acordo com os requisitos pré estabelecidos");
                    return false;
                }
                if ((valor < 50000) && (perfil == 3))
                {
                    Console.WriteLine("Empréstimo aguardando aprovação do gerente");
                    return true;
                }
                else 
                {
                    Console.WriteLine("Pedido não realizado! Não está de acordo com os requisitos pré estabelecidos");
                    return false;
                }
            }
            return false;
        }
    }
}
