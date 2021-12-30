using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module6.Sum;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Random class

            Random die = new Random();

            int first = die.Next(1, 21);
            int second = die.Next(1, 21);
            int third = die.Next(1, 21);
            int fourth = die.Next(1, 21);
            int fifth = die.Next(1, 21);

            float avg = (first + second + third) / 3f;

            // If, else if, else blocks

            if (avg > 15)
            {
                Console.WriteLine("Huge damage is done");
            }

            else if (10 < avg && avg <= 15)
            {
                Console.WriteLine("Average damage is done");
            }

            else if (5 < avg && avg <= 10)
            {
                Console.WriteLine("No damage is done");
            }

            else
            {
                Console.WriteLine("Done damage to yourself");
            }

            if (fourth >= 20 || fifth >= 2)
            {
                Console.WriteLine("Extra damage is done");
            }

            Console.WriteLine(first + " " + second + " " + third + " " + fourth + " " + fifth);
            Console.WriteLine(avg);

            // Arrays

            string[] orderNo = new string[3];
            string[] orders = { "bag", "tshirt", "shoes" };
            int[] prices = { 350, 200, 600 };
            int totalPrice = 0;
            int count = 0;

            orderNo[0] = "GHDF521";
            orderNo[1] = "TYF95";
            orderNo[2] = "UKJY984";

            Console.WriteLine(orderNo[2]);
            Console.WriteLine(orderNo.Length);

            // Foreach loop 

            foreach (int price in prices)
            {
                totalPrice += price;
                count++;
            }

            Console.WriteLine(totalPrice + " " + count);

            // Conditional statements

            int number = 5;
            string name = "Melisa Tanrikulu";

            Console.WriteLine("a" == "a");
            Console.WriteLine(1.2f == 1.2d);
            Console.WriteLine(1 != number);
            Console.WriteLine(name.Contains("Mel"));

            Console.WriteLine(number < 6 ? "Less than 6" : "Greater than 6"); // conditional statement

            // Creating new classes

            int num = 0;
            num = Addition.Add(10);
            Console.WriteLine(num);

            // Switch Case

            int roommateCount = 0;
            string status = "";
            Random rand = new Random();
            roommateCount = rand.Next(0, 5);

            switch (roommateCount)
            {
                case 1:
                    status = "Lonely";
                    break;
                case 2:
                    status = "Personal space";
                    break;
                case 3:
                    status = "Ideal";
                    break;
                case 4:
                    status = "Might be a problem";
                    break;
                default:
                    status = "You didn't count yourself";
                    break;
            }

            Console.WriteLine(status);

            // For loop

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < orderNo.Length; i++)
            {
                Console.WriteLine(orderNo[i]);
            }

            // Do-While, While loops

            number = 0;

            do
            {
                number++;

                if (number == 7)
                    continue; // Discards the rest of the loop

                Console.WriteLine(number);
            } while (number < 10);

            Console.ReadLine();
        }
    }
}

namespace Module6.Sum
{
    class Addition
    {
        public static int Add(int a)
        {
            int b = 50;
            return a + b;
        }
    }
}