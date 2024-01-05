using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Astratto
{
   public  class Cerchione : Composite
    {
        private double _pollici;
        private string _materiale;

        public double Pollice
        {
            get { return _pollici; }
            set
            {
                if(_pollici >0)
                {
                    _pollici = value;
                }
                else
                {
                    throw new InvalidOperationException("Il valore deve essere > 0");
                }
            }
        }
        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }
        public Cerchione()
        {
            _pollici = 0;
            _materiale = null;
        }
        public Cerchione(double pollici,string materiale)
        {
            _pollici = pollici;
            _materiale = materiale;
        }
        public Cerchione(Cerchione vecchhio)
        {
            Pollice = vecchhio.Pollice;
            Materiale=vecchhio.Materiale;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Cerchione otherCerchione) || otherCerchione == null)
            {
                return false;
            }

            return Pollice == otherCerchione.Pollice && Materiale == otherCerchione.Materiale;

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
            return $"Pollici:{Pollice};Materiale:{Materiale}";
        }
        public override double Price()
        {
            return Pollice * 2;
        }

    }
}
