using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TauChien.Ship.Decorator;
using TauChien.Ship.ShipType;

namespace TauChien.Ship
{
    public class Menutau
    {
        //Create new Ship 
        List<Ship> ship = new List<Ship>();
        Ship MyShip = new CorvetteShip();
        Ship MyCorvetteShip = new CorvetteShip();
        Ship MyFrigateShip = new FrigateShip();
        Ship MyPatrolShip = new PatrolShip();
        //Create a Customer's order Ship
        Ship customerShip;
        //Confirm the customer's order
        bool confirm = true;
        //Char will use to ask user Yes or No
        char YesNo = 'N';
        int chooseShip;
        int chooseDevice;

        int age;
        bool goihan = false;

        public void ShowMenu()
        {
            Ship MyRocket = new Rocket(MyShip);
            Ship MyCannons = new Cannons(MyShip);
            Ship MyRade = new Rada(MyShip);
            Ship MyArmour = new Armour(MyShip);
            Console.WriteLine("---- Batter Ship----");
            Console.WriteLine("== Ship type ");
            Console.WriteLine($" \t{MyCorvetteShip.GetName()}:   ${MyCorvetteShip.GetPrice()}");
            Console.WriteLine($" \t{MyFrigateShip.GetName()}:    ${MyFrigateShip.GetPrice()}");
            Console.WriteLine($" \t{MyPatrolShip.GetName()}:     ${MyPatrolShip.GetPrice()}");
            Console.WriteLine();
            Console.WriteLine("== Device ");
            Console.WriteLine($" \t{MyRocket.GetName()}:    ${MyRocket.GetPrice()}");
            Console.WriteLine($" \t{MyCannons.GetName()}:   ${MyCannons.GetPrice()}");
            Console.WriteLine($" \t{MyRade.GetName()}:      ${MyRade.GetPrice()}");
            Console.WriteLine($" \t{MyArmour.GetName()}:    ${MyArmour.GetPrice()}");
        }


        public void ShowShip()
        {
            Console.WriteLine("---- Batter Ship----");
            Console.WriteLine("== Ship type ");
            Console.WriteLine($" (1) {MyCorvetteShip.GetName()}:   ${MyCorvetteShip.GetPrice()}");
            Console.WriteLine($" (2) {MyFrigateShip.GetName()}:    ${MyFrigateShip.GetPrice()}");
            Console.WriteLine($" (3) {MyPatrolShip.GetName()}:     ${MyPatrolShip.GetPrice()}");
            Console.WriteLine();
            //Console.Write(" Choose Ship:  ");
            //chooseShip = int.Parse(Console.ReadLine());
            do
            {
                //ChoiceShip();
                try
                {
                    while (confirm)
                    {   
                          //Console.Write(" Choose Ship:  ");
                        //chooseShip = int.Parse(Console.ReadLine());
                        ChoiceShip();
                        switch (chooseShip)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($" {MyCorvetteShip.GetName()}:${MyCorvetteShip.GetPrice()}");
                                Console.ResetColor();
                                customerShip = new CorvetteShip();
                                ship.Add(customerShip);
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($" {MyFrigateShip.GetName()}:${MyFrigateShip.GetPrice()}");
                                Console.ResetColor();
                                customerShip = new FrigateShip();
                                ship.Add(customerShip);
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($" {MyPatrolShip.GetName()}:${MyPatrolShip.GetPrice()}");
                                Console.ResetColor();
                                customerShip = new PatrolShip();
                                ship.Add(customerShip);
                                break;
                            case 4:
                            default:
                                Console.WriteLine("invalue");
                                break;
                        }
                        Console.Write("-Do you want to add more Device? (Y: Yes or N: No): ");
                        YesNo = char.Parse(Console.ReadLine());
                        if (YesNo == 'Y' || YesNo == 'y')
                        {
                            ShowDevice();
                        }
                        else
                        {
                            ShowShip();
                        }
                        break;
                    }
                }
                catch (System.Exception)
                {
                    ShowShip();
                }
            } while (chooseShip != 4);

        }

