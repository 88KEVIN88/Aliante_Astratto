using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Astratto
{
    public class Ruota : Composite
    {
        private Gomma _gomma;
        private Cerchione _cerchioni;

        public Gomma Gomme
        {
            get { return _gomma; }
            set { _gomma = value; }
        }
        public Cerchione Cerchioni
        {
            get { return _cerchioni; }
            set { _cerchioni = value; }
        }
        public Ruota()
        {
            Gomme = new Gomma();
            Cerchioni = new Cerchione();
        }
        public Ruota(Cerchione cerchioni, Gomma gomme)
        {
            Cerchioni = cerchioni;
            Gomme = gomme;
        }
        public Ruota(Ruota vecchio)
        {
            Gomme = vecchio.Gomme;
            Cerchioni = vecchio.Cerchioni;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Ruota other) || other == null)
            {
                return false;
            }

            return Gomme == other.Gomme && Cerchioni == other.Cerchioni;

        }
        public override void Add(Composite component)
        {

        }
        public override void Remove(int index)
        {

        }
        public override Composite Get(int index)
        {
            return null;
        }
        public override string ToString()
        {
            return $"Descrizione Gomma:{Gomme};Cerchioni:{Cerchioni}";
        }
        public override double Price()
        {
            return 0;
        }
    }
}

