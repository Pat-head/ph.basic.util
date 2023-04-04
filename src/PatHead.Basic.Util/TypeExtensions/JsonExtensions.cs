using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        /// <param name="settings"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string ToJson<T>(this T obj, JsonSerializerSettings settings = null)
        {
            return settings == null ? JsonConvert.SerializeObject(obj) : JsonConvert.SerializeObject(obj, settings);
        }
    }
}