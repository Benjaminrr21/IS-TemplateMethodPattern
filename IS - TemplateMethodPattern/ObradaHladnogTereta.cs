using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS___TemplateMethodPattern
{
    public class ObradaHladnogTereta : ObradaNarudzbine
    {
        public List<Narudzbina> narudzbine = new List<Narudzbina>();

        public override void PrimiNarudzbinu()
        {
            var n = new Narudzbina();
            n.Naziv = "Lekovi";
            narudzbine.Add(n);
            if (narudzbine.Count == 1)
            {
                n.RedniBroj = 1;
            }
            else n.RedniBroj = narudzbine.Max(n => n.RedniBroj) + 1;
            n.TipPosiljke = "Hladni teret";
        }
        public override void IzmeriNarudzbinu()
        {
            Console.WriteLine("Merenje hladnog tereta...");
            var n = narudzbine.Last();
            n.Tezina = 500;
        }

        public override void PosaljiNarudzbinu()
        {
            Console.WriteLine("Hladni teret se salje specijalnim teretnim kamionom sa mogucnoscu" +
                "podesavanja niske temperature. ");
        }
        public override void SpakujNarudzbinu()
        {
            Console.WriteLine("Hladni teret se pakuje pomocu hermeticki zatvorenih paketa.");
        }
    }
}
