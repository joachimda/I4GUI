using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VittighederWpf
{
    public interface IJoke
    {
        DateTime Time { get; set; }
        string Name { get; set; }
        List<string> Tags { get; set; }
        string Source { get; set; }
        string JokeText { get; set; }
    }
}
