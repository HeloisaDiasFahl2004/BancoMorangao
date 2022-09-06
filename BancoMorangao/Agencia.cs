using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Agencia
    {
        //criar listas de contas nessa agencia
        //int []NumeroAgencia=new int[2] ;//criei um vetor de agencias
        public int NumeroAgencia { get; set; }
        //Endereco endereco;
        public Agencia()
        {

        }
      //  public Agencia(int numeroAgencia)
        //{
       //     this.endereco= new Endereco();//instancio o objeto
      //  }
        
       public void CadastrarAgencia()
       {
            Console.Write("Informe 1-Agencia 001 \n 2-Agencia 002 \n");
            NumeroAgencia = int.Parse(Console.ReadLine());
            if (NumeroAgencia == 1)
            {
                Console.Write("Agencia 001");
                Console.Write("Endereço : Av. dos morangos gigantes\n N°500 \n Bairro: MorangoVilla\n Cidade: Morangolândia\n Estado: Fadalândia");
            }
            if(NumeroAgencia == 2)
            {
                Console.Write("Agencia 002");
                Console.Write("Endereço: Rua dos Moranguetes\n N°250 \n Bairro:MorangoCentro \nCidade: Morangolândia\n Estado: Fadalândia");
            }
       }
        public int ImprimirAgencia()
        {
            Console.Write("Informe 1-Agencia 001 \n 2-Agencia 002 \n");
            int NumeroAgencia = int.Parse(Console.ReadLine());
            if (NumeroAgencia == 1)
            {
               // Console.Write("Agencia 001");
                Console.Write("Endereço : Av. dos morangos gigantes\n N°500 \n Bairro: MorangoVilla\n Cidade: Morangolândia\n Estado: Fadalândia");
                return 001;            
            }
            if (NumeroAgencia == 2)
            {
                //Console.Write("Agencia 002");
                Console.Write("Endereço: Rua dos Moranguetes\n N°250 \n Bairro:MorangoCentro \nCidade: Morangolândia\n Estado: Fadalândia");
                return 002;
            }
            return 0;
        }

    }
}
