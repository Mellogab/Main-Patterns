using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.ChainResponsibility.Interfaces;
using StrategyPattern.Models;

namespace StrategyPattern.ChainResponsibility.Business
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }
    }
}
