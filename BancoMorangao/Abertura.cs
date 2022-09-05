using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Abertura
    {
        public Abertura()
        {
            contasAbertas = new List<exp>();
        }
        public List<exp> contasAbertas { get; set; }
        public void AlteraDescricao(exp exp, string desc)
        {
            for (int i = 0; i < contasAbertas.Count; i++)
            {
                if (exp.cliente == contasAbertas[i].cliente && exp.dataPedido == contasAbertas[i].dataPedido)
                {
                    contasAbertas[i].descricao = desc;
                }

            }
        }
    }
    internal class exp
    {
        public Cliente cliente { get; set; }
        public string descricao { get; set; }
        public DateTime dataPedido { get; set; }
        public exp(Cliente cliente)
        {
            descricao = "Em análise";
            this.cliente = cliente;
            dataPedido = DateTime.Now;
        }
    }
}
