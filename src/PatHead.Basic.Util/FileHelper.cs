using System.IO;

namespace PatHead.Basic.Util
{
    /// <summary>
    /// FileHelper
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// CreateDirectory
        /// </summary>
        /// <param name="destPath"></param>
        private static void CreateDirectory(string destPath)
        {
            if (string.IsNullOrWhiteSpace(destPath))
            {
                throw new FileNotFoundException("not found path");
            }

            var info = new FileInfo(destPath);
            if (info.Directory == null) return;

            if (!info.Directory.Exists)
            {
                info.Directory.Create();
            }
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="destPath">文件及路径</param>
        /// <param name="stream">流</param>
        public static void CreateFile(string destPath, Stream stream)
        {
            if (string.IsNullOrWhiteSpace(destPath))
            {
                throw new FileNotFoundException("not found path");
            }
            
            CreateDirectory(destPath);
            var fsw = new FileStream(destPath, FileMode.OpenOrCreate);
            byte[] buffer = new byte[1024 * 1024];
            while (true)
            {
                int readCount = stream.Read(buffer, 0, buffer.Length);
                fsw.Write(buffer, 0, readCount);
                if (readCount < buffer.Length)
                {
                    break;
                }
            }
            stream.Seek(0, SeekOrigin.Begin);
        }
    }
}