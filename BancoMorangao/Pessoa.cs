using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco endereco { get; set; }
        public long Telefone { get; set; }
        public long Cpf { get; set; }
        public long Rg { get; set; }
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
        public Pessoa CadastrarPessoa()
        {
        
            Console.Write("Informe seu nome: ");
            this.Nome = Console.ReadLine();
            Console.Write("Informe sua data de nascimento: ");
            this.DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Informe seu telefone: ");
            this.Telefone = long.Parse(Console.ReadLine());
            this.endereco= new Endereco();
            endereco.CadastrarEndereco();
            Console.Write("Informe seu CPF: ");
            this.Cpf = long.Parse(Console.ReadLine());
            Console.Write("Informe seu RG: ");
            this.Rg = long.Parse(Console.ReadLine());
            return new Pessoa(Nome,DataNascimento,Telefone,Cpf,Rg);
           
        }
        public void ImprimirPessoa()
        {
                Console.Write("\nNome: " + this.Nome);
                Console.Write("\nData Nascimento: " + this.DataNascimento);
                Console.Write("\nEndereço ");
                endereco.ImprimirEndereco();
                Console.Write("\nTelefone: " + this.Telefone);
                Console.Write("\nCPF: " + this.Cpf);
                Console.Write("\nRG: " + this.Rg);
        }

    }

}
