using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    //internal class Abertura
    //{

    //    public List<espera> contasPendentes { get; set; }
    //    public Abertura()
    //    {
    //        contasAbertas = new List<espera>();
    //    }
    //    public void AlteraDescricao(espera espera, string desc)
    //    {
    //        for (int i = 0; i < contasAbertas.Count; i++)
    //        {
    //            if (espera.cliente == contasAbertas[i].cliente && espera.dataPedido == contasAbertas[i].dataPedido)
    //            {
    //                contasAbertas[i].descricao = desc;

    //            }
    //        }
    //    }
    //}
    internal class Espera
    {
        public Cliente cliente { get; set; }
        public string descricao { get; set; }//status da conta
        public DateTime dataPedido { get; set; }
        public Espera(Cliente cliente)
        {
            descricao = "Em análise";
            this.cliente = cliente;
            dataPedido = DateTime.Now;//data do pc
        }

    }
}
