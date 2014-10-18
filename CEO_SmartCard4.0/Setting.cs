using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CEO_SmartCard4._0
{
    public class Setting
    {

        public void SaveSetting<T>(T Value)
        {
            using (StreamWriter  streamWriter = new StreamWriter(CEO_Configuration.CoreConfig.SettingFile,false))
            {
                String text = Newtonsoft.Json.JsonConvert.SerializeObject(Value);
                streamWriter.Write(text);
            }
        }
        public T ReadSetting<T>()
        {
            using (StreamReader streamReader = new StreamReader(CEO_Configuration.CoreConfig.SettingFile,false))
            {
                string text = streamReader.ReadToEnd();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(text);
            }
        }
    }

}
