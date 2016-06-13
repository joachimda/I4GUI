using System;
using System.Collections.Generic;

namespace VittighederWpf
{
    [Serializable]
    public class Riddle
    {
        public Riddle(string name, List<string> tags, string source, string setup, string punchline)
        {
            Name = name;
            Tags = tags;
            Source = source;
            Setup = setup;
            Punchline = punchline;
            Time = DateTime.Now;
        }
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public List<string> Tags { get; set; }
        public string Source { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}