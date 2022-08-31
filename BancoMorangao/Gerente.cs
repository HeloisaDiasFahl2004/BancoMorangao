using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Gerente:Funcionario
    {
        public Gerente()
        {
           
        }
        public void AprovarAberturaConta()
        {
            Console.Write("Abertura realizada!");
        }
        public void AprovarEmprestimo()
        {
            Funcionario funcionario = new Funcionario();
            Cliente cliente = new Cliente();
            if (funcionario.VerificarEmprestimo(cliente) == true)
            {
                
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Console.Write("Empréstimo realizado!");
            }
               
        }


    }
}
