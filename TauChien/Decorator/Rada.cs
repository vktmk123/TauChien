using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauChien.Ship.Decorator
{
    internal class Rada : ShipDecorator
    {
        public Rada(Ship ship) : base(ship)
        {
            Name = "Rada";
        }
        public override string GetName()
        {
            return String.Format("{0}, {1}", _ship.GetName(), Name);
        }
        public override double GetWeight()
        {
            return _ship.GetWeight() + 200;
        }
        public override int GetStreng()
        {
            return _ship.GetStreng() + 200;
        }
        public override double GetPrice()
        {
            return _ship.GetPrice() + 2000;
        }
    }
}
