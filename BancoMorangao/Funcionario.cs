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
        Emprestimo emprestimo { get; set; }
        Abertura abertura { get; set; }
       int tipoConta;
        // double Valor;

        public Funcionario(Emprestimo emprestimo)
        {
            this.emprestimo = emprestimo;
        }
        public void CadastrarFuncionario()
        {
            Agencia agencia = new Agencia();
            Console.WriteLine("Cargo: NORMAL/GERENTE?");
            this.Cargo = Console.ReadLine();
            agencia.CadastrarAgencia();
        }
        public void ImprimirFuncionario()
        {
                Console.Write("\nCargo: " + this.Cargo);
                agencia = new Agencia();
                Console.Write("\nAgencia:" + this.agencia);
                agencia.ImprimirAgencia();
        }
        public bool VerificarTipoFuncionario(Cliente cliente)
        {
            bool emprestimoAprovado = false;
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
                        AprovarEmprestimo(cliente);
                    }
                    else
                    {
                        Console.Write("Opção inválida!");
                    }

                }
                return emprestimoAprovado;
            }
            else
            {
                Console.WriteLine("Apenas gerente pode aprovar abertura de conta/solicitações de empréstimo");
            }
            return false;
        }
        public void AprovarAberturaConta()
        {
           
            abertura.contasAbertas.ForEach(el => {
                abertura.AlteraDescricao(el, "Aprovado");
                Random numeroConta = new Random();
                numeroConta.Next();
                Conta conta = new Conta();
                conta.NumeroConta = numeroConta.Next();
                Agencia agencia = new Agencia();
                Console.Write("Informe em qual agência deseja abrir: ");
                int numero = agencia.ImprimirAgencia();
                Console.Write("\nNumero conta: " + conta.NumeroConta + "\nAgencia: " + numero);

            });
        }
        public bool AnalisarSolicitacaoAberturaConta(Cliente cliente)
        {
            if (cliente.Renda < 300 && cliente.Estudante.Equals("SIM"))
            {
                //tipo universitario
                Console.Write("Você se encaixa com a conta universitária");
                tipoConta = 1;
                Console.Write("\nTipo de Conta: " + tipoConta);
                return true;
            }
            else if (cliente.Renda < 300 )
            {
                Console.Write("Você se encaixa com a conta normal");
                tipoConta = 2;
                Console.Write("\nTipo de Conta: " + tipoConta);
                return true;
            }
            else if(cliente.Renda >300)
            {
                Console.Write("Você se encaixa com a conta VIP");
                tipoConta = 3;
                Console.Write("\nTipo de Conta: " + tipoConta);
                return true;
            }
            return false;
            // }


        }
        public bool AprovarEmprestimo(Cliente cliente)
        {
            List<teste> emp = emprestimo.emprestimos.FindAll(emp => emp.cliente == cliente);//encontro o objeto q preciso
            emp.ForEach(el => emprestimo.AlteraStatus(el,"Aprovado") );
                return true;
        }
        public List<teste> VerificarEmprestimo(Cliente cliente)
        {
            return emprestimo.emprestimos.FindAll(emp => emp.cliente == cliente);
        }
    }
}
