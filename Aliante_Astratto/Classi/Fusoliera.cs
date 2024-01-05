using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Astratto
{
    internal class Fusoliera : Composite
    {
        private double _lenght;
        private string _materials;
        public double Lenght
        {
            get { return _lenght; }
            set
            {
                if(_lenght>0)
                {
                    _lenght = value;
                }
                else
                {
                    throw new ArgumentException("La lunghezza della fusoliera deve essere > 0");

                }
            }
        }
        public string Materials
        {
            get { return _materials; }
            set { _materials = value; }
        }
        public Fusoliera()
        {
            Lenght = 0;
            Materials = string.Empty;
        }
        public Fusoliera(double lenght,string materiale)
        {
            Lenght=lenght;
            Materials = materiale;
        }
        public override bool Equals(object obj)
        {

            if (!(obj is Coda other))
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
           return $"Lunghezza:{Lenght};Materiale della fusolieras:{Materials}";   
        }
    }

}
