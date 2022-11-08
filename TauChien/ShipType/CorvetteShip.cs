using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauChien.Ship.ShipType
{
    public class CorvetteShip : Ship
    {
        public CorvetteShip()
        {
            Name = "Corvette Ship";
        }
        public override double GetDisplacement()
        {
            return Displacement = 800;
        }

        public override string GetName()
        {
            return Name;
        }
        public override int GetStreng()
        {
            return Streng = 50;
        }

        public override double GetSpeed()
        {
            return Speed = 120;
        }

        public override double GetTonnage()
        {
            return Tonnage = 30000;
        }

        public override double GetWeight()
        {
            return Weight = 1000;
        }

        public override double GetPrice()
        {
            return Price = 2000;
        }
    }
}
