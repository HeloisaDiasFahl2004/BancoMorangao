using System;
using System.Threading;
using System.Threading.Tasks;
namespace BancoMorangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Cliente cliente = new Cliente();
            Funcionario funcionario = new Funcionario();
            Gerente gerente = new Gerente();
            CartaoCredito cartao = new CartaoCredito();
            int opc;
           
            do
            {
                Console.Write("\t>>> Menu <<<\t");
                Console.WriteLine("\nO-Sair \n1-Cadastrar\n2-Imprimir\n3-Solicitar Empréstimo\n4-Verificar Aprovação\n5-Desbloquear Cartão Crédito\n6-Parcelar Fatura\n");
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
                        pessoa.CadastrarPessoa();
                        Console.Write("Deseja Cadastrar 1-Cliente\n2-Funcionário");
                        int tipoPessoa = int.Parse(Console.ReadLine());
                        if (tipoPessoa == 1)
                        {
                            cliente.SolicitarAberturaConta();
                            Console.WriteLine("Aguarde, perfil em análise...");
                            Thread.Sleep(2000);
                            funcionario.VerificarTipoContaComBaseNaRenda(cliente);
                            Console.Write("Aguarde, gerente analisando sua solicitação");
                        }
                        if (tipoPessoa == 2)
                        {
                            funcionario.CadastrarFuncionario();
                            funcionario.VerificarTipoFuncionario();
                        }
                        break;
                    case 2:
                        Console.Write("Deseja imprimir seu cadastro? \n1-SIM\n2-NÃO\n");
                        int op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            pessoa.ImprimirPessoa(pessoa);
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
                            gerente.AprovarEmprestimo();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Verficar aprovação de: 1-Abertura Conta\n2-Empréstimo");
                        int opcao = int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            gerente.AprovarAberturaConta();
                        }
                        else
                        {
                            if (opcao == 2)
                            {
                                gerente.AprovarEmprestimo();
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
