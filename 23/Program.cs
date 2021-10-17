using System;

namespace _23
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            
            Console.WriteLine(CalSubString(str));
        }
        static string CalSubString(string str)
        {
            string subStr = "";
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                subStr = str.Remove(i, 1);
                res = str.Substring(i, 1);
                if (CalcArifMean(subStr)== CalcArifMean(str))
                {
                    CalSubString(subStr);
                    return res;
                }
                
                
            }
            return str;


        }
        static double CalcArifMean(string subStr)
        {
            int sum = 0;
            for (int i = 0; i < subStr.Length; i++)
                sum += int.Parse(Convert.ToString(subStr[i]));
            
            return (double)sum / subStr.Length;
        }
    }
}
