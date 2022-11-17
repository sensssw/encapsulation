using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    public class Atai : AbstractPerson
    {
        public Atai(string name) : base(name) { }
        public override void EarnMoney()
        {
            base.EarnMoney();
        }
    }
}
