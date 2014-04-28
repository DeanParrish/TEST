using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace TEST
{
    class FileUpdate
    {

        public string DownloadUpdate(string address)
        {
            string text;

            using (var client = new WebClient())
            {
                text = client.DownloadString(address);
            }
            return text;
        }
        public string UpdateFile(string path, string newFile)
        {
            try
            {
                File.WriteAllText(path, newFile);
                return "Update Succeeded.";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Update Failed.";
            }
        }
    }
}
