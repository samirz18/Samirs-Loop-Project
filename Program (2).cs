using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class SamirsLoopyProject
    {
        static void Main(string[] args)
        {
            String Stop = "Y";
            while (Stop == "Y") {

                Double ratio = 0.0;
                string Place = "";
                Double result = 0.0;
                Console.WriteLine("Menu of Planets");
                Console.WriteLine("==== == =======");
                Console.WriteLine("1.Jupiter, 2.Mars, 3.Mercury");
                Console.WriteLine("4.Neptune, 5. Pluto, 6. Saturn");
                Console.WriteLine("7.Uranus, 8. Venus, 9.<Quit>");


                int weight = 0;
                Console.Write("Please enter your weight: ");
                weight = int.Parse(Console.ReadLine());

                int Enteryourplanet = 0;
                Console.Write(" Choose your planet ");
                Enteryourplanet = Convert.ToInt32(Console.ReadLine());

                switch (Enteryourplanet)
                {

                    case 1:
                        ratio = 2.64;
                        Place = "Jupiter";

                        break;

                    case 2:
                        ratio = 0.38;
                        Place = "Mars";

                        break;


                    case 3:
                        ratio = 0.37;
                        Place = "Mercury";

                        break;

                    case 4:
                        ratio = 1.12;
                        Place = "Neptune";

                        break;

                    case 5:
                        ratio = 0.04;
                        Place = "Pluto";

                        break;

                    case 6:
                        ratio = 1.15;
                        Place = "Saturn";

                        break;

                    case 7:
                        ratio = 1.15;
                        Place = "Uranus";
                        break;

                    case 8:
                        ratio = 0.88;
                        Place = "Venus";
                        break;

                    case 9:
                        break;

                    default:
                        break;
                }
                result = ratio * weight;

                Console.WriteLine(" Your Weight is " + result + " pounds on the planet " + Place);


                Console.WriteLine("Do you want to continue");
                Console.WriteLine("Click Y for Yes or N for NO");
                Stop = Console.ReadLine();

                if (Stop == "Y")
                {
                    //loop continues
                }
                else
                {
                    Stop = "N";
                }
            }
        }
    }
}
