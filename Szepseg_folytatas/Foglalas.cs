using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szepseg_folytatas
{
    internal class Foglalas
    {
        private int foglalasID;
        private int szolgaltatasID;
        private int dolgozoID;
        private int ugyfelID;
        private DateTime foglalasKezdes;
        private DateTime foglalasBefejezes;

        public int FoglalasID { get => foglalasID; set => foglalasID = value; }
        public int SzolgaltatasID { get => szolgaltatasID; set => szolgaltatasID = value; }
        public int DolgozoID { get => dolgozoID; set => dolgozoID = value; }
        public int UgyfelID { get => ugyfelID; set => ugyfelID = value; }
        public DateTime FoglalasKezdes { get => foglalasKezdes; set => foglalasKezdes = value; }
        public DateTime FoglalasBefejezes { get => foglalasBefejezes; set => foglalasBefejezes = value; }
    }

}
