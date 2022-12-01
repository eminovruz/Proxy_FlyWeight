//////////////////////////////// FlyWeight
namespace Flyweight;

interface Flyweight
{
    public void Operation(string Ammotype);
}

class ConcreteFlyweight : Flyweight
{
    public void Operation(string ammo)
    {
        Console.WriteLine(" Ammo type: " + ammo);
    }
}

class FlyweightFactory
{
    private static Dictionary<string, Flyweight> _flyweights = new();
    public FlyweightFactory()
    {
        _flyweights.Add("Pistol", new ConcreteFlyweight());
        _flyweights.Add("AK-47", new ConcreteFlyweight());
    }

    public Flyweight GetFlyweight(string key) => _flyweights[key];     //return ammo type

}