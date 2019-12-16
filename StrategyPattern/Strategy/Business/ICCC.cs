using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;
using StrategyPattern.Models;

namespace StrategyPattern.Business
{
    public class ICCC : Imposto
    {
        public void RealizaCalculo(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000) 
                Console.WriteLine( (orcamento.Valor / 100) * 5 );
            else if(orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                Console.WriteLine((orcamento.Valor / 100) * 7);
            else
                Console.WriteLine( ((orcamento.Valor / 100) * 8) + 30 );
        }
    }
}
