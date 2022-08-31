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
        public Endereco(string rua, int numero, string bairro, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;

        }
        public void CadastrarEndereco()
        {
            Console.Write("Informe sua rua: ");
            this.Rua = (Console.ReadLine());
            Console.Write("Informe seu numero: ");
            this.Numero = int.Parse(Console.ReadLine());
            Console.Write("Informe seu bairro: ");
            this.Bairro = Console.ReadLine();
            Console.Write("Informe sua cidade: ");
            this.Cidade = Console.ReadLine();
            Console.Write("Informe seu estado: ");
            this.Estado = Console.ReadLine();
        }
        public void ImprimirEndereco()
        {
            Console.Write("\nRua: " + this.Rua + "\nNumero: " + this.Numero + "\nBairro: " + this.Bairro + "\nCidade: " + this.Cidade + "\nEstado: " + this.Estado);
        }
    }
}
