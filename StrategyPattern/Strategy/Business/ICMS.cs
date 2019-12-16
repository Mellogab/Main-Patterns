using System;
using StrategyPattern.Interfaces;
using StrategyPattern.Models;

namespace StrategyPattern.Business
{
    public class ICMS : Imposto
    {
        public void RealizaCalculo(Orcamento orcamento)
        {
            Console.WriteLine( ((orcamento.Valor / 100) * 5) + 50.00 );
        }
    }
}
