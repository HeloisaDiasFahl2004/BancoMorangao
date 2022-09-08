using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
//using static BancoMorangao.CartaoCredito;
namespace BancoMorangao
{
    internal class Program
    {
        static Espera StatusConta(List<Espera> espera, string nome)
        {
            foreach (Espera esperaItem in espera)
            {
                if (esperaItem.cliente.Nome == nome)
                {
                    return esperaItem;
                }
            }
            return null;
        }
        static Espera EsperaCliente(List<Espera> espera)
        {
            foreach (Espera esperaItem in espera)
            {
                if (esperaItem != null)
                {
                    return esperaItem;
                }
            }
            return null;
        }
        static void Cliente(List<Cliente> clienteList, Poupanca poupanca, Corrente corrente, List<Espera> esperaList,Funcionario funcionario)//Verifico se meu sliente e exite se não, volto pro menu geral OK
        {
            Cliente cliente = ValidarCliente(clienteList);
            if (cliente == null)
            {
                Console.Write("\nCliente não existe");

                MenuGeral();
            }

            else
            {
                MenuCliente(clienteList, poupanca, corrente, cliente, esperaList,funcionario);
            }
        }
        static Cliente ValidarCliente(List<Cliente> clienteList)//ver se o cliente existe OK
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
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
        static void MenuCliente(List<Cliente> clienteList, Poupanca poupanca, Corrente corrente, Cliente cliente, List<Espera> esperaList,Funcionario funcionario)//cliente pode fazer OK
        {
            int opc;
            do
            {
                Console.Write("\n\t>>> Menu Cliente <<<\t");
                Console.WriteLine("\nO-Sair \n1-Imprimir\n2-Verificar Aprovação\n3-Consultar Saldo\n4-Efetuar Depósito\n5-Efetuar Saque\n6-Consultar Extrato");
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
                                ValidarCliente(clienteList);
                                for (int i = 0; i < clienteList.Count; i++)
                                {
                                    Cliente cliente1 = clienteList[i];
                                    cliente1.ImprimirPessoa();
                                    cliente1.ImprimirCliente();
                                }
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

                    case 2:
                        Console.Write("Informe seu nome: ");
                        string nome = Console.ReadLine();
                        Espera cliente2 = StatusConta(esperaList, nome);
                        if (cliente2 == null)
                        {
                            Console.Write("Você ainda não solicitou nenhuma conta!");
                        }
                        else
                        {
                            Console.Write("Status: " + cliente2.descricao + " Data Solicitação: " + cliente2.dataPedido.ToString("dd/MM/yyyy"));
                            if (cliente2.descricao == "Aprovado")
                            {
                               int tipoConta = funcionario.AnalisarSolicitacaoAberturaConta(cliente2);
                            }
                        }
                        break;

                    case 3:
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
                    case 4:
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
                    case 5:
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

                    case 6:
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
            MenuGeral();

        }
        static void CadastrarCliente(List<Espera> analise, List<Cliente> clienteList)//cadastro meu cliente OK
        {
            Console.WriteLine("\nCadastramento iniciado: ");

            Cliente cliente = new Cliente();
            cliente.CadastrarPessoa();


            Console.Write("Deseja solicitar abertura de conta?\n1-SIM\n2-NÃO ");
            int abre = int.Parse(Console.ReadLine());
            if (abre == 1)
            {
                SolicitacaoConta(cliente, analise, clienteList);
            }
            else
            {
                Console.WriteLine("Solicitação não realizada!");
            }



        }
        static void SolicitacaoConta(Cliente cliente, List<Espera> analise, List<Cliente> clienteList)//cliente pede abertura da conta e é adicionado na lista de espera OK
        {
            cliente.SolicitarAberturaConta();
            Espera espera = new Espera(cliente);
            analise.Add(espera);
            clienteList.Add(cliente);

        }
        static void CadastrarFuncionario(List<Funcionario> funcionarioList)//cadastro funcionário  OK
        {
            Console.WriteLine("\nCadastramento iniciado: ");
            Funcionario funcionario = new();//cadastro um novo funcionario
            funcionario.CadastrarPessoa();
            funcionario.CadastrarFuncionario();
            funcionarioList.Add(funcionario);
        }
        static Funcionario ValidarFuncionario(List<Funcionario> funcionarioList)//vejo se meu funcionário existe OK
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();
            for (int i = 0; i < funcionarioList.Count; i++)
            {
                Funcionario funcionario1 = funcionarioList[i];
                if (nome.CompareTo(funcionario1.Nome) == 0)
                {

                    return funcionario1;
                }


            }

            return null;

        }
        static void MenuFuncionario(List<Cliente> clienteList, List<Funcionario> funcionarioList, List<Espera> analiseList, List<Cliente> aprovadoList)
        {
            int opc;
            do
            {
                Console.Write("\n\t>>> Menu Funcionário <<<\t");
                Console.WriteLine("\nO-Sair\n1-Cadastrar Funcionário\n2-Imprimir Funcionário\n3-Verificar/Aprovar Conta\n");
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
                        CadastrarFuncionario(funcionarioList);
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
                                Funcionario funcionario1 = ValidarFuncionario(funcionarioList);
                               
                                    funcionario1.ImprimirPessoa();
                                    funcionario1.ImprimirFuncionario();
                                
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
                    case 3:
                        Espera cliente = EsperaCliente(analiseList);
                        if (cliente != null)//tem solicitações
                        {
                            Funcionario funcionario = ValidarFuncionario(funcionarioList);
                            if (funcionario != null)
                            {
                                if (funcionario.Cargo.CompareTo("GERENTE") == 0)//é gerente e pode validar meu cliente, pode analisar e pode aprovar a conta.
                                {
                                    funcionario.AnalisarSolicitacaoAberturaConta(cliente);
                                    funcionario.AprovarAberturaConta(aprovadoList, cliente);
                                    Console.Write("Verificação realizada!");
                                }
                                else//cliente normal, pode validar meu cliente,pode analisar a conta apenas.
                                {
                                    funcionario.AnalisarSolicitacaoAberturaConta(cliente);
                                    Console.Write("Verificação realizada!");
                                }
                            }
                            else
                            {
                                Console.Write("Funcionário não encontrado");
                            }

                        }
                        else
                        {
                            Console.Write("Não há soicitações de abertura de conta pendentes");
                        }
                        break;
                }
            } while (opc != 0);
            MenuGeral();
        }

