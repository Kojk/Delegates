using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Stroj
    {
        private string nazevStroje;
        private Teplomer teplomer = new Teplomer();
        public Stroj(string nazevStroje)
        {
            teplomer.Prehrati += onPrehratiStroje;
            this.nazevStroje = nazevStroje;
        }
        private void onPrehratiStroje(int teplota)
        {
            Console.WriteLine("Vysoka teplota!!!");
            VypniStroj();
        }

        public void ZapniStroj()
        {
            Console.WriteLine("Zapinam " + nazevStroje);
        }
        public void VypniStroj()
        {
            Console.WriteLine("Vypinam " + nazevStroje);
        }
    }
}
