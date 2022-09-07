using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using static BancoMorangao.CartaoCredito;

namespace BancoMorangao
{
    internal class Program
    {
        static Cliente validarCliente(List<Cliente> clienteList)
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
            //  Cliente cliente = new();
            // cliente.Nome = nome;
            // clienteList.Find(el => {el.Nome});
            for (int i = 0; i < clienteList.Count; i++)
            {
                Cliente cliente1 = clienteList[i];
                if (nome.CompareTo(cliente1.Nome) == 0)
                {

                    return cliente1;
                }

            }
            return null;
        }
        static void MenuCliente(Abertura abertura, Emprestimo emprestimo, Funcionario funcionario, CartaoCredito cartao, Poupanca poupanca, Corrente corrente, List<Cliente> clienteList, List<Funcionario> funcionarioList)
        {
            int opc;
            do
            {
                Console.Write("\n\t>>> Menu Cliente <<<\t");
                Console.WriteLine("\nO-Sair \n1-Imprimir\n2-Solicitar Empréstimo\n3-Verificar Aprovação \n4-Desbloquear Cartão Crédito \n5-Consultar Saldo\n6-Efetuar Depósito\n7-Efetuar Saque\n8-Consultar Limite Cartão Crédito\n9-Consultar Extrato");
                Console.Write("Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0://sair
                        Console.Write("Saindo");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        break;

                    case 1:
                        Console.Write("Deseja imprimir seu cadastro? \n1-SIM\n2-NÃO\n");
                        int op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            if (clienteList.Count == 0)
                            {
                                Console.Write("Não há clientes cadastrados");
                            }
                            else
                            {
                                Cliente cliente = validarCliente(clienteList);
                              //  for (int i = 0; i < clienteList.Count; i++)
                              //  {
                                    //Cliente cliente1 = clienteList[i];
                                    cliente.ImprimirPessoa();
                                    cliente.ImprimirCliente();
                                //}
                            }
                        
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
                    case 2://pede emprestimo
                        Console.Write("Deseja solicitar um empréstimo?\n1-SIM\n2-NÃO ");
                        int empreste = int.Parse(Console.ReadLine());

                        if (empreste == 1)
                        {

                            //cliente.SolicitarEmprestimo(emprestimo);
                        }
                        else
                        {
                            Console.Write("Solicitação não realiada!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Verificar análise de: 1-Abertura Conta\n2-Empréstimo");
                        int opcao = int.Parse(Console.ReadLine());
                    /*      if (opcao == 1)
                          {
                              exp conta = funcionario.AnalisarSolicitacaoAberturaConta(cliente);

                              if (conta == null)
                              {
                                  Console.Write("Você ainda não solicitou nenhuma conta!");
                              }
                              else
                              {
                                  Console.Write("Status: " + conta.descricao + " Data Solicitação: " + conta.dataPedido.ToString("dd/MM/yyyy"));
                              }

                          }*/
                        /* else
                         {
                             if (opcao == 2)
                             {

                                 List<teste> emp = funcionario.VerificarEmprestimo(cliente);
                               emp.ForEach(el => Console.WriteLine("Valor: " + el.valor + " Status: " + el.status + " Data Solicitação: " + el.dataCriacao.ToString("dd/MM/yyyy")));
                             }
                             else
                             {
                                 Console.Write("Opção inválida");
                             }
                         }*/
                        break;
                    case 4:
                        // cartao.Desbloquear(cliente);
                        break;
                    case 5:
                        Console.Write("Deseja consultar o saldo de qual conta\n1-Poupança\n2-Corrente");
                        int cSaldo = int.Parse(Console.ReadLine());
                        if (cSaldo == 1)
                        {
                            poupanca.VerSaldo();
                        }
                        else if (cSaldo == 2)
                        {
                            corrente.VerSaldo();
                        }
                        else
                        {
                            Console.Write("Opção inválida!");
                        }
                        break;
                    case 6:
                        Console.Write("Deseja depositar em qual conta\n1-Poupança\n2-Corrente");
                        int cDep = int.Parse(Console.ReadLine());
                        if (cDep == 1)
                        {
                            poupanca.Deposito();
                        }
                        else if (cDep == 2)
                        {
                            corrente.Deposito();
                        }
                        else
                        {
                            Console.Write("Opção inválida!");
                        }
                        break;
                    case 7:
                        Console.Write("Deseja sacar de qual conta\n1-Poupança\n2-Corrente");
                        int cSac = int.Parse(Console.ReadLine());
                        if (cSac == 1)
                        {
                            poupanca.Saque();
                        }
                        else if (cSac == 2)
                        {
                            corrente.Saque();
                        }
                        else
                        {
                            Console.Write("Opção inválida!");
                        }
                        break;
                    case 8:
                        //  cartao.ConsultarLimiteCartao(cliente);
                        break;
                    case 9:
                        Console.Write("Deseja consultar extrato de qual conta: 1-Corrente\n 2-Poupança");
                        int cont = int.Parse(Console.ReadLine());
                        if (cont == 1)
                        {
                            corrente.ConsultarExtrato();
                        }
                        else
                        {
                            if (cont == 2)
                            {
                                poupanca.ConsultarExtrato();
                            }
                            else
                            {
                                Console.Write("Opção inválida!");
                            }
                        }
                        break;
                }
            } while (opc != 0);
            MenuGeral(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);
           
        }
        static void CadastrarCliente(Abertura abertura, Emprestimo emprestimo, Funcionario funcionario, CartaoCredito cartao, Poupanca poupanca, Corrente corrente, List<Cliente> clienteList, List<Funcionario> funcionarioList)
        {
            Console.WriteLine("\nCadastramento iniciado: ");

            Cliente cliente = new Cliente();
            cliente.CadastrarPessoa();
         

            Console.Write("Deseja solicitar abertura de conta?\n1-SIM\n2-NÃO ");
            int abre = int.Parse(Console.ReadLine());
            if (abre == 1)
            {
                cliente.SolicitarAberturaConta(abertura);
                clienteList.Add(cliente);
            }
            else
            {
                if (abre == 2)
                {
                    Console.WriteLine("Solicitação não realizada!");
                }
                else
                {
                    Console.Write("Resposta inválida!");
                }
            }
            MenuCliente(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);

        }
        static void CadastrarFuncionario(List<Funcionario> funcionarioList)
        {
            Funcionario funcionario = new();//cadastro um novo funcionario
            funcionario.CadastrarPessoa();
            funcionario.CadastrarFuncionario();
            funcionarioList.Add(funcionario);
        }
        static void MenuFuncionario(Abertura abertura, Emprestimo emprestimo, Funcionario funcionario, CartaoCredito cartao, Poupanca poupanca, Corrente corrente, List<Cliente> clienteList, List<Funcionario> funcionarioList)
        {
            int opc;
            do
            {
                Console.Write("\n\t>>> Menu Funcionário <<<\t");
                Console.WriteLine("\nO-Sair\n1-Cadastrar Funcionário\n2-Imprimir Funcionário\n3-Verificar/Aprovar Conta\n4-Verificar/Analisar Empréstimo");
                Console.Write("Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0://sair
                        Console.Write("Saindo");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        break;
                    case 1:
                      
                        break;
                    case 2:
                        Console.Write("Deseja imprimir seu cadastro? \n1-SIM\n2-NÃO\n");
                        int op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            if (funcionarioList.Count == 0)
                            {
                                Console.Write("Não há funcionários cadastrados");
                            }
                            else
                            {
                                for (int i = 0; i < funcionarioList.Count; i++)
                                {
                                    Funcionario funcionario1 = funcionarioList[i];
                                    funcionario.ImprimirPessoa();
                                    funcionario.ImprimirFuncionario();
                                }
                            }
                        }
                        else
                        {
                            if (op == 2)
                            {
                                Console.Write("Impressão Cancelada!");
                            }
                            else
                            {
                                Console.Write("Opção inválida");
                            }
                        }
                        break;
                        /*  case 3:
                            if (funcionario.AnalisarSolicitacaoAberturaConta(cliente)!=null)//tem solicitações
                              {
                                  //  funcionario.AprovarAberturaConta();
                                  funcionario.AnalisarSolicitacaoAberturaConta(cliente);
                                  Console.Write("Verificação realizada!");
                              }
                              else
                              {
                                  Console.Write("Não há soicitações de abertura de conta pendentes");
                              }
                              break;
                          case 4:
                              if (funcionario.VerificarEmprestimo(cliente) != null)
                              {
                                  funcionario.AprovarEmprestimo(cliente);
                                  Console.Write("Verificação realizada");
                              }
                              else
                              {
                                  Console.Write("Não há solicitações de empréstimo pendentes");
                              }
                              break;*/
                }
            } while (opc!= 0);
            MenuGeral(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);
        }
        static void MenuGeral(Abertura abertura, Emprestimo emprestimo, Funcionario funcionario, CartaoCredito cartao, Poupanca poupanca, Corrente corrente, List<Cliente> clienteList, List<Funcionario> funcionarioList)
        {
            int opc = 0;
            do
            {
                //Menu separado, 1 pro cliente e 1 pro funcionário
                Console.Write("\n\t>>> Menu Geral <<<\t");
                Console.Write("\nVocê é: 0-Sair\n1-Já sou Cliente\n 2-Quero ser Cliente \n3-Sou Funcionário \n4-Funcionário,Cadastre-se");
                int sou = int.Parse(Console.ReadLine());
                if (sou == 0)
                {
                    Console.Write("Saindo");
                    Thread.Sleep(200);
                    Console.Write(" .");
                    Thread.Sleep(200);
                    Console.Write(" .");
                    Thread.Sleep(200);
                    Console.Write(" .");
                    return;
                }
                else if (sou == 1)
                {
                    Cliente cliente = validarCliente(clienteList);
                    if (cliente == null)
                    {
                        Console.Write("\nCliente não existe");
                        // Environment.Exit(0);
                        // MenuCliente(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);
                        Console.Write("\nDeseja se cadastrar? 1-SIM 2-NÃO");
                        int cadResp = int.Parse(Console.ReadLine());
                        if (cadResp == 1)
                        {
                            CadastrarCliente(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);
                            MenuCliente(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);
                        }
                        else
                        {
                            Console.Write("\nFim do atendimento!");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        MenuCliente(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);
                    }
                }
                else
                {
                    if (sou == 2)
                    {
                        CadastrarCliente(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);
                    }
                    else if (sou == 3)
                    {
                        MenuFuncionario(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);
                    }
                    else if (sou == 4)
                    {
                        CadastrarFuncionario(funcionarioList);
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                }
            } while (opc != 0);

        }
        static void Main(string[] args)
        {
            //Cliente cliente = new Cliente();
            Abertura abertura = new Abertura();
            Emprestimo emprestimo = new Emprestimo();
            Funcionario funcionario = new Funcionario(emprestimo, abertura);
            CartaoCredito cartao = new CartaoCredito();
            Poupanca poupanca = new Poupanca();
            Corrente corrente = new Corrente();
            List<Cliente> clienteList = new List<Cliente>();
            List<Funcionario> funcionarioList = new List<Funcionario>();
            MenuGeral(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);
        }
    }
}
