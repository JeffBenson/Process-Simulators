using System;
using System.Linq;

namespace Class_Practice
{
    internal class Program
    {



        private static void Main(string[] args)
        {
            //Parts list variables for complete ignition system:

            bool battery = true;
            int batteryVoltage = 12;
            double maxVoltage = 13.6;
            bool batteryConnection = true;

            bool ignitionCoil = true;
            double primaryCoilVolt = batteryVoltage;
            double secondaryCoilVolt = primaryCoilVolt * 2500.00;

            bool fuel = true;
            bool engineTiming = true;
            bool sparkPlug = true;


            Console.WriteLine("Welcome to your new car simulator!");
            Console.WriteLine("This program will simulate a real-world car.");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("\nIf any of the 'parts' are missing from your car, it won't start.");
            Console.WriteLine("You will be notified of broken parts.");
            Console.ReadKey();



            void fuelCheck()
            {
                if (fuel == true)
                {
                    //Console.Clear();
                    //Console.WriteLine("Car is fueled.");
                    return;
                }
                if (fuel == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please refuel car and try again later.");
                    Console.ReadKey();
                    fuelCheck();
                }
            }



            void insertKey()
            {
                //insert key
                Console.Clear();
                Console.WriteLine("Please insert key.");
                Console.WriteLine("\nDid you insert key?   Y/N");
                string driverResponse = Console.ReadLine();
                string capitalResponse = driverResponse.ToUpper();
                string[] resposes = { capitalResponse };
                if (resposes.Contains("Y"))
                {
                    //Console.Clear();
                    //Console.WriteLine("Please proceed.");
                    //Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please try again.");
                    Console.ReadKey();
                    Console.Clear();
                    insertKey();
                }
            }



            void turnKey()
            {
                Console.WriteLine("Please turn (press enter) key to start car.");
                //Console.WriteLine("Release key when vehicle starts.");
                Console.ReadKey();
                Console.Clear();


                if (battery == true)
                {
                    //Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("There is no battery in car.");
                    Console.WriteLine("\nPlease insert a charged battery and try again.");
                    return;
                }

                if (batteryVoltage >= 12 && batteryVoltage < maxVoltage)
                {
                    Console.Clear();
                    //Console.WriteLine("Voltage is within tolerance");
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Battery needs to be charged.");
                    Console.WriteLine("Please charge battery and try again later.");
                    Console.ReadKey();
                    return;
                }
                if (batteryConnection == true)
                {
                    //Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Battery is not connected.");
                    Console.WriteLine("\nPlease connect battery and try again later.");
                    return;
                }

            }



            void ignition()
            {
                //ignition coil recieves at lease 12 volts, then transforms it to jump gaps.

                if (ignitionCoil = true)
                {
                    Console.Clear();
                    //Console.Write("Ignition Coil exists!");
                    //Console.ReadKey();
                }
                if (ignitionCoil == false)
                {
                    Console.Clear();
                    Console.WriteLine("Ignition Coil is missing.");
                    Console.WriteLine("Please repair and try again later.");
                    Console.ReadKey();
                }

                if (secondaryCoilVolt >= 30000)
                {
                    Console.Clear();
                    //Console.WriteLine("It jumped to gaps between rotor and distributor cap!");
                    //Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Transformer in secondary coil has failed.");
                    Console.WriteLine("Please repair, then try again");
                    Console.ReadKey();
                    return;
                }
            }



            void fuelSpark()
            {
                if (engineTiming == true)
                {
                    Console.Clear();
                    //Console.WriteLine("Timing is correct!");
                    //Console.ReadKey();
                }
                if (engineTiming == false)
                {
                    Console.Clear();
                    Console.WriteLine("Timing is off.");
                    Console.WriteLine("Spark could not reach fuel.");
                    Console.WriteLine("Please fix timing and try again later.");
                    Console.ReadKey();
                    return;
                }
            }



            void combustion()
            {
                Console.Clear();
                Console.WriteLine("Your car started.\nHave a great trip!");
                return;
            }


            fuelCheck();
            insertKey();
            turnKey();
            ignition();
            fuelSpark();
            combustion();


            Console.ReadKey();
        }
    }
}