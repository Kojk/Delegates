using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Delegates
{
    class Teplomer
    {
        private Timer timer;
        private static Random randomizer  = new Random();
        public delegate void PrehratiHandler(int teplota);
        public event PrehratiHandler Prehrati;
        public Teplomer()
        {
            timer = new Timer(randomizer.Next(2000, 10000));
            timer.Start();
            timer.Elapsed += Timer_Elapsed;             // vlozenie eventu


        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            //timer.Elapsed -= Timer_Elapsed;           odstranenie eventu
            if (Prehrati != null)
            {
                Prehrati(100);
            }
        }
    }
}
