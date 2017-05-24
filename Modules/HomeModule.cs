using Nancy;
using Friends.Objects;
using System.Collections.Generic;

namespace Tamagotchi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/pets"] = _ => {
        Tamagotchi newTamagotchi = new Tamagotchi (Request.Form["new-pet"]);
        return View["/pet.cshtml", newTamagotchi];
      };
      

    }
  }
}
