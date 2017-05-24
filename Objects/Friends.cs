using System.Collections.Generic;

namespace Friends.Objects
{
  public class Tamagotchi
  {
    private string _name;
    private static string _tamagotchi;
    private int _health;
    private int _food;
    private int _socialize;
    private int _id;
    // private static List<Tamagotchi> _instances = new List<Tamagotchi> {};

    public Tamagotchi (string name)
    {
      _health = 10;
      _food = 10;
      _socialize = 10;
      _name = name;
      // _instances.Add(this);
      // _id = _instances.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetTamagotchi()
    {
      return _tamagotchi;
    }
    public static void SetTamagotchi(string newType)
    {
      _tamagotchi = newType;
    }
    public int GetHealth()
    {
      return _health;
    }
    public void SetHealth(int newHealth)
    {
      _health = newHealth;
    }
    public int GetFood()
    {
      return _food;
    }
    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public int GetSocialize()
    {
      return _socialize;
    }
    public void SetSocialize(int newSocialize)
    {
      _socialize = newSocialize;
    }
    // public int GetId()
    // {
    //   return _id;
    // }
    // public static List<Tamagotchi> GetAll()
    // {
    //   return _instances;
    // }
    // public static Tamagotchi Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }
  }
}
