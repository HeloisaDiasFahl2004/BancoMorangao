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
       // public List<cartaoCredito> cartao { get; set; }
        public CartaoCredito()
        {
            //cartao = new List<cartaoCredito>();
        }

        public void Desbloquear(Cliente cliente)
        {
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
            if (TipoConta == 2)
            {
                Limite = 800;
            }
            if (TipoConta == 3)
            {
                Limite = 50000;
            }
            Console.Write("Limite Cartão Crédito: " + Limite);
        }
        /* public double CompraCartao(Cliente cliente)//saque
         {
             Console.Write("Informe quanto deseja passar no cartão: ");
             double saqueCartao = double.Parse(Console.ReadLine());

             this.ConsultarLimiteCartao(cliente);
             Limite -= saqueCartao; //tiro o valor que passei no cartao do limite
             return saqueCartao;
         }
         public void ConsultarFaturaCartao(Cliente cliente)
         {
             List<Cartao> fatura = compras.FindAll(fatura => fatura.cliente == cliente);//encontro o objeto q preciso
             fatura.ForEach(el=>compras.Add(saqueCartao));//adiciono na lista a compra
             Console.Write(" Exibindo Fatura: " + compras + " Data Fatura: " + DateTime.Now.ToString("dd/MM/yyyy"));
         }
         public void ParcelarFaturas(Cliente cliente)
         {
             Console.Write("Deseja parcelar a fatura?\n1-SIM\n2-NÃO");
             int resp = int.Parse(Console.ReadLine());
             if (resp == 1)
             {
                 Console.Write("Em quantas vezes? ");
                 int vezesParc = int.Parse(Console.ReadLine());
                 Console.Write("Ficará " + vezesParc + " de R$ ");//+SaldoFaturas / vezesParc);
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
         public void PagarFatura(Cliente cliente)
         {
             Console.Write("Deseja realizar o pagamento da fatura:\n 1-SIM\n2-NÃO ");
             int resp = int.Parse(Console.ReadLine());
             if (resp == 1)
             {
                 this.ParcelarFaturas(cliente);
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
     }*/
        /*  internal class cartaoCredito
        {
            public Cliente cliente { get; set; }
            DateTime Credito { get; set; }
            string Status { get; set; }
          /*  public void Cartao(Cliente cliente, DateTime credito, string status)
            {
                this.cliente = cliente;
                this.Credito = DateTime.Now;//pega a hora do pc
                this.Status = "Bloqueado!";//de inicio o cartão está bloqueado
            }
          */

    }
