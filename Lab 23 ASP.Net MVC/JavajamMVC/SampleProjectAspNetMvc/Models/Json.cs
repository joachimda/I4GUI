using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;
using SampleProjectAspNetMvc.Models;

namespace json
{
    public class Json
    {
        private string path = @"F:/Cygwin64/home/Mr. Derp/Git repos/I4GUI - Joachim/SampleProjectAspNetMvc/SampleProjectAspNetMvc/App_Data/data.json";
        public void Serialize(List<UserInfo> list)
        {
            string jsonOut = JsonConvert.SerializeObject(list);
            
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(jsonOut);
                sw.Close();
            }
        }

        public List<UserInfo> DeSerialize()
        {
            List<UserInfo> s = new List<UserInfo>();
            try
            {
                string json = File.ReadAllText("~/App_Data/data.json");
                s = JsonConvert.DeserializeObject<List<UserInfo>>(json);
            }
            catch (Exception)
            { 
              
            }

            return s;
        }
    }
}
