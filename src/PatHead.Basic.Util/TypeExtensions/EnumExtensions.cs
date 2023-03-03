using System;
using System.ComponentModel;

namespace PatHead.Basic.Util.TypeExtensions
{
    /// <summary>
    /// enum extensions
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Get [Description] Attribute Prop 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToDescription(this Enum source)
        {
            var fieldInfo = source.GetType().GetField(source.ToString());

            var attributes = (DescriptionAttribute[])fieldInfo?.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            return source.ToString();
        }
    }
}