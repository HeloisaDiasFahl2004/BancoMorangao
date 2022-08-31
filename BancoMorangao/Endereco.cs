using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Endereco
    {
        string Rua { get; set; }
        int Numero { get; set; }
        string Bairro { get; set; }
        string Cidade { get; set; }
        string Estado { get; set; }

        public Endereco()
        {

        }
        public void CadastrarEndereco()
        {
            Console.Write("Informe sua rua: ");
            Rua = (Console.ReadLine());
            Console.Write("Informe seu numero: ");
            Numero = int.Parse(Console.ReadLine());
            Console.Write("Informe seu bairro: ");
            Bairro = Console.ReadLine();
            Console.Write("Informe sua cidade: ");
            Cidade = Console.ReadLine();
            Console.Write("Informe seu estado: ");
            Estado = Console.ReadLine();
        }
        public void ImprimirEndereco(Pessoa pessoa)
        {
            Console.Write("\nRua: " + this.Rua + "\nNumero: " + this.Numero + "\nBairro: " + this.Bairro + "\nCidade: " + this.Cidade + "\nEstado: " + this.Estado);
        }
    }
}
