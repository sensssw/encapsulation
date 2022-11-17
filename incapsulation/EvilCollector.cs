using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
     class EvilCollector: Collector, Interface1
    {
        public void BreakHands(Debtor debtor)
        {
            Console.WriteLine($"{Name}break {debtor.Name}'s hands");
        }
        public void BreakLegs(Debtor debtor)
        {
            Console.WriteLine($"{Name} break {debtor.Name}'s knees");
        }
        public void BreakHands1(Atai atai)
        {
            Console.WriteLine($"{Name} break {atai.Name}'s hands");
        }

        public int Name{ get; set; }
        
        
    }
}
