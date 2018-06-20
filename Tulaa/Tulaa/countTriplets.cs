using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallage
{
    public class countTriplets
    {
        public static int countTrip(int[] array, int num, int sum)
        {
            // Initialize result
            int ans = 0;

            // Fix the first element as A[i]
            for (int i = 0; i < num - 2; i++)
            {
                // Fix the second element as A[j]
                for (int j = i + 1; j < num - 1; j++)
                {
                    // Now look for the third number
                    for (int k = j + 1; k < num; k++)
                    {
                        if (array[i] + array[j] + array[k] < sum)
                            ans++;
                    }
                }
            }
            return ans;
        }
    }
}
