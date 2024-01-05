using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Astratto
{
    internal class Coda : Composite
    {
        public double _lenght;

        public double Lenght
        {
            get { return _lenght; }
            set
            {
                if(_lenght >0)
                {
                    _lenght = value;
                }
                else
                {
                    throw new ArgumentException("La Lunghezza deve essere > 0");
                }
            }
        }
        public Coda()
        {
           Lenght = 0;

        }
        public Coda(double lenght)
        {
            Lenght= lenght;
        }
        public Coda(Coda vecchia)
        {
            Lenght = vecchia.Lenght;
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Coda other))
            {
                return false;
            }
            return Lenght == other.Lenght;
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
            return $"Lunghezza della coda:{Lenght}";
        }
        public override double Price()
        {
            return Lenght * 3;
        }
    }
}
