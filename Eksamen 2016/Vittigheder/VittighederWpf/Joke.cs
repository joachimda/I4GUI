using System;
using System.Collections.Generic;

namespace VittighederWpf
{
    [Serializable]
    public class Joke
    {
        /// <summary>
        /// This constructor is needed for Json to work
        /// </summary>
        public Joke()
        {
            //No implementation
        }

        /// <summary>
        /// Constructor for Joke where no punchline is passed
        /// </summary>
        /// <param name="name">Name to call the joke</param>
        /// <param name="tags">Tags to associate the jokes with</param>
        /// <param name="source">The author of the joke</param>
        /// <param name="setup">The setup - The actual joke</param>
        public Joke(string name, List<string> tags, string source, string setup)
        {
            Name = name;
            Tags = tags;
            Source = source;
            Setup = setup;
            Time = DateTime.Now;
            IsRiddle = false;
        }

        /// <summary>
        /// Constructor for Joke where punchline is given. The joke is a riddle.
        /// </summary>
        /// <param name="name">The name of the joke</param>
        /// <param name="tags">Tags to associate the jokes with</param>
        /// <param name="source">The author of the joke</param>
        /// <param name="setup">The setup - The actual joke</param>
        /// <param name="punchline">The punchline - Answer to the riddle</param>
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


        /// <summary>
        /// Checks if the tag searched for exists in the tag list
        /// </summary>
        /// <param name="tag">The tag to search for</param>
        /// <returns>True if found false if not</returns>
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
        }
    }
}