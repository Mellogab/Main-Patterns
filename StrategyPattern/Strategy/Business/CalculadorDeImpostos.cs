using StrategyPattern.Interfaces;
using StrategyPattern.Models;

namespace StrategyPattern.Business
{
    public class CalculadorDeImpostos
    {
        public void Calculo(Orcamento orcamento, Imposto estrategia)
        {
            estrategia.RealizaCalculo(orcamento);
        }
    }
}
