using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlanok
{
    class Sorhaz : Ingatlan
    {
        int idsorhaz;
        int telekterulet;
        int garazs;

        public Sorhaz(int idingatlan, string cim, int iranyar, int alapterulet, double berletidij, int idsorhaz, int telekterulet, int garazs) : base(idingatlan, cim, iranyar, alapterulet, berletidij)
        {
            Idsorhaz = idsorhaz;
            Telekterulet = telekterulet;
            Garazs = garazs;
        }

        public int Idsorhaz { get => idsorhaz; set => idsorhaz = value; }
        public int Telekterulet { get => telekterulet; set => telekterulet = value; }
        public int Garazs { get => garazs; set => garazs = value; }

        public override string ToString()
        {
            return Cim;
        }
    }
}
