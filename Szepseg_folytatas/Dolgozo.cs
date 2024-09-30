using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szepseg_folytatas
{
    internal class Dolgozo
    {
        private int dolgozoID;
        private string dolgozoVezetekNev;
        private string dolgozoKeresztNev;
        private string dolgozoTelefon;
        private string dolgozoEmail;
        private bool dolgozoStatusz;
        private int dolgozoSzolgaltatasa;

        public int DolgozoID { get => dolgozoID; set => dolgozoID = value; }
        public string DolgozoVezetekNev { get => dolgozoVezetekNev; set => dolgozoVezetekNev = value; }
        public string DolgozoKeresztNev { get => dolgozoKeresztNev; set => dolgozoKeresztNev = value; }
        public string DolgozoTelefon { get => dolgozoTelefon; set => dolgozoTelefon = value; }
        public string DolgozoEmail { get => dolgozoEmail; set => dolgozoEmail = value; }
        public bool DolgozoStatusz { get => dolgozoStatusz; set => dolgozoStatusz = value; }
        public int DolgozoSzolgaltatasa { get => dolgozoSzolgaltatasa; set => dolgozoSzolgaltatasa = value; }
    }

}
