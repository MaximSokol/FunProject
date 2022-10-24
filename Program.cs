using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject
{
    class Program
    {

        // Additional Task 1

        public static bool IsPowerOfTwo(byte power)
        {
            return power > 0 && (power & (power - 1)) == 0; 
        }

        // Additional Task 2

        public static bool DeMorganaTheorem(bool operand1, bool operand2)
        {
            return !(!operand1 && !operand2);
        }

        // Task 2

        public static bool IsNumbereven(int number)
        {
            return number != 0 && (number) % 2 == 0;
        }

        // Task 3

        public static void ShowOperations(int x, int y, int z)
        {
            Console.WriteLine(x += y >> x++ * z);
            Console.WriteLine(z = ++x & y * 5);
            Console.WriteLine(y /= x + 5 | z);
            Console.WriteLine(z = x++ & y * 5);
            Console.WriteLine(x = y << x++ ^ z);
        }

        // Task 4

        public static void Primium(int salary, int experienceOfYears, int percents)
        {
            double res = 0.0, buf = 0.0;

            Console.WriteLine("Choose the operation:\n");
            Console.WriteLine("1. Up to 5 years of experience!");
            Console.WriteLine("2. From 5 to 10 years (including)!");
            Console.WriteLine("3. From 10 to 15 years (including)!");
            Console.WriteLine("4. From 15 to 20 years (including)!");
            Console.WriteLine("5. From 20 to 25 years (including)!");
            Console.WriteLine("6. From 25 to 30 years (including)!\n");
            int opereation = int.Parse(Console.ReadLine());

            switch(opereation)
            {
                case 1:
                    if(experienceOfYears <= 5)
                    {
                        res = salary / 100;
                        buf = res * percents;
                        Console.WriteLine("Premium:\t" + buf);
                    }
                    break;
                    //---------------------------------------------------------
                case 2:
                    if(experienceOfYears > 5 && experienceOfYears <= 10)
                    {
                        res = salary / 100;
                        buf = res * percents;
                        Console.WriteLine("Premium:\t" + buf);
                    }
                    break;
                //---------------------------------------------------------
                case 3:
                    if (experienceOfYears > 10 && experienceOfYears <= 15)
                    {
                        res = salary / 100;
                        buf = res * percents;
                        Console.WriteLine("Premium:\t" + buf);
                    }
                    break;
                //---------------------------------------------------------
                case 4:
                    if (experienceOfYears > 15 && experienceOfYears <= 20)
                    {
                        res = salary / 100;
                        buf = res * percents;
                        Console.WriteLine("Premium:\t" + buf);
                    }
                    break;
                //---------------------------------------------------------
                case 5:
                    if (experienceOfYears > 20 && experienceOfYears <= 25)
                    {
                        res = salary / 100;
                        buf = res * percents;
                        Console.WriteLine("Premium:\t" + buf);
                    }
                    break;
                //---------------------------------------------------------
                case 6:
                    if (experienceOfYears > 25 && experienceOfYears <= 30)
                    {
                        res = salary / 100;
                        buf = res * percents;
                        Console.WriteLine("Premium:\t" + buf);
                    }
                    break;
                //---------------------------------------------------------
                default:
                    Console.WriteLine("The operation is absent!");
                    break;
                //---------------------------------------------------------
            }
        }

        static void Main(string[] args)
        {
            // Additional Task 1

            //Console.WriteLine(IsPowerOfTwo(2));


            //-----------------------------------------------------------------------------


            // Additional Task 2

            //bool op1 = false;
            //bool op2 = true;

            //Console.WriteLine(DeMorganaTheorem(op1, op2));


            //-----------------------------------------------------------------------------


            // Task 2

            //Console.WriteLine(IsNumbereven(2));


            //-----------------------------------------------------------------------------


            // Task 3

            //int x = 5, y = 10, z = 15;
            //ShowOperations(x, y, x);


            //-----------------------------------------------------------------------------


            // Task 4

            //Primium(15000, 15, 10);


            //-----------------------------------------------------------------------------

        }
    }
}
