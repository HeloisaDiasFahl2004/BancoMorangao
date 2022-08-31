using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class CartaoCredito
    {
        long NumeroCartao { get; set; }
        double Limite { get; set; } //vem já de acordo com o tipo conta
        DateTime Vencimento { get; set; }
        double SaldoFaturas { get; set; }
        bool Status { get; set; }
        public CartaoCredito()
        {

        }
     
        public void DesbloquearBloquear()
        {
            Cliente cliente = new Cliente();
            cliente.SolicitarDesbloquearCartao();
        }
        public void ConsultarLimiteCartao()
        {
            Console.Write(Limite);
        }
        public void ConsultarFaturaCartao()
        {
            Console.Write(" Exibindo Fatura " + SaldoFaturas);//list
        }
        public void ParcelarFaturas()
        {
            Console.Write("Deseja parcelar a fatura?(SIM/NÃO)");
            string resp = Console.ReadLine().ToUpper();
            if(resp== "SIM")
            {
                Console.Write("Em quantas vezes? ");
                int vezesParc = int.Parse(Console.ReadLine());
                Console.Write("Ficará " + vezesParc + " de R$ " + SaldoFaturas / vezesParc);
            }
            else
            {
                if (resp == "NÃO")
                {
                    Console.Write("Operação cancelada!");
                }
                else Console.Write("Opção inválida!");
            }
        }
        public void PagarFatura()
        {
            Console.Write("Deseja realizar o pagamento da fatura:(SIM/NÃO) ");
            string resp=Console.ReadLine().ToUpper();
            if (resp == "SIM")
            {
                Console.Write("Pagamento Realizado");
            }
            else
            {
                if (resp == "NÃO")
                {
                    Console.Write("Operação cancelada!");
                }
                else Console.Write("Opção inválida!");
            }
        }
    }
}
