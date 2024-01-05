using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Astratto
{
   public class Gomma : Composite
    {
        private double _lenght, _width, r;
        public double Length
        {
            get {return _lenght;}
            set
            {
                if (_lenght > 0)
                {
                    _lenght = value;
                }
                else
                {
                    throw new ArgumentException("La lunghezza deve essere >0");
                }
            }
        }
        public double Width
        {
            get { return _width;}
            set
            {
                if ( _width > 0)
                {
                    _width = value;
                }else
                {
                    throw new ArgumentException("La larghezza deve essere >0");
                }
            }
        }
        public double Raggio
        {
            get { return r; }
            set
            {
                if (r > 0)
                {
                    r = value;
                }
                else
                {
                    throw new ArgumentException("Il valore del raggio deve essere >0");
                }
            }
        }
        public Gomma()
        {
            Length = 0;
            Width = 0;
            Raggio = 0;
        }
        public Gomma(double lenght,double widthm,double rag)
        {
            _lenght = lenght;
            _width = widthm;
            r = rag;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Gomma otherGomma))
            {
                return false;
            }

            return Width == otherGomma.Width && Length == otherGomma.Length && Raggio == otherGomma.Raggio;
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
           return $"Altezza:{Length};Larghezza:{Width};Raggio:{Raggio}";
        }
        public override double Price()
        {
            return Width * Length * Raggio;
        }


    }
}
