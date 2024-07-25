using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d"; //@"\d{5}, @"there" ... 
            Regex regex = new Regex(pattern);

            string text = "Hi thre, my number is 321456";

            MatchCollection matchCollection = regex.Matches(text);
            Console.WriteLine("{0} hits has found:\n{1}", matchCollection.Count, text);

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }

            Console.ReadKey();
        }
    }
}
