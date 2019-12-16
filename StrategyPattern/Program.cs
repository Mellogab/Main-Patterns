using System;
using StrategyPattern.Business;
using StrategyPattern.ChainResponsibility.Business;
using StrategyPattern.Interfaces;
using StrategyPattern.Models;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy Pattern
            Orcamento orcamento = new Orcamento(50);
            Imposto imposto = new ISS();

            new CalculadorDeImpostos().Calculo(orcamento, imposto);

            imposto = new ICMS();
            new CalculadorDeImpostos().Calculo(orcamento, imposto);

            imposto = new ICCC();
            new CalculadorDeImpostos().Calculo(orcamento, imposto);

            Console.ReadKey();
            #endregion
            
            #region Chain Of Resposibility
            try
            {
                CalculadorDeDescontos calculador = new CalculadorDeDescontos();
                Orcamento orcamento_ = new Orcamento(500.0);

                orcamento_.AdicionaItem(new Item("CANETA", 250.0));
                orcamento_.AdicionaItem(new Item("LAPIS", 250.0));
                orcamento_.AdicionaItem(new Item("LAPIS", 250.0));
                orcamento_.AdicionaItem(new Item("LAPIS", 250.0));
                orcamento_.AdicionaItem(new Item("LAPIS", 250.0));
                orcamento_.AdicionaItem(new Item("LAPIS", 250.0));
                
                double desconto = calculador.Calcula(orcamento_);

                Console.WriteLine(desconto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}
