using System;

namespace PatHead.Basic.Util.TypeExtensions
{
    /// <summary>
    /// array extensions
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// IsNullOrEmpty
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this Array array)
        {
            return (array == null || array.Length == 0);
        }
    }
}