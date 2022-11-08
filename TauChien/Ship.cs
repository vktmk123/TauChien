using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauChien.Ship
{
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Streng { get; set; }   
        public double Weight { get; set; }
        public double Displacement { get; set; }//do dan nuoc
        public double Tonnage { get; set; } //trong tai
        public double Speed { get; set; }
        public double Price { get; set; }

        public abstract string GetName(); 
        public abstract int GetStreng();
        public abstract double GetWeight();
        public abstract double GetDisplacement();
        public abstract double GetTonnage();
        public abstract double GetSpeed();
        public abstract double GetPrice();
    }
}
