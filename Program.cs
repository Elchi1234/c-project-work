using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, min = 100, mark, sum = 0;
            double avg;
            for (int a = 1; a < 8; a++)
            {
                Console.Write("Enter mark -" + a + ":");
                mark = Convert.ToInt16(Console.ReadLine());
                //Commulative Sum
                sum += mark; //sum=sum+mark
                //Highest Mark\
                if (mark > max)
                {
                    min = mark;
                }
            }
            avg = sum / 7; //Average
            //Display Answers
            Console.WriteLine("\nTotal Score - " + max +
                "\nHeight Score - " + min +
                "\nAverage Score - " + avg + "\n");
        }
    }
}



    

