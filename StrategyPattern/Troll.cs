using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Troll:Character
    {
        public Troll()
        {
            weapon = new AxeBehaviour();
        }
    }
}
