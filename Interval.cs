using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hehehehehehehe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //giving a sential value
            Console.WriteLine("Enter 0.99 to exit the loop!!\n");

            //creating a loop so that user can input multiple values in single run
            do
            {
                //taking a double value from the user
                Console.Write("Enter a real number: ");
                double x = Convert.ToDouble(Console.ReadLine());
                

                //if user inputs the sentinal value loop exits
                if (x == 0.99)
                {
                    break;
                }
                else
                {
                    bool belongs = (x >= 2 && x < 3) || (x >= 0 && x <= 1) || (x >= -10 && x <= -2);
                    if (belongs)
                    {
                        Console.WriteLine("x belongs to I\n");

                    }
                    else
                    {
                        Console.WriteLine("x does not belong to I\n");
                    }
                }
                
            } while (true);
            
        }
        
    }
}
