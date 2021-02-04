using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SplitIgnore
{
    class SplitIgnore
    {
        public static string[] split(string str, char separator, char marker)
        {
            ArrayList arr = new ArrayList();

            int start = 0, len = str.Length;

            for (int i = 1; i <= len; i++)
            {
                if (str[i - 1] == marker)
                {
                    for (int j = i; j < len; j++)
                    {
                        if (str[j] == marker)
                        {
                            arr.Add(str.Substring(i, j - i));
                            start = j + 2;
                            i = j + 2;
                            break;
                        }
                    }
                }
                if ( start != i && (i == len || str[i] == separator) )
                {
                    arr.Add(str.Substring(start, i - start));
                    start = i + 1;
                }
            }
            return (string[]) arr.ToArray(typeof(string));
        }

    }
}
