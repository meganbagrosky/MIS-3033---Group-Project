using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Beginner.Models
{
    public class PokemonAPi
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Pokemon> results { get; set; }
    }

    public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}