using StrategyPattern.Interfaces;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.TemplateMethod.Business
{
    public abstract class TemplateImpostoCondicional : Imposto
    {
        public void RealizaCalculo(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                MaximaTaxacao(orcamento);
            }

            MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
