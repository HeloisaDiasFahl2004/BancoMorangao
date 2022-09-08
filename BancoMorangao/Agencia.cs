using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Agencia
    {
        public int NumeroAgencia { get; set; }
       
        public Agencia()
        {

        }
        public void ImprimirAgencia()
        {
            Console.Write("\nAgencia 001");
            Console.Write("\nEndereço : Av. dos morangos gigantes\n N°500 \n Bairro: MorangoVilla\n Cidade: Morangolândia\n Estado: Fadalândia");
        
        }

    }
}
