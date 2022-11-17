using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    public class Collector
    {
        public string Name { get; set; }
        public int Rage { get; set; }
        private int _rage;
        public int cap = 5000;

        public void Kill(Debtor debtor)
        {
            if (Rage < debtor.Debt)
            { Console.WriteLine("{0} kill's {1}", Name, debtor.Name); }
            else { Console.WriteLine("{0}'s rage isn't longe", Name);  }
        }

        public void BreakLegs(Debtor debtor)
        {
            if (debtor.Debt > cap)
            {
                Console.WriteLine("The debt is too big, we break your knees!");
            }
            else
            {
                Console.WriteLine("The debt isn't too big, give you some time!");
            }
        }
    }
}
