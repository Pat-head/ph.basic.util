using System;
using System.Text;

namespace PatHead.Basic.Util.Cryptography
{
    /// <summary>
    /// base64 encryption
    /// </summary>
    public class Base64Encryption
    {
        /// <summary>
        /// 将字符串转换成base64格式,使用UTF8字符集
        /// </summary>
        /// <param name="content">加密内容</param>
        /// <returns></returns>
        public static string Encode(string content)
        {
            var bytes = Encoding.UTF8.GetBytes(content);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// 将base64格式，转换utf8
        /// </summary>
        /// <param name="content">解密内容</param>
        /// <returns></returns>
        public static string Decode(string content)
        {
            var bytes = Convert.FromBase64String(content);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}