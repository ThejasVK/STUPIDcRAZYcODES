using System;

namespace chapter3_exercises_set2
{
    class Program
    {
        static void Main(string[] args)
        {
            //program to find the range of numbers entered by the users without using arrays or funtions . (range is the difference of the larget and the smallest number)
            int userNumber, positiveNumber = 0, negativeNumber = 0,leastPositive=0, leastNegative=0, zero = 0, greatestNumber=0, leastNumber=0, range;
            char ch;
            do
            {
                Console.Write("Enter integers in descending order : ");
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber > 0)
                {
                    if (userNumber > positiveNumber)
                        positiveNumber = userNumber;
                    else if (userNumber < positiveNumber)
                        leastPositive = userNumber;
                }
                else if (userNumber < 0)
                {
                    negativeNumber = Math.Abs(userNumber);

                    if (userNumber > negativeNumber)
                        negativeNumber = userNumber;
                    else if (userNumber < negativeNumber)
                        leastNegative = userNumber;

                    /*if (userNumber < negativeNumber)// leastNegative)
                    {
                        negativeNumber = userNumber;*/

            /*if (userNumber > negativeNumber)
                leastNegative = userNumber;*/

            /*if (userNumber < negativeNumber)
                leastNegative = userNumber;*/
            //}                   

            /*
                }
                else if (userNumber == 0)
                    zero = userNumber;

                Console.Write("Do you want to enter more integers? (y/n)");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');
            
            //greatest numbers
            if (positiveNumber > zero && positiveNumber > negativeNumber)
            {
                Console.WriteLine("{0} is the greatest positive number", positiveNumber);
                greatestNumber = positiveNumber;
            }
                

            if (negativeNumber > positiveNumber && negativeNumber > zero) //&&negativeNumber>leastNegative&&negativeNumber>leastPositive)
            {
                Console.WriteLine("- {0} is the smallest negative number", negativeNumber);
                greatestNumber = negativeNumber;
            }
                

            if (zero>positiveNumber&& zero > negativeNumber &&zero>leastNegative&&zero>leastPositive)
            {
                Console.WriteLine("{0} is the greatest zero number", zero);
                greatestNumber = zero;
            }



            //least numbers
            else if (leastPositive>zero && leastPositive > leastNegative )//&& leastPositive> positiveNumber)
            {
                Console.WriteLine("{0} is the greatest leastPositive number or smallest positive number", leastPositive);
                leastNumber = leastPositive;
            }
                

            else if (leastNegative>zero && leastNegative > leastPositive )//&& leastNegative>negativeNumber)
            {
                Console.WriteLine("- {0} is the greatest leastNegative  number or largest negative number", leastNegative);
                leastNumber = leastNegative;
            }
                

            
            if (positiveNumber < zero && positiveNumber < negativeNumber)
            {
                Console.WriteLine("{0} is the smallest positive number", positiveNumber);
                leastNumber = zero;
            }
                

            if (negativeNumber < zero && negativeNumber < positiveNumber )//&& negativeNumber<leastNegative)
            {
                Console.WriteLine("- {0} is the largesttt negative number", negativeNumber);
                leastNumber = negativeNumber;
            }
                

            if (zero < positiveNumber && zero < negativeNumber && zero < leastNegative && zero < leastPositive)
            {
                Console.WriteLine("{0} is the smallest zero number", zero);
                leastNumber = zero;
            }
                

            if (leastPositive<0 && leastPositive < negativeNumber && leastPositive < leastNegative)
            {
                Console.WriteLine("{0} is the smallest leastPositive number", leastPositive);
                leastNumber = leastPositive;
            }
                

            if (leastNegative< 0 && leastNegative< negativeNumber && leastNegative< leastPositive)
            {
                Console.WriteLine("second - {0} is the smallest largesttT leastNegative number", leastNegative);
                leastNumber = leastNegative;
            }

            range = greatestNumber - leastNumber;
            Console.WriteLine("The range is {0}", range);
        }
    }
}
