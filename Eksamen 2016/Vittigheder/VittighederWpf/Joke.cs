using System;
using System.Collections.Generic;
using System.Linq;

namespace VittighederWpf
{
    [Serializable]
    public class Joke
    {
        public Joke(string name, List<string> tags, string source, string setup)
        {
            Name = name;
            Tags = tags;
            Source = source;
            Setup = setup;
            Time = DateTime.Now;
            IsRiddle = false;
        }
        public Joke(string name, List<string> tags, string source, string setup, string punchline)
        {
            Name = name;
            Tags = tags;
            Source = source;
            Setup = setup;
            Punchline = punchline;
            Time = DateTime.Now;
            IsRiddle = true;
        }
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public List<string> Tags { get; set; }
        public string Source { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
        public bool IsRiddle { get; set; }

        public bool ContainsTag(string tag)
        {
            foreach (var item in Tags)
            {
                if (item.Contains(tag))
                {
                    return true;
                }
            }
            return false;

            //return Tags.Any(item => item.Contains(tag));
        }
    }
}