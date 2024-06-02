using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS___TemplateMethodPattern
{
    public abstract class ObradaNarudzbine
    {
        public void ObradiNarudzbinu()
        {
            PrimiNarudzbinu();
            IzmeriNarudzbinu();
            SpakujNarudzbinu();
            PosaljiNarudzbinu();
        }

        public abstract void SpakujNarudzbinu();
        public abstract void PosaljiNarudzbinu();
        public abstract void PrimiNarudzbinu();
        public abstract void IzmeriNarudzbinu();

    }
}
