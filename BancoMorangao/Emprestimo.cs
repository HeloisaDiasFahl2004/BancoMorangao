using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMorangao
{
    internal class Emprestimo
    {
        public List<teste> emprestimos { get; set; }

        public Emprestimo()
        {
            emprestimos = new List<teste>();
        }
        public void AlteraStatus(teste teste,string status)
        {
            for (int i = 0; i < emprestimos.Count; i++)
            {
                if (teste.cliente == emprestimos[i].cliente && teste.dataCriacao == emprestimos[i].dataCriacao)
                {
                    emprestimos[i].status = status;
                }
            }
        }

    }
    internal class teste
    {
        public Cliente cliente { get; set; }
        public double valor { get; set; }
        public string status { get; set; }
        public DateTime dataCriacao { get; set; }

        public teste(Cliente cliente, double valor)
        {
            status = "Em análise";
            this.cliente = cliente;
            this.valor = valor;
            dataCriacao = DateTime.Now;
        }
    }

}
