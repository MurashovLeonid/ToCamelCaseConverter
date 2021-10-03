using System;
using System.Linq;

namespace Convert_string_to_camel_case
{
    class ConvertToCamelCaseClass
    {
        public static string ToCamelCase(string str) =>
                String.Concat(String.Join("", str.Split('-', '_').Where(i => i == str.Split('-', '_')[0]).Select(i => i)),
                    String.Join("", str.Split('-', '_').Where(i => i != str.Split('-', '_')[0]).Select(i => i.ToUpper()[0] + i.Substring(1))));

        public static string ToCamelCase1(string str) => 
            string.Concat(str.Split('-', '_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
    }


    class Program
    {
        static void Main(string[] args)
        {
            string text = "the_Stealth_Warrior";
            Console.WriteLine(ConvertToCamelCaseClass.ToCamelCase(text));


        }
    }

}
