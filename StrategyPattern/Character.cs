using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface WeaponBehaviour
    {
        void use();
    }

    public abstract class Character
    {
        public WeaponBehaviour weapon;

        public Character()
        {

        }

        public void fight()
        {
            weapon.use();
        }

        public void setWeapon(WeaponBehaviour w)
        {
            this.weapon = w;
        }
    }
}
