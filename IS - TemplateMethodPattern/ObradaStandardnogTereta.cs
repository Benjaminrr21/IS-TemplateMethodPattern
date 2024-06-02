using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS___TemplateMethodPattern
{
    public class ObradaStandardnogTereta : ObradaNarudzbine
    {
        public List<Narudzbina> narudzbine = new List<Narudzbina>();

        public override void PrimiNarudzbinu()
        {
            var n = new Narudzbina();
            n.Naziv = "Gradjevinski materijal";
            narudzbine.Add(n);
            if (narudzbine.Count == 1)
            {
                n.RedniBroj = 1;
            }
            else n.RedniBroj = narudzbine.Max(n => n.RedniBroj) + 1;
            n.TipPosiljke = "Standardni teret";
        }
        public override void IzmeriNarudzbinu()
        {
            Console.WriteLine("Merenje standardnog tereta...");
            var n = narudzbine.Last();
            n.Tezina = 300;
        }

        public override void PosaljiNarudzbinu()
        {
            Console.WriteLine("Standardni teret se salje klasicnim teretnim kamionom sa prikolicom.");
        }

       

        public override void SpakujNarudzbinu()
        {
            Console.WriteLine("Standardni teret se pakuje pomocu paleta, kutija i oblaze se ambalazom.");        }
    }
}
