using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SplitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = SplitIgnore.split(@"*'** 8*** ' *", ' ', '\'');
            foreach (string s in str)
            {
                Console.WriteLine(s);
            }
        }
    }
}
