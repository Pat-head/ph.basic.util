using Newtonsoft.Json;

namespace PatHead.Basic.Util.TypeExtensions
{
    /// <summary>
    /// ObjectExtensions
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Deep Clone
        /// </summary>
        /// <param name="source"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T DClone<T>(this T source)
        {
            var settings = new JsonSerializerSettings();
            return source.ToJson(settings).ToObject<T>();
        }
    }
}