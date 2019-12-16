using System;
using StrategyPattern.Interfaces;
using StrategyPattern.Models;

namespace StrategyPattern.Business
{
    public class ISS : Imposto
    {
        public void RealizaCalculo(Orcamento orcamento)
        {
            Console.WriteLine( (orcamento.Valor / 100) * 6);
        }
    }
}
