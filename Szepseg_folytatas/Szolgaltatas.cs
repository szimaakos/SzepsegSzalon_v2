using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szepseg_folytatas
{
    internal class Szolgaltatas
    {
        private int szolgaltatasID;
        private string szolgaltatasKategoria;
        private DateTime szolgaltatasIdotartam;
        private int szolgaltatasAr;

        public int SzolgaltatasID { get => szolgaltatasID; set => szolgaltatasID = value; }
        public string SzolgaltatasKategoria { get => szolgaltatasKategoria; set => szolgaltatasKategoria = value; }
        public DateTime SzolgaltatasIdotartam { get => szolgaltatasIdotartam; set => szolgaltatasIdotartam = value; }
        public int SzolgaltatasAr { get => szolgaltatasAr; set => szolgaltatasAr = value; }
    }

}
