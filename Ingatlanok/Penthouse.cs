﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlanok
{
    class Penthouse : Ingatlan, Interface_ToCSV
    {
        int idpenthouse;
        int emelet;
        int erkely;

        public Penthouse(int idingatlan, string cim, int iranyar, int alapterulet, double berletidij, int idpenthouse, int emelt, int erkely) : base(idingatlan, cim, iranyar, alapterulet, berletidij)
        {
            Idpenthouse = idpenthouse;
            Emelet = emelet;
            Erkely = erkely;
        }

        public int Idpenthouse { get => idpenthouse; set => idpenthouse = value; }
        public int Emelet { get => emelet; set => emelet = value; }
        public int Erkely { get => erkely; set => erkely = value; }

        public string tocsv()
        {
            return string.Join(";", this.Cim, this.Iranyar.ToString(), this.Alapterulet.ToString(), this.Berletidij.ToString(), emelet, erkely);
        }

        public override string ToString()
        {
            return Cim;
        }
    }
}
