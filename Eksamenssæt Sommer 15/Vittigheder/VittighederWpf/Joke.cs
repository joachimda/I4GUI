using System;
using System.Collections.Generic;

namespace VittighederWpf
{
    [Serializable]
    public class Joke : IJoke
    {
        public Joke(string name, List<string> tags, string source, string jokeText )
        {
            Time = DateTime.Now;
            Name = name;
            Tags = tags;
            Source = source;
            JokeText = jokeText;
        }
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public List<string> Tags { get; set; }
        public string Source { get; set; }
        public string JokeText { get; set; }
    }
}