        static int MenuGeral()
        {
            int opc = 0;
            do
            {
                Console.Write("\n\t>>> Menu Geral <<<\t");
                Console.Write("\nVocê é: 0-Sair\n1-Já sou Cliente\n 2-Quero ser Cliente \n3-Sou Funcionário ");
                int sou = int.Parse(Console.ReadLine());
                return sou;
            } while (opc != 0);

        }
       
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Emprestimo emprestimo = new Emprestimo();
            Funcionario funcionario = new Funcionario();
            Poupanca poupanca = new Poupanca();
            Corrente corrente = new Corrente();
            List<Cliente> clienteList = new List<Cliente>();
            List<Funcionario> funcionarioList = new List<Funcionario>();
            List<Espera> esperaList = new List<Espera>();
            List<Cliente> aprovadoList = new List<Cliente>();

            int sou;
            do
            {
                sou = MenuGeral();


                if (sou == 0)
                {
                    Console.Write("Saindo");
                    Thread.Sleep(200);
                    Console.Write(" .");
                    Thread.Sleep(200);
                    Console.Write(" .");
                    Thread.Sleep(200);
                    Console.Write(" .");
                }

                if (sou == 1) //já sou cliente
                {
                    Cliente(clienteList, poupanca, corrente, esperaList,funcionario);
                }

                else if (sou == 2)
                { //quero ser cliente

                    CadastrarCliente(esperaList, clienteList);
                }

                else if (sou == 3)//sou funcionário


                    if (ValidarFuncionario(funcionarioList) == null)
                    {
                        Console.Write("\nFuncionario não existe");
                        // Environment.Exit(0);
                        // MenuCliente(abertura, emprestimo, funcionario, cartao, poupanca, corrente, clienteList, funcionarioList);
                        Console.Write("\nDeseja se cadastrar? 1-SIM 2-NÃO");
                        int cadResp = int.Parse(Console.ReadLine());
                        if (cadResp == 1)
                        {
                            CadastrarFuncionario(funcionarioList);
                            MenuFuncionario(clienteList, funcionarioList, esperaList, aprovadoList);
                        }
                        else
                        {
                            Console.Write("\nFim do atendimento!");
                           
                        }
                    }
                    else
                    {
                        MenuFuncionario(clienteList, funcionarioList, esperaList, aprovadoList);
                    }

                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            } while (sou != 0);
        }
    }
}

