using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DotNet.RegEx
{
    public class RegExBuilder
    {
        public static void Get()
        {
            while (true)
            {
                Console.WriteLine("Please input a value");
                var input = Console.ReadLine();
                ReplaceString(input);
            }
        }

        public static void GetString(string input)
        {
            string pattern = @"([a-z]+)";
            Match match = Regex.Match(input, pattern);

            if(match.Success)
            {
                Console.WriteLine($"string values from {input} is {match}");
            }
            else
            {
                Console.WriteLine($"No string values found in {input} is {match}");
            }
        }

        public static void GetStringCollection(string input)
        {
            string pattern = @"([a-z]+)"; 
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (var match in matches)
                {
                    Console.WriteLine($"string values from {input} is {match}");
                }
            }
            else
            {
                Console.WriteLine("No match found");
            }

           
        }

        public static void GetStringCollectionOperate(string input)
        {
            //Get all a A and prefix 
            // Get all b B ans postfix
            string pattern = @"([a-aA-A]+)";
            MatchCollection matchesA = Regex.Matches(input, pattern);

            pattern = @"([b-bB-B]+)";
            MatchCollection matchesB = Regex.Matches(input, pattern);

            pattern = @"([c-zC-Z]+)";
            MatchCollection notmatchesAB = Regex.Matches(input, pattern);

            string output = "";
            foreach(var item in notmatchesAB)
            {
                output = output + item;
            }
            
            for (int i = matchesA.Count-1; i >= 0;i--)
            {
                output = matchesA[i] + output;                
            }

            for (int i = 0; i < matchesB.Count; i++)
            {
                output = output  + matchesB[i];
            }

            Console.WriteLine($"New output is: {output}");
        }

        
        public static void ReplaceString(string input)
        {
            string pattern = "(Mr\\.?+ |Mrs\\.? |Miss |Ms\\.? )";

            string output = Regex.Replace(input, pattern,string.Empty);
            Console.WriteLine($"New output is: {output}");
            
        }
    }
}
