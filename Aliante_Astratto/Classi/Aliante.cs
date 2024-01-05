using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Astratto
{
    public class Aliante : Composite
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
        public override bool Equals(object obj)
        {
            if (!(obj is Aliante otherAliante) || otherAliante.Componenti.Count != Componenti.Count)
            {
                return false;
            }

            return Componenti.SequenceEqual(otherAliante.Componenti);

        }
        public override void Remove(int index)
        {
            Componenti.RemoveAt(index);
        }
        public override Composite Get(int index)
        {
            if(Componenti.Count > index)
            {
                return Componenti[index];
            }
            return null;
        }
        public override string ToString()
        {
            string stringa = "";
            foreach(var componetni in Componenti)
            {
                stringa += componetni.ToString();
            }
            return stringa;
        }
        public override double Price()
        {
            double totale = 0;
            foreach(var componetni in Componenti)
            {
                totale += componetni.Price();

            }
            return totale;
        }
        public override void Add(Composite componente)
        {
            Componenti.Add(componente);
        }
    }
}
