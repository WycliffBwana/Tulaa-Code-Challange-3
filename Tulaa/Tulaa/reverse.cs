using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallage
{
    public class reverse
    {
        public static void stringCharacter(char[] charArray)
        {
            //make an array of the string
            char[] str1 = charArray;
            //give value to the first and last value of the array
            int a = str1.Length - 1;
            int b = 0;
            //Traverse string from the two ends

            while (b<a)
            {
                //skip special characters
                if (!char.IsLetter(str1[b]))
                {
                    b++;
                }
                else if (!char.IsLetter(str1[a]))
                {
                    a--;
                }
                else
                {
                    char str2 = str1[b];
                    str1[b] = str1[a];
                    str1[a] = str2;
                    b++;
                    a--;
                }
            }
        }
    }
}
