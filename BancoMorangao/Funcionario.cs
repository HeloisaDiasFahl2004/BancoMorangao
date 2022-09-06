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
     public Funcionario()
        {

        }

        public Funcionario(Emprestimo emprestimo,Abertura abertura)
        {
            this.emprestimo = emprestimo;
            this.abertura = abertura;
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
        public void AprovarAberturaConta()//altero descriçao, crio numero aleatorio, salvo na agencia de numero q ele escolher
        {
            abertura.contasAbertas.ForEach(el => {
                abertura.AlteraDescricao(el, "Aprovado");//troca para aprovado todos os status ,lambda => função escrita em uma linha só
                Random numeroConta = new Random();
                numeroConta.Next();
                Conta conta = new Conta();//cria instancia conta
                conta.NumeroConta = numeroConta.Next();
                Agencia agencia = new Agencia();//crio instancia agencia
                Console.Write("Informe em qual agência deseja abrir: ");
                int numero = agencia.ImprimirAgencia();
                agencia.NumeroAgencia = numero;
                el.cliente.conta = conta;//associo a conta com o cliente, para a propriedade do cliente não ficar nula
                el.cliente.agencia = agencia;//associo a agencia com o cliente,para a propriedade do cliente não ficar nula
                Console.Write("\nNumero conta: " + conta.NumeroConta + "\nAgencia: " + numero);
            });
        }
        public exp AnalisarSolicitacaoAberturaConta(Cliente cliente)//cliente só tem 1 conta, logo não precisa retornar 1 lista.
        {
            return abertura.contasAbertas.FirstOrDefault(conta => conta.cliente == cliente);//encontro o objeto q preciso
        
        }
        public bool AprovarEmprestimo(Cliente cliente)
        {
            List<teste> emp = emprestimo.emprestimos.FindAll(emp => emp.cliente == cliente);//encontro o objeto q preciso
            emp.ForEach(el => emprestimo.AlteraStatus(el,"Aprovado") );
                return true;
        }
        public List<teste> VerificarEmprestimo(Cliente cliente)
        {
            
            return emprestimo.emprestimos.FindAll(emp => emp.cliente == cliente);//retorna lista com um filtro
        }
    }
}
