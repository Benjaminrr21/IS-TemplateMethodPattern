using System;
using System.Collections.Generic;
namespace IS___TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Narudzbina n1 = new Narudzbina();
            ObradaHladnogTereta obradaStandardnog = new ObradaHladnogTereta();
            obradaStandardnog.PrimiNarudzbinu();
            obradaStandardnog.IzmeriNarudzbinu();
            obradaStandardnog.SpakujNarudzbinu();
            obradaStandardnog.PosaljiNarudzbinu();

            Narudzbina n2 = new Narudzbina();
            ObradaStandardnogTereta obradaHladnog = new ObradaStandardnogTereta();
            obradaHladnog.PrimiNarudzbinu();
            obradaHladnog.IzmeriNarudzbinu();
            obradaHladnog.SpakujNarudzbinu();
            obradaHladnog.PosaljiNarudzbinu();

            Console.WriteLine("Narudzbine:");
            foreach (var item in obradaStandardnog.narudzbine)
            {
                Console.WriteLine($"Redni broj: {item.RedniBroj}  Naziv: {item.Naziv}  Tip: {item.TipPosiljke}  Tezina:{item.Tezina}\n");
            }
            foreach (var item in obradaHladnog.narudzbine)
            {
                Console.WriteLine($"Redni broj: {item.RedniBroj}  Naziv: {item.Naziv}  Tip: {item.TipPosiljke}  Tezina:{item.Tezina}\n");
            }
        }
    }
}