using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TauChien.Ship.Decorator;
using TauChien.Ship.ShipType;

namespace TauChien.Ship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ship MyShip = new CorvetteShip();
            //MyShip = new Rocket(MyShip);
            //MyShip = new Rada(MyShip);
            //MyShip = new Rocket(MyShip);
            //MyShip = new Cannons(MyShip);
            //MyShip = new Armour(MyShip);

            //Console.WriteLine(MyShip.GetName());
            //Console.WriteLine("Price : {0}$", MyShip.GetPrice());
            //Console.WriteLine("Weight :{0} Tons", MyShip.GetWeight());
            //Console.WriteLine("Steng = {0}",MyShip.GetStreng());
            //Console.WriteLine("Tonnage = {0}", MyShip.GetTonnage());
            Menutau menutau = new Menutau();
            //menutau.ShowMenu();
            menutau.ShowShip();
            //menutau.Nhap();
            //int age;
            //bool goihan = false;
            //do
            //{
            //    try
            //    {
            //        Console.Write("input:");
            //        age = int.Parse(Console.ReadLine());
            //        goihan = age < 0 || age > 100;
            //        if (goihan)
            //        {
            //            Console.WriteLine("loi roi");
            //        }
            //    }
            //    catch (System.Exception)
            //    {
            //        Console.WriteLine("chi nhap so");
            //        try
            //        {
            //            Console.Write("input:");
            //            age = int.Parse(Console.ReadLine());
            //            goihan = age < 0 || age > 100;
            //            if (goihan)
            //            {
            //                Console.WriteLine("loi roi");
            //            }
            //        }
            //        catch (System.Exception)
            //        {
            //            Console.WriteLine("chi nhap so");
            //        }
            //    }
            //} while (goihan);


            //do
            //{
            //    try
            //    {
            //        Console.Write(" Choose Ship:  ");
            //        chooseShip = int.Parse(Console.ReadLine());
            //        goihan = chooseShip < 0 || chooseShip > 3;
            //        if (goihan)
            //        {
            //            Console.WriteLine("loi roi");
            //        }
            //    }
            //    catch (System.Exception)
            //    {
            //        Console.WriteLine("just input number!");
            //        try
            //        {
            //            Console.Write(" Choose Ship:  ");
            //            chooseShip = int.Parse(Console.ReadLine());
            //            goihan = chooseShip < 0 || chooseShip > 3;
            //            if (goihan)
            //            {
            //                Console.WriteLine("loi roi");
            //            }
            //        }
            //        catch (System.Exception)
            //        {
            //            Console.WriteLine("just input number!");
            //        }
            //    }
            //} while (goihan)

            Console.ReadLine();

        }
    }
}
