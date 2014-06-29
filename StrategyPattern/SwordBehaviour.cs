using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SwordBehaviour:WeaponBehaviour
    {
        void WeaponBehaviour.use()
        {
            Console.WriteLine("Uses sword. ===))===============>");
        }
    }
}
