using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauChien.Ship.ShipType
{
    internal class PatrolShip : Ship
    {
        public override double GetDisplacement()
        {
            return Displacement = 500;
        }

        public override string GetName()
        {
            return Name = "Patro Ship";
        }

        public override double GetSpeed()
        {
            return Speed = 200;
        }
        public override int GetStreng()
        {
            return Streng = 20;
        }
        public override double GetTonnage()
        {
            return Tonnage = 15000;
        }

        public override double GetWeight()
        {
            return Weight = 500;
        }
        public override double GetPrice()
        {
            return Price = 12000;
        }

    }
}
