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
        public void ConsultarLimiteCartao(Cliente cliente)
        {
            Console.Write("Informe o tipo de conta(1-Universitária 2-Normal 3-Vip)");
            int TipoConta = int.Parse(Console.ReadLine());
            if (TipoConta == 1)
            {
                Limite = 600;
            }
            if(TipoConta == 2)
            {
                Limite = 800;
            }
            if (TipoConta == 3)
            {
                Limite = 50000;
            }
            Console.Write("Limite Cartão Crédito" + Limite);
        }
        public void ConsultarFaturaCartao()
        {
            Console.Write(" Exibindo Fatura " + SaldoFaturas);//list
        }
        public void ParcelarFaturas()
        {
            Console.Write("Deseja parcelar a fatura?\n1-SIM\n2-NÃO");
            int resp = int.Parse(Console.ReadLine());
            if(resp== 1)
            {
                Console.Write("Em quantas vezes? ");
                int vezesParc = int.Parse(Console.ReadLine());
                Console.Write("Ficará " + vezesParc + " de R$ " + SaldoFaturas / vezesParc);
            }
            else
            {
                if (resp == 2)
                {
                    Console.Write("Operação cancelada!");
                }
                else Console.Write("Opção inválida!");
            }
        }
        public void PagarFatura()
        {
            Console.Write("Deseja realizar o pagamento da fatura:\n 1-SIM\n2-NÃO ");
            int resp=int.Parse(Console.ReadLine());
            if (resp == 1)
            {
                Console.Write("Pagamento Realizado");
            }
            else
            {
                if (resp == 2)
                {
                    Console.Write("Operação cancelada!");
                }
                else Console.Write("Opção inválida!");
            }
        }

       
        


    }
}
