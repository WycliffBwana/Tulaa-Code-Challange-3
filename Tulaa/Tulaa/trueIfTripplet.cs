using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallage
{
    public class trueIfTripplet
    {
        // to return true or false if array2 is a triplet
        public static bool ITriplet(int[] arr, int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j < num; j++)
                {
                    for (int k = j + 1; k < num; k++)
                    {
                        //Get the square of elements
                        int a = arr[i] * arr[i], 
                            b = arr[j] * arr[j], 
                            c = arr[k] * arr[k];

                        if (a == b + c ||
                            b == a + c ||
                            c == a + b)
                            return true;
                    }
                }
            }
            Console.WriteLine("Triplet not found");
            return false;
        }
    }
}
