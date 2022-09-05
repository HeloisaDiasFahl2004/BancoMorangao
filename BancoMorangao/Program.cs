using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
namespace BancoMorangao
{

    internal class Program
    {
        static void Gravar_Arquivo(Cliente cliente)
        {
            Console.WriteLine("Iniciando a Gravação de Dados...");
            try
            {
                StreamWriter sw = new StreamWriter("c:\\BancoMorangao\\Test.txt");  //Instancia um Objeto StreamWriter (Classe de Manipulação de Arquivos)
                                                                                    //sw.WriteLine("Treinamento de C#");  //Escreve uma linha no Arquivo
                                                                                    //sw.WriteLine("maria;araraquara;190;contato;"); //Exemplo de escrita - formato da escrita será de acordo com a necessidade do projeto
                sw.WriteLine(cliente);
                sw.Close();  // Comando para Fechar o Arquivo
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando o Bloco de Comandos.");
            }
        }
        private static Cliente Ler_Cliente_Arquivo()
        {
            //Outra forma de manipular dados de um arquivo
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\BancoMorangao\Test.txt"); //faz a leitura de todas as linhas de um arquivo

                string[] informacoes; //Controlará as informações de um produto

                List<string> dados = new List<string>(); //será utilizada para guardar os dados para criar um produto

                foreach (string line in lines) // Para cada uma das linhas recuperadas... (No nosso caso será apenas uma única linha)
                {
                    informacoes = line.Split(';');//divide os dados da linha e armazena em posições diferentes do vetor.  Utiliza o caracter delimitador como referência

                    if (informacoes.Length == 4) //Tamanho 4 devido à quantidade de informações que estruturam um Produto
                    {
                        for (int i = 0; i < informacoes.Length; i++)
                            dados.Add(informacoes[i]); //Para cada dado do Produto, ele percorre o vetor e adiciona na LIST(DADOS)
                    }
                    else
                        return new Cliente(); //Se não encontrar um Produto no arquivo, retornará um Produto Padrão (VAZIO).
                }
                return new Cliente();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando o Bloco de Comandos.");
            }
            Console.ReadKey();
            return new Cliente(); //Se chegar até aqui...deu algum problema...
        }
        static void Main(string[] args)
        {
            //  double Valor=0;
            //  COMO FAZER VETOR DE CLIENTES
            /* Pessoa []agenda = new Pessoa[3];
             for (int i = 0; i < 3; i++)
             {
                 agenda[i] = new Pessoa();
             }*/
            // Pessoa pessoa = new Pessoa();//classe abstrata, tenho q instanciar apenas as classes filhas, não as abstratas
            Cliente cliente = new Cliente();
            Abertura abertura = new Abertura();
            Emprestimo emprestimo = new Emprestimo();
            Funcionario funcionario = new Funcionario(emprestimo);
            CartaoCredito cartao = new CartaoCredito();
           
            Poupanca poupanca = new Poupanca();
            Corrente corrente = new Corrente();
            List<Cliente> clienteList = new List<Cliente>();
            List<Funcionario> funcionarioList = new List<Funcionario>();
            

            int opc = 0;

            do
            {
                //Menu separado, 1 pro cliente e 1 pro funcionário
                Console.Write("\n\t>>> Menu Geral <<<\t");
                Console.Write("\nVocê é: 0-Sair\n1-Cliente \n2-Funcionário");
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
                }
                else if (sou == 1)
                {
                    Console.Write("\t>>> Menu Cliente <<<\t");
                    Console.WriteLine("\nO-Sair \n1-Cadastrar\n2-Imprimir\n3-Solicitar Empréstimo\n4-Verificar Aprovação \n5-Desbloquear Cartão Crédito\n6-Parcelar Fatura\n7-Consultar Saldo\n8-Efetuar Depósito\n9-Efetuar Transferência\n10-Efetuar Saque\n11-Consultar Limite Cartão Crédito\n12-Consultar fatura Cartão Crédito\n13-Consultar Extrato");
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
                        case 1://só cadastro
                            Console.WriteLine("Cadastramento iniciado: ");

                            cliente.CadastrarPessoa();

                            clienteList.Add(cliente);
                            Console.Write("Deseja solicitar abertura de conta?\n1-SIM\n2-NÃO) ");
                            int abre = int.Parse(Console.ReadLine());
                            if (abre == 1)
                            {
                                cliente.SolicitarAberturaConta();

                                // Gravar_Arquivo(cliente);
                                // Ler_Cliente_Arquivo();
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
                            break;
                        case 2:
                            Console.Write("Deseja imprimir seu cadastro? \n1-SIM\n2-NÃO\n");
                            int op = int.Parse(Console.ReadLine());
                            if (op == 1)
                            {
                                if (clienteList.Count == 0)
                                {
                                    Console.Write("Não há clientes cadastrados");
                                }
                                cliente.ImprimirPessoa();
                                cliente.ImprimirCliente();
                                //Ler_Cliente_Arquivo();
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
                            Console.Write("Deseja solicitar um empréstimo?\n1-SIM\n2-NÃO) ");
                            int empreste = int.Parse(Console.ReadLine());
                            if (empreste == 1)
                            {
                                cliente.SolicitarEmprestimo(emprestimo);
                            }
                            else
                            {
                                Console.Write("Solicitação não realiada!");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Verificar análise de: 1-Abertura Conta\n2-Empréstimo");
                            int opcao = int.Parse(Console.ReadLine());
                            if (opcao == 1)
                            {
                                List<exp> conta = abertura.contasAbertas;//encontro o objeto q preciso

                                abertura.contasAbertas.ForEach(el =>
                                {
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
                                funcionario.AnalisarSolicitacaoAberturaConta(cliente);
                                //  funcionario.AprovarAberturaConta();
                            }
                            else
                            {
                                if (opcao == 2)
                                {

                                    List<teste> emp = funcionario.VerificarEmprestimo(cliente);
                                    emp.ForEach(el => Console.WriteLine("Valor: " + el.valor + " Status: " + el.status));
                                }
                                else
                                {
                                    Console.Write("Opção inválida");
                                }
                            }
                            break;
                        case 5:
                            cartao.DesbloquearBloquear(cliente);
                            break;
                        case 6:
                            cartao.ParcelarFaturas(cliente);
                            break;
                        case 7:
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
                        case 8:
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
                        case 9:
                            Console.Write("Deseja transferir de qual conta\n1-Poupança\n2-Corrente");
                            int cTransf = int.Parse(Console.ReadLine());
                            if (cTransf == 1)
                            {
                                poupanca.VerSaldo();
                            }
                            else if (cTransf == 2)
                            {
                                corrente.VerSaldo();
                            }
                            else
                            {
                                Console.Write("Opção inválida!");
                            }
                            break;
                        case 10:
                            Console.Write("Deseja sacar de qual conta\n1-Poupança\n2-Corrente");
                            int cSac = int.Parse(Console.ReadLine());
                            if (cSac == 1)
                            {
                                poupanca.VerSaldo();
                            }
                            else if (cSac == 2)
                            {
                                corrente.VerSaldo();
                            }
                            else
                            {
                                Console.Write("Opção inválida!");
                            }
                            break;
                        case 11:
                            cartao.ConsultarLimiteCartao(cliente);
                            break;
                        case 12:
                            cartao.ConsultarFaturaCartao(cliente);
                            break;
                        case 13:
                            Console.Write("Consultando extrato da conta Corrente");
                            corrente.ConsultarExtrato();
                            break;
                    }
                }
                else
                {
                    if (sou == 2)
                    {
                        Console.Write("\t>>> Menu Funcionário <<<\t");
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
                                funcionario.CadastrarPessoa();
                                funcionario.CadastrarFuncionario();
                                funcionarioList.Add(funcionario);
                                break;
                            case 2:
                                Console.Write("Deseja imprimir seu cadastro? \n1-SIM\n2-NÃO\n");
                                int op = int.Parse(Console.ReadLine());
                                if (op == 1)
                                {
                                    if (funcionarioList.Count == 0)
                                    {
                                        Console.Write("Não há clientes cadastrados");
                                    }
                                    else
                                    {
                                        funcionario.ImprimirPessoa();
                                        funcionario.ImprimirFuncionario();
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
                                if (funcionario.AnalisarSolicitacaoAberturaConta(cliente))
                                {
                                    funcionario.AprovarAberturaConta();
                                }
                                else
                                {
                                    Console.Write("Não há soicitações de abertura de conta pendentes");
                                }
                                break;
                            case 4:
                                if (funcionario.VerificarEmprestimo(cliente) != null)
                                {
                                    Console.Write("Verificação realizada");
                                    funcionario.AprovarEmprestimo(cliente);
                                }
                                else
                                {
                                    Console.Write("Não há solicitações de empréstimo pendentes");
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.Write("OPÇÃO INVÁLIDA");
                    }
                }
            } while (opc != 0);
        }
    }
}

