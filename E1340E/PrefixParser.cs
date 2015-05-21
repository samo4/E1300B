using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1340E
{
    public static class PrefixParser
    {
        static Dictionary<char, double> _dict = new Dictionary<char, double>
        {
	        {'p', 1e-12},
	        {'n', 1e-9},
	        {'u', 1e-6},
	        {'m', 1e-3},
	        {'c', 1e-2},
	        {'d', 1e-1},
	        {'k', 1e3},
	        {'M',  1e6},
	        {'G', 1e9},
	        {'T', 1e12}
        };

        public static double ParseSI(this string str)
        {
            double result = 0;
            var prefixes = _dict.Keys.ToArray();

            var tempStr = str.Trim().Replace(',', '.');
            var lastchar = str.Last().ToString();

            if (lastchar.IndexOfAny(prefixes) == -1)
            {
                result = double.Parse(tempStr);
            } 
            else 
            {
                var toParse = tempStr.Substring(0, tempStr.Length - 1).Trim();
                result = double.Parse(toParse);
                result *= _dict[lastchar[0]];

            }
            return result;
        }
         

    }
}
