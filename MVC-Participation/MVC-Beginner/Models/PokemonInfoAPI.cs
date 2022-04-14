using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Beginner.Models
{
    public class PokemonInfoAPI
    {
        //weight, height and then their images (sprites).
        public int height { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public sprite sprites { get; set; }
    }

    public class sprite
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
        public sprite()
        {
            back_default = string.Empty;
            front_default = string.Empty;
        }
        //public override string ToString()
        //{
        //    return $"{front_default}";
        //}

    }
}