using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Conta
    {
        public int TipoConta { get; set; }// 1/2/3
        public int NumeroConta { get; set; }
        CartaoCredito cartao;
        public Conta()
        {

        }
        public Conta(int tipoConta, int numeroConta)
        {
            TipoConta = tipoConta;
            NumeroConta = numeroConta;
            this.cartao = new CartaoCredito();
        }
    }

}

