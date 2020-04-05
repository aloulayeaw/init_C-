using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Cargaison.models
{
    class Routiere:Cargaison
    {
        public override double Cout()
        {
            int val;
            if (VolumeTotal < 380000)
            {
                val = 4;
            }
            else
            {
                val = 6;
            }
            return val * Distance * PoidsTotal;
        }

        public override string ToString()
        {
            return base.ToString() + "Cout " + Cout();
        }
    }
}
