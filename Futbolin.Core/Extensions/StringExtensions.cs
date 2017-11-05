using System;

namespace Futbolin
{
    public static class StringExtensions
    {
        public static bool HasContent(this string value)
        {
            return !String.IsNullOrWhiteSpace(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return String.IsNullOrWhiteSpace(value);
        }
    }
}
