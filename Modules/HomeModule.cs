using Nancy;
using Friends.Objects;
using System.Collections.Generic;

namespace TamagotchiGame
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/name_pet"] = _ => {
        // myTamagotchi.GetTamagotchi();
        return View["name_pet.cshtml"];
      };
      Post["/pets/select"] = _ => {
        Tamagotchi myTamagotchi = new Tamagotchi(Request.Form["new-pet-name"]);
        return View["gameplay.cshtml", myTamagotchi];
      };
      Post["pets/heal"] = _health => {
        Tamagotchi myTamagotchi = new Tamagotchi(Request.Form["heal"]);
        myTamagotchi.HealthUp(_health);
        return View["gameplay.cshtml", myTamagotchi];
      };
    }
  }
}