        public void choiceDevice()
        {
            do
            {
                try
                {
                    Console.Write(" Add Device (Press 'Enter' to done):  ");
                    chooseDevice = int.Parse(Console.ReadLine());
                    goihan = chooseDevice < 0 || chooseDevice > 6;
                    if (goihan)
                    {
                        Console.WriteLine("Error");
                    }
                }
                catch (System.Exception)
                {
                    confirm = false;
                    Result();
                }
            } while (goihan);
        }

        public void ShowDevice()
        {
            Ship MyRocket = new Rocket(MyShip);
            Ship MyCannons = new Cannons(MyShip);
            Ship MyRade = new Rada(MyShip);
            Ship MyArmour = new Armour(MyShip);
            Console.WriteLine("== Device ");
            Console.WriteLine($" (1){MyRocket.GetName()}:    ${MyRocket.GetPrice()}");
            Console.WriteLine($" (2){MyCannons.GetName()}:   ${MyCannons.GetPrice()}");
            Console.WriteLine($" (3){MyRade.GetName()}:      ${MyRade.GetPrice()}");
            Console.WriteLine($" (4){MyArmour.GetName()}:    ${MyArmour.GetPrice()}");
            choiceDevice();
            try
            {
                //Console.Write("Add Device (Press 'Enter' to done): ");
                //chooseDevice = int.Parse(Console.ReadLine());
                while (confirm)
                {
                    switch (chooseDevice)
                    {
                        case 1:
                            customerShip = new Rocket(ship.Last());
                            ship.Add(customerShip);
                            Console.WriteLine($"Added:{MyRocket.GetName()}");
                            Result();
                            Console.WriteLine("-------------------------------------------");

                            Result();
                            break;
                        case 2:
                            customerShip = new Cannons(ship.Last());
                            ship.Add(customerShip);
                            Console.WriteLine($"Added:{MyCannons.GetName()}");
                            Result();
                            Console.WriteLine("-------------------------------------------");
                            break;
                        case 3:
                            customerShip = new Rada(ship.Last());
                            ship.Add(customerShip);
                            Console.WriteLine($"Added:{MyRade.GetName()}");
                            Console.WriteLine("-------------------------------------------");
                            Result();
                            break;
                        case 4:
                            customerShip = new Armour(ship.Last());
                            ship.Add(customerShip);
                            Console.WriteLine($"Added:{MyArmour.GetName()}");
                            Console.WriteLine("-------------------------------------------");
                            Result();
                            break;
                        case 5:
                            UnDecorator();
                            Result();
                            break;
                        case 6:
                            ShowShip();
                            break;
                        default:
                            break;
                    }
                    choiceDevice();
                }
            }
            catch (System.Exception)
            {
                confirm = false;
                Result();
            }
        }

        public void ChoiceShip()
        {
            do
            {
                try
                {
                    Console.Write(" Choose Ship:  ");
                    chooseShip = int.Parse(Console.ReadLine());
                    goihan = chooseShip < 0 || chooseShip > 3;
                    if (goihan)
                    {
                        Console.WriteLine("loi roi");
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("just input number!");
                    ChoiceShip();
                }
            } while (goihan);
        }

        public void UnDecorator()
        {
            Console.WriteLine("Remove");

            if (ship.Count <= 1)
            {
                Console.WriteLine("Please choose device");
                ShowDevice();
            }
            else
            {
                ship.RemoveAt(ship.Count - 1);
            }

        }

        public void Result()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("--- Customer order ---");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("--Ship--");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("--Devices--");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(ship.Last().GetName());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("--Price: ");
            Console.ResetColor();
            Console.WriteLine(ship.Last().GetPrice());
            Console.WriteLine("Thank you for using our service!");
        }

        //public void Nhap()
        //{
        //    do
        //    {
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
        //            try
        //            {
        //                Console.Write("input:");
        //                age = int.Parse(Console.ReadLine());
        //                goihan = age < 0 || age > 100;
        //                if (goihan)
        //                {
        //                    Console.WriteLine("loi roi");
        //                }
        //            }
        //            catch (System.Exception)
        //            {
        //                Console.WriteLine("chi nhap so");
        //            }
        //        }
        //    } while (goihan);
        //}




    }
}
