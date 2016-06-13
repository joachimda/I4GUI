using System;
using System.Collections.Generic;

namespace VittighederWpf
{
    public class Joke : IJoke
    {
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public List<string> Tags { get; set; }
        public string Source { get; set; }
    
    }
}