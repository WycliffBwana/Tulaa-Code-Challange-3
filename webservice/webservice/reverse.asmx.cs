using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webservice
{
    /// <summary>
    /// Summary description for reverse
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class reverse : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string text)
        {
            char[] charArray = text.ToCharArray();
            
            reverse.stringCharacter(charArray);
            String reverseStr1 = new String(charArray);
            
            return reverseStr1;
        }

        private static void stringCharacter(char[] charArray)
        {
            //make an array of the string
            char[] str1 = charArray;
            //give value to the first and last value of the array
            int a = str1.Length - 1;
            int b = 0;
            //Traverse string from the two ends

            while (b < a)
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
