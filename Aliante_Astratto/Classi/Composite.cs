using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Astratto
{
    public abstract class Composite
    {
        public abstract void Add(Composite component);
        public abstract void Remove(int index);
        public abstract Composite Get(int index);
        public new abstract bool Equals(object obj);
        public new abstract string ToString();
        public abstract double Price();


    }
}
