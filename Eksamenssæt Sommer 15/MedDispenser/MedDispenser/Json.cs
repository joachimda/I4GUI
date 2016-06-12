using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using MedDispenser.Models;
using Newtonsoft.Json;

namespace MedDispenser
{
    public class Json
    {
        private string path = @"/App_Data/med_rules.json";
        public void Serialize(List<MedRule> list)
        {
            string jsonOut = JsonConvert.SerializeObject(list);

            using (StreamWriter sw = new StreamWriter(path))
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
                string json = File.ReadAllText(path);
                s = JsonConvert.DeserializeObject<List<MedRule>>(json);
            }
            catch (Exception)
            {

            }

            return s;
        }
    }
}