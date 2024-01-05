using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Astratto
{
    public class Ala : Composite
    {
        private double _length;
        private double _width;

        private double Lenght
        {
            get { return _length; }
            set
            {
                if (_length > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("La lunghezza deve essere >0");
                }
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if(_width > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException("La larghezza alare deve essere >0");
                }
            }
        }
        public Ala()
        {
            _width=0;
            _length=0;
        }
       public Ala(double length,double width)
       {
            _length = length;
            _width = width;
       }
       public Ala(Ala vecchia)
       {
            Lenght=vecchia.Lenght;
            Width = vecchia.Width;
       }
        public override bool Equals(object obj)
        {
            if (!(obj is Ala otherAla) || otherAla == null)
            {
                return false;
            }

            return Lenght == otherAla.Lenght && Width == otherAla.Width;

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
            return $"Lunghezza:{Lenght};Larghezza Alare:{Width}";
        }
        public override double Price()
        {
            return Lenght * Width;
        }
    }
}
