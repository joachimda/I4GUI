using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using VittighederWeb.Models;

namespace VittighederWeb.Tools
{
    public class JsonToolbox
    {
        private readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\webData.json";


        /// <summary>
        /// Serializes a list of Joke objects and writes them to a file
        /// </summary>
        /// <param name="list">The list of jokes to be serialized</param>
        public void Serialize(List<Joke> list)
        {
            string jsonOut = JsonConvert.SerializeObject(list);
            using (StreamWriter streamWriter = new StreamWriter(_path))
            {
                streamWriter.Write(jsonOut);
                streamWriter.Close();
            }
        }
    }
}