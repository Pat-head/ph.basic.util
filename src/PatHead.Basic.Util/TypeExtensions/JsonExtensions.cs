using System;
using Newtonsoft.Json;

namespace PatHead.Basic.Util.TypeExtensions
{
    /// <summary>
    /// json extensions
    /// </summary>
    public static class JsonExtensions
    {
        /// <summary>
        /// convert to Object
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <param name="default"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ToObject<T>(this string jsonStr, T @default = default)
        {
            if (string.IsNullOrWhiteSpace(jsonStr))
            {
                return @default;
            }

            return JsonConvert.DeserializeObject<T>(jsonStr);
        }

        /// <summary>
        /// To Json String
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this Object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}