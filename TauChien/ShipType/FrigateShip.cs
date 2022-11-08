using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauChien.Ship.ShipType
{
    public class FrigateShip : Ship
    {
        public override double GetDisplacement()
        {
            return Displacement = 1000;
        }

        public override string GetName()
        {
            return Name = "Frigate Ship";
        }

        public override double GetSpeed()
        {
            return Speed = 100;
        }

        public override int GetStreng()
        {
            return Streng = 100;
        }

        public override double GetTonnage()
        {
            return Tonnage = 25000;
        }

        public override double GetWeight()
        {
            return Weight = 1500;
        }
        public override double GetPrice()
        {
            return Price = 30000;
        }

    }
}
