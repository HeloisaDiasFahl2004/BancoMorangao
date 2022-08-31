using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Conta
    {
        int TipoConta { get; set; }// 1/2/3
        int NumeroConta { get; set; }
        string Senha { get; set; }
        CartaoCredito cartao;

        public Conta()
        {

        }
        public Conta(int tipoConta, int numeroConta, string senha)
        {
            TipoConta = tipoConta;
            NumeroConta = numeroConta;
            Senha = senha;
            this.cartao = new CartaoCredito();//crio o objeto
        }
        public void ConsultarSaldo()
        {

        }
        public void ConsultarExtrato()
        {

        }
        public void Sacar()
        {

        }
        public void Depositar()
        {

        }
        public void Transferir()
        {

        }
        public void EfetuarLogin()
        {

        }
    }
}
