using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Agencia
    {
        int []NumeroAgencia=new int[2] ;//criei um vetor de agencias
        int i;
        Endereco endereco;
        public Agencia()
        {

        }
        public Agencia(int numeroAgencia)
        {
            
            this.endereco= new Endereco();//instancio o objeto
        }
       public void CadastrarAgencia()
       {
            for (i = 0; i < NumeroAgencia.Length; i++)
            {
                NumeroAgencia[i] = (i+1);
                Console.Write("Endereço ");
                Endereco endereco = new Endereco();
                endereco.CadastrarEndereco();
            }
       }
       
    }
}
