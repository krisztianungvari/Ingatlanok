using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlanok 
{
    class Csaladi : Ingatlan , Interface_ToCSV, Interface_to_HTML
    {
        int idcsaladi;
        int telekterulet;
        int garazs;

        public Csaladi(int idingatlan, string cim, int iranyar, int alapterulet, double berletidij, int idcsaladi, int telekterulet, int garazs) : base(idingatlan, cim, iranyar, alapterulet, berletidij)
        {
            this.Idcsaladi = idcsaladi;
            Telekterulet = telekterulet;
            Garazs = garazs;
        }

        public int Idcsaladi { get => idcsaladi; set => idcsaladi = value; }
        public int Telekterulet { get => telekterulet; set => telekterulet = value; }
        public int Garazs { get => garazs; set => garazs = value; }

        public string tocsv()
        {
            return string.Join(";", this.Cim, this.Iranyar.ToString(), this.Alapterulet.ToString(), this.Berletidij.ToString(), telekterulet, garazs);
        }

        public override string ToString()
        {
            return Cim;
        }
        public string toHTML()
        {
            string export = "<tr><td>" + string.Join("</td><td>", this.Cim.ToString(), this.Iranyar, this.Alapterulet, this.Berletidij, telekterulet, garazs) + "</td></tr>";
            return export;
        }
    }
}
