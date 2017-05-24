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
      Post["/pets"] = _ => {
        Tamagotchi myTamagotchi = new Tamagotchi(Request.Form["new-pet"]);
        return View["/gameplay.cshtml", myTamagotchi];
      };
      Get["/pets/new/{tamagotchi}"] = parameters => {
        Tamagotchi.SetTamagotchi(parameters.tamagotchi);
        return View["new_pet.cshtml"];
      };
    }
  }
}
