using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Cliente : Pessoa
    {
        public double Renda { get; set; }
        public string Estudante { get; set; }
        public int TipoConta { get; set; }

      
        public Cliente()//já vem da classe mãe
        {

        }
        public Cliente(double Renda, string Estudante)
        {
            this.Renda = Renda;
            this.Estudante = Estudante;

        }
        public void ImprimirCliente()
        {
            Console.Write("\nRenda: " + this.Renda);
            Console.Write("\nTipo Conta: " + this.TipoConta);

        }
        public Cliente SolicitarAberturaConta()
        {

            Console.Write("Renda: ");
            Renda = double.Parse(Console.ReadLine());
            Console.Write("Estudante(SIM/NÃO) ");
            Estudante = Console.ReadLine().ToUpper();
            Console.WriteLine("O gerente irá definir o tipo ideal de conta para você. ");
            //   Console.Write("Perfil(1-Univesritário\n2-Normal\n3-Vip): ");
            //   this.Perfil = Console.ReadLine();

            //bool aceitaConta = AbreConta(this.Renda,this.Estudante);
            //if (aceitaConta)
            //{
            //    //lista de aberturas de contas
            //    exp abra = new exp(this);
            //    contaAberta.contasAbertas.Add(abra); //atribuição por referencia, recebo objeto instanciado e só dentro da variavel recebo o valor
            //    Console.Write("\nSolicitação de abertura de conta encaminhada!");
            //}
            Console.Write("Solicitação encaminhada!");
            return new Cliente(Renda, Estudante);


        }
       
    }
}
