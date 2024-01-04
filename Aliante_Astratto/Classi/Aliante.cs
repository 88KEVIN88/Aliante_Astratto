using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Astratto
{
    internal class Aliante : Composite
    {
        private List<Composite> _compotenti;

        public List<Composite> Componenti
        {
            get { return _compotenti; }
            set { _compotenti = value; }
        }
        public Aliante()
        {
            Componenti = new List<Composite>();
        }
        public Aliante(List<Composite> compotenti, List<Composite> componenti)
        {
            Componenti = componenti;       
        }
        public Aliante(Aliante vecchio)
        {
            Componenti = vecchio.Componenti;
        }
    }
}
