using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlanok
{
    class Ingatlan 
    {
        int idingatlan;
        string cim;
        int iranyar;
        int alapterulet;
        double berletidij;

        public Ingatlan(int idingatlan, string cim, int iranyar, int alapterulet, double berletidij)
        {
            this.Idingatlan = idingatlan;
            this.Cim = cim;
            this.Iranyar = iranyar;
            this.Alapterulet = alapterulet;
            this.Berletidij = berletidij;
        }

        public int Idingatlan { get => idingatlan; set => idingatlan = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Iranyar { get => iranyar; set => iranyar = value; }
        public int Alapterulet { get => alapterulet; set => alapterulet = value; }
        public double Berletidij { get => berletidij; set => berletidij = value; }

        public override string ToString()
        {
            return Cim;
        }
    }
}
