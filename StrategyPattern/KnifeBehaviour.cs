using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class KnifeBehaviour:WeaponBehaviour
    {
        void WeaponBehaviour.use()
        {
            Console.WriteLine("Throws knife. :===>");
        }
    }
}
