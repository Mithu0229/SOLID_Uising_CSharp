using SOLID_Uising_CSharp.Singleton_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uising_CSharp.Extensions
{
    public static class DemoExtension
    {
        public static string Revevers(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

    public class Main
    {
        public void TestExtension()
        {
            string s = "Hello word";
            string vars = s.Revevers();
            Console.WriteLine(vars);
            Singleton.Instance
        }

    }
}


