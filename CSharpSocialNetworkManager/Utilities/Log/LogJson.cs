using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CSharpSocialNetworkManager.Utilities.Log
{
    public class LogJson : ILog<LogObject>, ILog<string>
    {
        public void SaveLog(LogObject action)
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.json";
            var currentContent = string.Empty;

            var logObjectsList = new List<LogObject>();

            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                logObjectsList = JsonConvert.DeserializeObject<List<LogObject>>(currentContent);
                streamReader.Close();
            }
            var streamWriter = new StreamWriter(logPath);

            //var logObject = new LogObject() { LogDate = DateTime.Now, Action = action };
            logObjectsList.Add(action);
            var jsonResult = JsonConvert.SerializeObject(logObjectsList);

            streamWriter.WriteLine(jsonResult);
            streamWriter.Close();
        }

        public void SaveLog(string action)
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.json";
            var currentContent = string.Empty;

            var logObjectsList = new List<LogObject>();

            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                logObjectsList = JsonConvert.DeserializeObject<List<LogObject>>(currentContent);
                streamReader.Close();
            }
            var streamWriter = new StreamWriter(logPath);

            logObjectsList.Add(new LogObject() { LogDate = DateTime.Now, Action = action });
            var jsonResult = JsonConvert.SerializeObject(logObjectsList);

            streamWriter.WriteLine(jsonResult);
            streamWriter.Close();
        }
    }
}
