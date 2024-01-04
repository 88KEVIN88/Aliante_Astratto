using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Astratto
{
    internal class Ala : Composite
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

    }
}
