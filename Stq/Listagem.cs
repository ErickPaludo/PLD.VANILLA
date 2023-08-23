using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stq
{
    internal class Listagem
    {
        public string Bars { get; set; }
        public string Prodct { get; set; }
        public string Color { get; set; }
        public string PesoN{get; set;}
        public decimal Peso { get; set; }
        public int Quant { get; set; }
        public decimal Preco { get; set; }
        public decimal Total { get; set; }

        public Listagem(string bars, string prodct, string color,string pesoN, decimal peso, int quant, decimal preco, decimal total)
        {
            Bars = bars;
            Prodct = prodct;
            Color = color;
            PesoN = pesoN;
            Peso = peso;
            Quant = quant;
            Preco = preco;
            Total = total;
        }
    }
}
