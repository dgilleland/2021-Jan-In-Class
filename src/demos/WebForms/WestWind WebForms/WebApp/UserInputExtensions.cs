using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public static class UserInputExtensions
    {
        public static int? ToNullableInt(this string self)
        {
            int temp;
            if (int.TryParse(self, out temp))
                return temp;
            return null;
        }

        public static decimal? ToNullableDecimal(this string self)
        {
            decimal temp;
            if (decimal.TryParse(self, out temp))
                return temp;
            return null;
        }

        public static DateTime? ToNullableDateTime(this string self)
        {
            DateTime temp;
            if (DateTime.TryParse(self, out temp))
                return temp;
            return null;
        }
    }
}