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
        //   Emprestimo emprestimo { get; set; }
        //Abertura abertura { get; set; }
        public Funcionario()
        { }
        public void CadastrarFuncionario()
        {
            Agencia agencia = new Agencia();
            Console.WriteLine("Cargo: NORMAL/GERENTE?");
            this.Cargo = Console.ReadLine().ToUpper();
            agencia.ImprimirAgencia();
        }
        public void ImprimirFuncionario()
        {
            Console.Write("\nCargo: " + this.Cargo);
            agencia = new Agencia();
            Console.Write("\nAgencia:001\n");
            agencia.ImprimirAgencia();
        }
        public void AprovarAberturaConta(List<Cliente> aprovadoList, Espera cliente)//altero descriçao, crio numero aleatorio, salvo na agencia de numero q ele escolher OK
        {
            if (cliente.descricao == "Em análise")
            {
                cliente.descricao = "Aprovado";
                aprovadoList.Add(cliente.cliente);
               
            }
        }
        public int AnalisarSolicitacaoAberturaConta(Espera cliente)//cliente só tem 1 conta, logo não precisa retornar 1 lista.
        {

            int tipoConta;
            if (cliente.cliente.Renda < 300 && cliente.cliente.Estudante.Equals("SIM"))
            {
                //tipo universitario
                Console.Write("Conta universitária");
                tipoConta = 1;
                Console.Write("\nTipo de Conta: " + tipoConta);

                return tipoConta;
            }
            else if (cliente.cliente.Renda < 300)
            {
                Console.Write("Conta normal");
                tipoConta = 2;
                Console.Write("\nTipo de Conta: " + tipoConta);
                return tipoConta;
            }
            else
            {
                Console.Write("Conta VIP");
                tipoConta = 3;
                Console.Write("\nTipo de Conta: " + tipoConta);
                return tipoConta;
            }


        }
    }
}