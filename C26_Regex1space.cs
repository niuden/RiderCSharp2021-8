using System;
using System.Text.RegularExpressions;
namespace RiderCSharp2021
{
    public class C26_Regex1space
    {
        public void show()
        {
            string input = "Hello   World   ";
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);    
            Console.ReadKey();

        }
    }
}