using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Given a string, that contains special character together with alphabets (‘a’ to ‘z’ and ‘A’ to‘Z’), reverse the string in a way that special characters are not affected.
            Console.WriteLine("Question 1");
            Console.WriteLine("------------------------------------------------");
            String str1 = "a!b#c$d^e";
            char[] charArray = str1.ToCharArray();

            Console.WriteLine("Input text: " + str1);

            reverse.stringCharacter(charArray);
            String reverseStr1 = new String(charArray);

            Console.WriteLine("Output text: " + reverseStr1);
            Console.WriteLine();
            Console.WriteLine();
            /************************************************/



            //Given an array of distinct integers and a sum value. Find count of triplets with sum smaller than given sum value.Expected Time Complexity is O(n 2 ).
            Console.WriteLine("Question 2");
            Console.WriteLine("------------------------------------------------");
            int sum = 2;
            int[] array = new int[] { -2, 0, 1, 3 };
            string arrVal = "";
            foreach (var item in array)
            {
                arrVal = arrVal +" "+ item;
            }
            Console.WriteLine("Input array"+arrVal);
            //Array.ForEach(array, Console.Write);
            Console.WriteLine(countTriplets.countTrip(array, array.Length, sum));
            Console.WriteLine();
            Console.WriteLine();
            /************************************************/



            //Given an array of integers, write a function that returns true if there is a triplet (a, b, c) that satisfies a 2 + b 2 = c 2.
            Console.WriteLine("Question 3");
            Console.WriteLine("------------------------------------------------");
            int[] array2 = { 3, 1, 4, 6, 5 };
            string arrVal2 = "";
            foreach (var item in array)
            {
                arrVal2 = arrVal2 + " " + item;
            }
            Console.WriteLine("Input array" + arrVal2);
            int size = array2.Length;
            if (trueIfTripplet.ITriplet(array2, size) == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
