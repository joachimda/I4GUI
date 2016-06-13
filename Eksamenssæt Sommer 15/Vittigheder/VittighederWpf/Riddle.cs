using System;
using System.Collections.Generic;

namespace VittighederWpf
{
    class Riddle : IJoke
    {
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public List<string> Tags { get; set; }
        public string Source { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}