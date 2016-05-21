using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace pasifiklib
{
    public class GeneralSetting : AppSettings<GeneralSetting>
    {
        public string host = "185.77.91.7";
        public string lang = "tr";
        public string username = "";
        public string password = "";
    }
    public class AppSettings<T> where T : new()
    {
        private const string DEFAULT_FILENAME = "settings.json";
        public void Save(string filename = DEFAULT_FILENAME)
        {
            File.WriteAllText(filename, (new JavaScriptSerializer()).Serialize(this));
        }
        public static void Save(T pSettings, string filename = DEFAULT_FILENAME)
        {
            File.WriteAllText(filename, (new JavaScriptSerializer()).Serialize(pSettings));
        }
        public static T Load(string filename = DEFAULT_FILENAME)
        {
            T t = new T();
            if (File.Exists(filename))
                t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(filename));
            return t;
        }
    }
    public static class General
    {
        public static GeneralSetting settings = null;
        public static IDictionary<string, object> user = null;
        public static IList<string> headers = null;
    }
}
