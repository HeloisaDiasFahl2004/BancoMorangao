using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
namespace BancoMorangao
{
   /* static void GravarArquivo( Cliente cliente)
    {
        Console.Write("Gravação iniciada");
        try
        {
           StreamWriter sw= new StreamWriter("c\\5by5\\Test.txt");
            foreach(Pessoa in agenda )
            sw.WriteLine(cliente.CadastrarPessoa(cliente));
            sw.Close();
        }catch(Exception e)
        {
            Console.Write("Exception "+e.Message );
        }
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
           
          //  COMO FAZER VETOR DE CLIENTES
           /* Pessoa []agenda = new Pessoa[3];
            for (int i = 0; i < 3; i++)
            {
                agenda[i] = new Pessoa();
            }*/
           // Pessoa pessoa = new Pessoa();//classe abstrata, tenho q instanciar apenas as classes filhas, não as abstratas
            Cliente cliente = new Cliente();

            Funcionario funcionario = new Funcionario();

            CartaoCredito cartao = new CartaoCredito();
            int opc;
           
            do
            {
                Console.Write("\t>>> Menu <<<\t");
                Console.WriteLine("\nO-Sair \n1-Cadastrar\n2-Imprimir\n3-Solicitar Empréstimo\n4-Verificar Aprovação \n5-Desbloquear Cartão Crédito\n6-Parcelar Fatura\n");
                Console.Write("Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0://sair
                        Console.Write("Saindo");
                        Thread.Sleep(500);
                        Console.Write(" .");
                        Thread.Sleep(500);
                        Console.Write(" .");
                        Thread.Sleep(500);
                        Console.Write(" .");
                        Thread.Sleep(500);
                        break;
                    case 1://só cadastro
                        Console.WriteLine("Cadastramento iniciado: ");
                        //pessoa.CadastrarPessoa(pessoa);
                        Console.Write("Deseja Cadastrar 1-Cliente\n2-Funcionário");
                        int tipoPessoa = int.Parse(Console.ReadLine());
                        if (tipoPessoa == 1)
                        {
                            cliente.CadastrarPessoa(cliente);
                            cliente.SolicitarAberturaConta(cliente);
                          
                        }
                        if (tipoPessoa == 2)
                        {
                            funcionario.CadastrarPessoa(funcionario);
                            funcionario.AnalisarSolicitacaoAberturaConta(cliente);//Problema
                        }
                        break;
                    case 2:
                        Console.Write("Deseja imprimir seu cadastro? \n1-SIM\n2-NÃO\n");
                        int op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            cliente.ImprimirPessoa(cliente);
                        }
                        else
                        {
                            if (op == 2)
                            {
                                Console.Write("Impressão cancelada!");
                            }
                            else
                            {
                                Console.Write("Opção inválida!");
                            }
                        }
                        break;
                    case 3://pede emprestimo
                        cliente.SolicitarEmprestimo();
                        funcionario.VerificarEmprestimo(cliente);
                        if (funcionario.VerificarEmprestimo(cliente) == true)
                        {
                            funcionario.AprovarEmprestimo();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Verficar aprovação de: 1-Abertura Conta\n2-Empréstimo");
                        int opcao = int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            
                            funcionario.AnalisarSolicitacaoAberturaConta(cliente);
                            Console.Write("Você é funcionário?(SIM/NÃO)");
                            string resposta = Console.ReadLine().ToUpper();
                            if (resposta == "SIM")
                            {

                                funcionario.AtivarConta();
                            }
                            else
                            {
                                Console.Write("Área restrita para funcionários!");
                            }
                        }
                        else
                        {
                            if (opcao == 2)
                            {
                                funcionario.AprovarEmprestimo();
                            }
                            else
                            {
                                Console.Write("Opção inválida!");
                            }
                        }
                        break;
                    case 5:

                        cartao.DesbloquearBloquear();
                        break;
                    case 6:

                        cartao.ParcelarFaturas();
                        break;
                }

            } while (opc != 0);







        }
    }
}
