using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetworkManager.Utilities.Log
{
    public class LogText : ILog<string>, ILogText   
    {
        public string GetLogText()
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.txt";
            var currentContent = string.Empty;
            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                streamReader.Close();
            }
            return currentContent;
        }

        public void SaveLog(string action)
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.txt";
            var currentContent = string.Empty;
            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                streamReader.Close();
            }
            var streamWriter = new StreamWriter(logPath);
            streamWriter.WriteLine($"{DateTime.Now} - {action}");
            streamWriter.WriteLine(currentContent);
            streamWriter.Close();
        }


    }
}
