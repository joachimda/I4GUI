using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Helpers;
using MedDispenser.Models;
using Newtonsoft.Json;
using System.Windows;

namespace MedDispenser
{
    public class JsonToolbox

    {
        private readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\medDispenserData.json";

        //private readonly string _path = Directory.GetCurrentDirectory()+@"\\App_Data\\medRules.json";

        public void Serialize(List<MedRule> list)
        {
            string jsonOut = JsonConvert.SerializeObject(list);

            using (StreamWriter sw = new StreamWriter(_path))
            {
                sw.Write(jsonOut);
                sw.Close();
            }
        }

        public List<MedRule> DeSerialize()
        {
            List<MedRule> s = new List<MedRule>();
            try
            {
                string json = File.ReadAllText(_path);
                s = JsonConvert.DeserializeObject<List<MedRule>>(json);
            }
            catch (Exception)
            {
                throw new ArgumentException("The path is: " + _path);
            }

            return s;
        }
    }
}