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
        /// <param name="throwE"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ToObject<T>(this string jsonStr, T @default = default, bool throwE = false)
        {
            if (throwE)
            {
                return JsonConvert.DeserializeObject<T>(jsonStr);
            }

            try
            {
                return JsonConvert.DeserializeObject<T>(jsonStr);
            }
            catch
            {
                return @default;
            }
        }

        /// <summary>
        /// To Json String
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="settings"></param>
        /// <param name="default"></param>
        /// <param name="throwE"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string ToJson<T>(this T obj,
            JsonSerializerSettings settings = null,
            string @default = "",
            bool throwE = false)
        {
            if (throwE)
            {
                return settings == null ? JsonConvert.SerializeObject(obj) : JsonConvert.SerializeObject(obj, settings);
            }

            try
            {
                return settings == null ? JsonConvert.SerializeObject(obj) : JsonConvert.SerializeObject(obj, settings);
            }
            catch
            {
                return @default;
            }
        }
    }
}