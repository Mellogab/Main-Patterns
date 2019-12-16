using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.ChainResponsibility.Interfaces;
using StrategyPattern.Models;
using StrategyPattern.Business;

namespace StrategyPattern.ChainResponsibility.Business
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto PrimeiraClasse = new DescontoPorCincoItens();
            IDesconto SegundaClasse = new DesoncotPorMaisDeQuinhentosReais();
            IDesconto UltimaClasse = new SemDesconto();

            PrimeiraClasse.Proximo = SegundaClasse;
            SegundaClasse.Proximo = UltimaClasse;

            return PrimeiraClasse.Desconta(orcamento);
        }
    }
}
