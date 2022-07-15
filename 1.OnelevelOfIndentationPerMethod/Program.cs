using System;
namespace _1.OnelevelOfIndentationPerMethod;


class Program
{
    public static void Main(string[] args) {

        var cache = new Cache();
        cache.BuildCache();
        var cachedCount = cache.CachedObjects.Count;
        Console.WriteLine($"something");

    }

}
