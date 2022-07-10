using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlanok
{
    class Sorhaz : Ingatlan, Interface_ToCSV,Interface_to_HTML
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

        public string tocsv()
        {
            return string.Join(";", this.Cim, this.Iranyar.ToString(), this.Alapterulet.ToString(), this.Berletidij.ToString(), telekterulet, garazs);   
        }

        public string toHTML()
        {
                string export = "<tr><td>" + string.Join("</td><td>", this.Cim.ToString(), this.Iranyar, this.Alapterulet, this.Berletidij, telekterulet, garazs) + "</td></tr>";
                return export; 
        }

        public override string ToString()
        {
            return Cim;
        }
    }
}
