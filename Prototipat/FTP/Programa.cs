using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace FTP
{
    class Programa
    {
        public static void Main(string[] args)
        {
                {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("172.17.6.9");
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                request.Credentials = new NetworkCredential("g06", "12345aA");

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                Console.WriteLine(reader.ReadToEnd());

                Console.WriteLine("Download Complete, status {0}", response.StatusDescription);
                
                reader.Close();
                reader.Dispose();
                response.Close();
            }
        }
    }
}
