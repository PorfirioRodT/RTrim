using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTrimApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("");

        }

        public static string RTrim(string str){

            if(string.IsNullOrWhiteSpace(str)){

                return string.Empty;

            }

            string result = string.Empty;

            char ignoreSpaces = ' ';

            int endIndex = str.Length - 1;

            for (; endIndex >= 0 && str[endIndex] == ignoreSpaces; endIndex--);

            StringBuilder stringBuilder = new StringBuilder(endIndex + 1);
            
            for (int i = 0; i <= endIndex; i++)
            {

                stringBuilder.Append(str[i]);
                
            }

            result = stringBuilder.ToString();

            return result;

        }

    }
}
