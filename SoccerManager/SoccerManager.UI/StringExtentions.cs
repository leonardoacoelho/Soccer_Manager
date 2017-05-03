using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.UI
{
    public static class StringExtentions
    {
        public static int ToInt(this string str)
        {
            var val = 0;

            int.TryParse(str, out val);

            return val;
        }

        public static double ToDouble(this string str)
        {
            double val = 0;

            double.TryParse(str, out val);

            return val;
        }
    }
}
