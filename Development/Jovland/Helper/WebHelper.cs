using System;
using System.IO;
using System.Linq;
using System.Web;

namespace Jovland.Helper
{
    public static class WebHelper
    {

        #region "DownloadFile:下载文件"
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="downloadPath"></param>
        /// <param name="server"></param>
        /// <param name="response"></param>
        /// <param name="fileName"></param>
        public static void DownloadFile(this string downloadPath, HttpServerUtilityBase server, HttpResponseBase response, string fileName)
        {
            if (!File.Exists(downloadPath))
            {
                Console.WriteLine("下载的资源不存在!");
                return;
            }
            FileStream iStream = null;
            byte[] buffer;

            try
            {
                var downloadFile = new FileInfo(downloadPath);
                //response.Clear();
                response.ClearHeaders();
                response.ContentType = "application/octet-stream";
                response.AppendHeader("Content-Disposition", "attachment;filename=" + server.UrlEncode(fileName + ".rar"));
                response.AppendHeader("Content-Length", downloadFile.Length.ToString());
                iStream = new FileStream(downloadPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                var dataToRead = iStream.Length;
                buffer = new byte[dataToRead];
                iStream.Read(buffer, 0, buffer.Count());
                iStream.Close();
                response.BinaryWrite(buffer);
                response.Buffer = true;
                response.Flush();
                response.Close();
                response.End();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (iStream != null) iStream.Close();
            }
        }
        #endregion
    }
}