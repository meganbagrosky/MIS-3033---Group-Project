using MVC_Beginner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC_Beginner.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokemonAPi allpokemon;
            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?offset=0&limit=1200").Result;

                allpokemon = JsonConvert.DeserializeObject<PokemonAPi>(json);
            }
            return View(allpokemon.results );
        }
        public ActionResult Info(string id)
        {
            PokemonInfoAPI info;
            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{id}").Result;

                info = JsonConvert.DeserializeObject<PokemonInfoAPI>(json);
            }
            return View(info);
        }
    }
}