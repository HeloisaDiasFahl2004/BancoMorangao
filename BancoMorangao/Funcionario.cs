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
        { 
        }
        public void CadastrarFuncionario()
        {
            Agencia agencia = new Agencia();
            Console.WriteLine("Cargo: NORMAL/GERENTE?");
            this.Cargo = Console.ReadLine();
            agencia.ImprimirAgencia();
        }
        public void ImprimirFuncionario()
        {
            Console.Write("\nCargo: " + this.Cargo);
            // agencia = new Agencia();
            Console.Write("\nAgencia:001");
            agencia.ImprimirAgencia();
        }
        public void AprovarAberturaConta( List<Espera>analiseList)//altero descriçao, crio numero aleatorio, salvo na agencia de numero q ele escolher OK
        {
            Console.Write("Informe o nome do cliente que deseja realizar a aprovação da conta: ");
            string nomeCliente=Console.ReadLine(); 

            for (int i = 0; i < analiseList.Count; i++)
            {
                Espera analise = analiseList[i];
                if (analise.descricao=="Em análise")
                {
                    analise.descricao = "Aprovado";
                }
            }
           
        }
        public void AnalisarSolicitacaoAberturaConta(Cliente cliente)//cliente só tem 1 conta, logo não precisa retornar 1 lista.
        {
            if (AbreConta(cliente))
            
                return ;
            
            //return espera.contasAbertas.FirstOrDefault(conta => conta.cliente == cliente);//encontro o objeto q preciso, usei o first ao invés do find pq o cliente abre só uma conta

        }
       
        public bool AbreConta(Cliente cliente)
        {
            int tipoConta ;
            if (cliente.Renda < 300 && cliente.Estudante.Equals("SIM"))
            {
                //tipo universitario
                Console.Write("Conta universitária");
                tipoConta = 1;
                Console.Write("\nTipo de Conta: " + tipoConta);

                return true;
            }
            else if (cliente.Renda < 300)
            {
                Console.Write("Conta normal");
                tipoConta = 2;
                Console.Write("\nTipo de Conta: " + tipoConta);
                return true;
            }
            else
            {
                Console.Write("Conta VIP");
                tipoConta = 3;
                Console.Write("\nTipo de Conta: " + tipoConta);
                return true;
            }

        }
    }
}
