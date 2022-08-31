using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Pessoa
    {
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }
        Endereco endereco;
        long Telefone { get; set; }
        long Cpf { get; set; }
        long Rg { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, DateTime dataNascimento, long telefone, long cpf, long rg)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            this.endereco = new Endereco();//crio objeto
            Telefone = telefone;
            Cpf = cpf;
            Rg = rg;

        }

        int i = 0;
        public void CadastrarPessoa()
        {
             i = 0;
            Console.Write("Informe seu nome: ");
            this.Nome = Console.ReadLine();
            Console.Write("Informe sua data de nascimento: ");
            this.DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Informe seu telefone: ");
            this.Telefone = long.Parse(Console.ReadLine());
            Console.Write("Informe os seguintes campos: ");
            Endereco endereco = new Endereco();
            endereco.CadastrarEndereco();
            Console.Write("Informe seu CPF: ");
            this.Cpf = long.Parse(Console.ReadLine());
            Console.Write("Informe seu RG: ");
            this.Rg = long.Parse(Console.ReadLine());
            i++;
        }
        public void ImprimirPessoa(Pessoa pessoa)
        {
            if (i < 1)
            {
                Console.WriteLine("Não há cadastramento ainda!");
            }
            else{
                if(i >=1)
                Console.Write("\nNome: " + this.Nome);
                Console.Write("\nData Nascimento: " + this.DataNascimento);
                Console.Write("\nEndereço ");
                endereco = new Endereco();
                pessoa.endereco.ImprimirEndereco(pessoa);
                Console.Write("\nTelefone: " + this.Telefone);
                Console.Write("\nCPF: " + this.Cpf);
                Console.Write("\nRG: " + this.Rg);
            }
        }

    }

}
