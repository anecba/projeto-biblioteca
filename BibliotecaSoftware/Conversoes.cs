using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSoftware
{
    static class Conversoes
    {
        public static char ToChar(this bool value) =>
            value ? 'S' : 'N';

        public static bool ToBool(this char value) =>
            ToBool(value.ToString());

        public static bool ToBool(this string value)
        {
            try
            {
                return "S".Equals(value.ToUpper());
            }
            catch
            {
                return false;
            }
        }
    }
}
