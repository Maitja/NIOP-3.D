using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrajinovicMatijaKraj.Vozilo
{
    public class Vozil
    {
        private string vrsta;
        private int bk, mb;

        public void setbk(int bk)
        {
            this.bk = bk;
        }

        public int getbk()
        {
            return this.bk;
        }

        public void setmb(int mb)
        {
            this.mb = mb;
        }

        public int getmb()
        {
            return this.mb;
        }

        public void setVrsta(string vrsta)
        {
            this.vrsta = vrsta;
        }

        public string getVrsta()
        {
            return this.vrsta;
        }

        public Vozil()
        {

        }



    }
}
