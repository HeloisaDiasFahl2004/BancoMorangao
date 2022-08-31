using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Agencia
    {
        int NumeroAgencia { get; set; }
        Endereco endereco;
        public Agencia()
        {

        }
        public Agencia(int numeroAgencia)
        {
            NumeroAgencia= numeroAgencia;
            this.endereco= new Endereco();//instancio o objeto
        }
        public void CadastrarAgencia()
        {
            Console.Write("Informe o numero da agência: ");
            this.NumeroAgencia = int.Parse(Console.ReadLine());
            Console.Write("Endereço ");
            Endereco endereco = new Endereco();
            endereco.CadastrarEndereco();
        }

    }
}
