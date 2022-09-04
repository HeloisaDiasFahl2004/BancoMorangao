using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{

    internal class Funcionario : Pessoa
    {

        public Agencia agencia { get; set; }
        public string Cargo { get; set; }
        int tipoConta;
       double Valor;

        public Funcionario()
        {

        }
        /* public Funcionario(string nome, DateTime dataNascimento, long telefone, long cpf, long rg, string cargo, Agencia numeroAgencia) : base(nome, dataNascimento, telefone, cpf, rg)
         {
             Cargo = cargo;
             this.numeroAgencia = new Agencia();
         }
        */
        int i;
        public void CadastrarFuncionario()
        {
            i = 0;
            Agencia agencia = new Agencia();
            Console.WriteLine("Cargo: NORMAL/GERENTE?");
            this.Cargo = Console.ReadLine();
            agencia.CadastrarAgencia();
            i++;
        }
        public void ImprimirFuncionario()
        {

            if (i < 1)
            {
                Console.WriteLine("Não há cadastramento ainda!");
            }
            else
            {
                if (i >= 1)
                    Console.Write("\nCargo: " + this.Cargo);
                agencia = new Agencia();
                Console.Write("\nAgencia:" + this.agencia);
                agencia.ImprimirAgencia();

            }

        }
        public bool VerificarTipoFuncionario()
        {
            if (this.Cargo == "GERENTE")
            {
                Console.Write("Informe o que deseja fazer: \n1-Aprovar Contas \n2-Aprovar Empréstimos");
                int funcGerente = int.Parse(Console.ReadLine());
                if (funcGerente == 1)
                {
                    AprovarAberturaConta();
                }
                else
                {
                    if (funcGerente == 2)
                    {
                        AprovarEmprestimo();
                    }
                    else
                    {
                        Console.Write("Opção inválida!");
                    }

                }
                return true;
            }
            else
            {
                Console.WriteLine("Apenas gerente pode aprovar abertura de conta/solicitações de empréstimo");
            }
            return false;
        }
        public void AprovarAberturaConta()
        {

            Console.Write("\nO gerente autorizou a conta");
            Conta conta = new Conta();
            Random numeroConta = new Random();
            numeroConta.Next();
            conta.NumeroConta = numeroConta.Next();
            //Conta conta = new Conta();//tenho que criar uma conta.
            //fazer uma lista contas aprovadas
            Agencia agencia = new Agencia();
            // agencia.ImprimirAgencia();
            Console.Write("Informe em qual agência deseja abrir: ");
            int numero = agencia.ImprimirAgencia();

            Console.Write("\nNumero conta: " + conta.NumeroConta + "\nAgencia: " + numero);
        }
        public bool AnalisarSolicitacaoAberturaConta(Cliente cliente)
        {
            /* if (cliente == null)
             {
                 Console.WriteLine("Não há solicitações de abertura de conta pendentes!");
                 return false;
             }
             else
             {*/
            //imprimir lista de solicitações de conta
            if (cliente.Renda < 300 && cliente.Estudante.Equals("SIM"))
            {
                //tipo universitario
                Console.Write("Você se encaixa com a conta universitária");
                tipoConta = 1;
                Console.Write("\nTipo de Conta: " + tipoConta);
                //fazer lista para clientes universitário
                return true;
            }
            else if (cliente.Renda < 300 )
            {
                Console.Write("Você se encaixa com a conta normal");
                tipoConta = 2;
                Console.Write("\nTipo de Conta: " + tipoConta);
                //fazer lista para clientes normal
                return true;
            }
            else if(cliente.Renda >300)
            {
                Console.Write("Você se encaixa com a conta VIP");
                tipoConta = 3;
                Console.Write("\nTipo de Conta: " + tipoConta);
                //fazer lista para clientes vip
                return true;
            }
            return false;
            // }


        }

        public bool AprovarEmprestimo()
        {
            Funcionario funcionario = new Funcionario();
            if (funcionario.VerificarTipoFuncionario())
            {
                Console.Write("Empréstimo Aprovado!");

                return true;
            }
            else
            {
                Console.Write("Só o gerente pode aprovar empréstimo");
            }
            return false;

        }
        public bool VerificarEmprestimo(Cliente cliente)
        {
            //imprimir lista de solicitações de empréstimo

         // if (cliente.SolicitarEmprestimo(cliente))//se for true
           // {
                //problema
                //double Valor = 10;
              //  int tipoConta=1;

                if ((Valor < 500) && (tipoConta == 1))
                {
                    Console.WriteLine("Empréstimo aguardando aprovação do gerente");
                    return true;
                }
                if ((Valor > 500) && (tipoConta == 1))
                {
                    Console.WriteLine("Pedido não realizado! Não está de acordo com os requisitos pré estabelecidos");
                    return false;
                }
                if ((Valor < 500) && (tipoConta == 2))
                {
                    Console.WriteLine("Empréstimo aguardando aprovação do gerente");
                    return true;
                }
                if ((Valor > 500) && (tipoConta == 2))
                {
                    Console.WriteLine("Pedido não realizado! Não está de acordo com os requisitos pré estabelecidos");
                    return false;
                }
                if ((Valor < 50000) && (tipoConta == 3))
                {
                    Console.WriteLine("Empréstimo aguardando aprovação do gerente");
                    return true;
                }
                if ((Valor > 50000) && (tipoConta == 3))
            {
                    Console.WriteLine("Pedido não realizado! Não está de acordo com os requisitos pré estabelecidos");
                    return false;
                }
            //}
            return false;
        }
    }
}
