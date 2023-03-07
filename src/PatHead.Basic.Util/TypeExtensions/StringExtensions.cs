using System.Text.RegularExpressions;

namespace PatHead.Basic.Util.TypeExtensions
{
    /// <summary>
    /// StringExtensions
    /// </summary>
    public static class StringExtensions
    {
        private static readonly Regex DigitRegex = new Regex("^\\d+$");

        /// <summary>
        /// IsDigit
        /// </summary>
        /// <param name="text">text</param>
        /// <returns></returns>
        public static bool IsDigit(this string text)
        {
            return !text.IsNullOrWhiteSpace() && DigitRegex.IsMatch(text);
        }

        /// <summary>
        /// IsNullOrEmpty
        /// </summary>
        /// <param name="text">text</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }


        /// <summary>
        /// IsNullOrEmpty
        /// </summary>
        /// <param name="text">text</param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }
    }
}