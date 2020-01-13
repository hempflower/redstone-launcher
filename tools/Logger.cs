using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RedstoneLauncher.tools
{
    /// <summary>
    /// 日志类
    /// </summary>
    public class Logger
    {
        private StringBuilder logBuffer = new StringBuilder();

        /// <summary>
        /// 写入行
        /// </summary>
        /// <param name="content">欲写入的内容</param>
        public void WriteLine(String content)
        {
            Console.WriteLine(content);
            logBuffer.AppendLine(content);
        }
        /// <summary>
        /// INFO
        /// </summary>
        /// <param name="content">欲写入的内容</param>
        /// <param name="srcPath"></param>
        /// <param name="line"></param>
        /// <param name="member"></param>
        public void Info(String content, [CallerFilePath] String srcPath = "(Unknown)", [CallerLineNumber] int line = 0, [CallerMemberName] string member = "(Unknown)")
        {
            var type = "INFO";
            this.WriteLine(String.Format("[{0}][{1}][{2}] {3}", DateTime.Now.ToString(), Path.GetFileName(srcPath) + ":" + line + "@" + member, type, content));
        }

        /// <summary>
        /// WARN
        /// </summary>
        /// <param name="content">欲写入的内容</param>
        /// <param name="srcPath"></param>
        /// <param name="line"></param>
        /// <param name="member"></param>
        public void Warn(String content, [CallerFilePath] String srcPath = "(Unknown)", [CallerLineNumber] int line = 0, [CallerMemberName] string member = "(Unknown)")
        {
            var type = "WARN";
            this.WriteLine(String.Format("[{0}][{1}][{2}] {3}", DateTime.Now.ToString(), Path.GetFileName(srcPath) + ":" + line + "@" + member, type, content));
        }

        /// <summary>
        /// ERROR
        /// </summary>
        /// <param name="content">欲写入的内容</param>
        /// <param name="srcPath"></param>
        /// <param name="line"></param>
        /// <param name="member"></param>
        public void Error(String content, [CallerFilePath] String srcPath = "(Unknown)", [CallerLineNumber] int line = 0, [CallerMemberName] string member = "(Unknown)")
        {
            var type = "ERROR";
            this.WriteLine(String.Format("[{0}][{1}][{2}] {3}", DateTime.Now.ToString(), Path.GetFileName(srcPath) + ":" + line + "@" + member, type, content));
        }

        /// <summary>
        /// DEBUG
        /// </summary>
        /// <param name="content">欲写入的内容</param>
        /// <param name="srcPath"></param>
        /// <param name="line"></param>
        /// <param name="member"></param>
        public void Debug(String content, [CallerFilePath] String srcPath = "(Unknown)", [CallerLineNumber] int line = 0, [CallerMemberName] string member = "(Unknown)")
        {
            var type = "DEBUG";
            this.WriteLine(String.Format("[{0}][{1}][{2}] {3}", DateTime.Now.ToString(), Path.GetFileName(srcPath) + ":" + line + "@" + member, type, content));
        }

        /// <summary>
        /// 将日志导出
        /// </summary>
        /// <returns>导出的日志</returns>
        public String dump()
        {
            return logBuffer.ToString();
        }
    }
}
