using System;
using System.Collections.Generic;

namespace planetsAndSpaceships
{
    class Program
    {
        static void Main()
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            //Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");

            List<string> newPlanetList = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(newPlanetList);
            planetList.Add("Pluto");
            planetList.Remove("Pluto");
            planetList.ForEach(planetElement => Console.WriteLine(planetElement));
            // var rockyPlanets = planetList.GetRange(0, 4);
            // rockyPlanets.ForEach(rockyElement => Console.WriteLine(rockyElement));
            Console.WriteLine(planetList);

        }
    }
}
