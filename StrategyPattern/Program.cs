using System;
using StrategyPattern.Business;
using StrategyPattern.ChainResponsibility.Business;
using StrategyPattern.Interfaces;
using StrategyPattern.Models;
using StrategyPattern.TemplateMethod.Business;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy Pattern
            Orcamento strategy = new Orcamento(50);
            Imposto imposto = new ISS();

            new CalculadorDeImpostos().Calculo(strategy, imposto);

            imposto = new ICMS();
            new CalculadorDeImpostos().Calculo(strategy, imposto);

            imposto = new ICCC();
            new CalculadorDeImpostos().Calculo(strategy, imposto);

            
            #endregion
            
            #region Chain Of Resposibility
            try
            {
                CalculadorDeDescontos calculador = new CalculadorDeDescontos();
                Orcamento chain = new Orcamento(500.0);

                chain.AdicionaItem(new Item("CANETA", 250.0));
                chain.AdicionaItem(new Item("LAPIS", 250.0));
                chain.AdicionaItem(new Item("LAPIS", 250.0));
                chain.AdicionaItem(new Item("LAPIS", 250.0));
                chain.AdicionaItem(new Item("LAPIS", 250.0));
                chain.AdicionaItem(new Item("LAPIS", 250.0));
                
                double desconto = calculador.Calcula(chain);

                Console.WriteLine(desconto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Template Method
            ICPP icpp = new ICPP();
            IKCV ikcv = new IKCV();
            IHIT ihit = new IHIT();

            Orcamento method = new Orcamento(500);

            if (icpp.DeveUsarMaximaTaxacao(method))
            {
                double maxima = icpp.MaximaTaxacao(method);
                Console.WriteLine(maxima);
            }
            else
            {
                double minima = icpp.MinimaTaxacao(method);
                Console.WriteLine(minima);
            }

            method.AdicionaItem(new Item("ITEM 1",500));
            method.AdicionaItem(new Item("ITEM 1", 500));

            if (ikcv.DeveUsarMaximaTaxacao(method))
            {
                double ikvc_minima = ikcv.MaximaTaxacao(method);
                Console.WriteLine(ikvc_minima);
            }
            else
            {
                double ikvc_maxima = ikcv.MinimaTaxacao(method);
                Console.WriteLine(ikvc_maxima);
            }

            if (ihit.DeveUsarMaximaTaxacao(method))
            {
                double ihit_max = ihit.MaximaTaxacao(method);
                Console.WriteLine(ihit_max);
            }
            else
            {
                double ihit_min = ihit.MinimaTaxacao(method);
                Console.WriteLine(ihit_min);
            }

            Console.ReadKey();
            #endregion
        }
    }
}
