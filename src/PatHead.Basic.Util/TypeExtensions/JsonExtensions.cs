using System;
using Newtonsoft.Json;

namespace PatHead.Basic.Util.TypeExtensions
{
    public static class JsonExtensions
    {
        public static T ToObject<T>(this string jsonStr)
        {
            return JsonConvert.DeserializeObject<T>(jsonStr);
        }

        public static string ToJson(this Object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}