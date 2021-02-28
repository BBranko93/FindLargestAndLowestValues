using System;
using System.ComponentModel.Design;

namespace FindLargestAndLowestValues
{
    class Program
    {
        //. Write a C# program to find the largest and lowest
        //values from three integer values.
        static void Main(string[] args)
        {
            //declare variables
            int num1, num2, num3;

            //Collect first number and store into num1
            Console.WriteLine("Enter a first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            //collect second number and store into num2
            Console.WriteLine("Enter a second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            //collect third number and store into num3
            Console.WriteLine("Enter a third number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            /*if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The largest of three is : {0}", num1);
            }
            else
            {
                Console.WriteLine("The lowest of the three is :{0}", num1);
            }

            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The largest of the three is :{0}", num2);
            }
            else
            {
                Console.WriteLine("The lowest of the three is :{0}", num2);
            }
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("The largest of the three is :{0}", num3);
            }
            else
            {
                Console.WriteLine("The lowest of the three is :{0}", num3);
            }*/

            Console.WriteLine("The largest of the three is: "+Math.Max( num1, Math.Max(num2, num3)));
            Console.WriteLine("The lowest of the three is: "+Math.Min(num1, Math.Min(num2, num3)));
        }
    }
}
