using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauChien.Ship.Decorator
{
    public class Rocket : ShipDecorator
    { 
        public Rocket(Ship ship) : base(ship)
        {
            Name = "Rocket";
        }
        public override string GetName()
        {
            return String.Format("{0}, {1}", _ship.GetName(),Name);
        }
        public override double GetWeight()
        {
            return _ship.GetWeight() + 400;
        }
        public override int GetStreng()
        {
            return _ship.GetStreng() + 500;
        }
        public override double GetPrice()
        {
            return _ship.GetPrice() + 4000;
        }

    }
}
