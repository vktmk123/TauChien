using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauChien.Ship
{
    public class ShipDecorator : Ship
    {
        protected Ship _ship;

        public ShipDecorator(Ship ship)
        {
            _ship = ship;
        }

        public override int GetStreng()
        {
            return _ship.GetStreng(); 
        }

        public override double GetDisplacement()
        {
            return _ship.GetDisplacement();
        }

        public override string GetName()
        {
            return _ship.GetName();
        }

        public override double GetSpeed()
        {
            return _ship.GetSpeed();
        }

        public override double GetTonnage()
        {
            return _ship.GetTonnage() - GetDisplacement() - GetWeight();
        }

        public override double GetWeight()
        {
            return _ship.GetWeight();
        }

        public override double GetPrice()
        {
            return _ship.GetPrice();
        }
    }
}
