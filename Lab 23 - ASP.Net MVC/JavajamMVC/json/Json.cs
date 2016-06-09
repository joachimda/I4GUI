using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace json
{
    public class Json
    {

        public void Serialize(List<ISerializable> list)
        {
            string jsonOut = JsonConvert.SerializeObject(list);

            using (StreamWriter sw = new StreamWriter("~/App_Data/data.json"))
            {
                sw.Write(jsonOut);
                sw.Close();
            }
        }

        public List<ISerializable> DeSerialize()
        {
            List<ISerializable> s = new List<ISerializable>();
            try
            {
                string json = File.ReadAllText("~/App_Data/data.json");
                s = JsonConvert.DeserializeObject<List<ISerializable>>(json);
            }
            catch (Exception)
            { 
              
            }

            return s;
        }
    }
}
