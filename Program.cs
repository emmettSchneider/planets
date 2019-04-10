using System;
using System.Collections.Generic;

namespace NSSOrientation
{
  public class Program
  {
    public static void Main()
    {
      // Initial list of planets
      List<string> planetList = new List<string>() {
        "Mercury",
        "Mars"
      };

      // Add() Jupiter and Saturn at the end of the list.
      planetList.Add("Jupiter");
      planetList.Add("Saturn");

      // Create another List that contains the last two planets of our solar system.
      List<string> lastPlanets = new List<string>() {
        "Uranus", "Neptune"
      };

      // Combine the two lists by using AddRange().
      planetList.AddRange(lastPlanets);

      // Use Insert() to add Earth, and Venus in the correct order
      planetList.Insert(1, "Venus");
      planetList.Insert(2, "Earth");

      // Use Add() again to add Pluto to the end of the list.
      planetList.Add("Pluto");

      // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
      List<string> rockyPlanets = planetList.GetRange(0, 4);
      Console.WriteLine("~~Rocky Planets~~");
      foreach (string planet in rockyPlanets)
      {
        Console.WriteLine(planet);
      };

      // Writing all planets to the console for verification that steps worked
      Console.WriteLine("~~All planets + Pluto~~");

      foreach (string planet in planetList)
      {
        Console.WriteLine(planet);
      };

      // being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
      planetList.Remove("Pluto");

      // Writing all planets (now without Pluto) to the console for verification that steps worked
      Console.WriteLine("~~The REAL planets (poor Pluto)~~");
      foreach (string planet in planetList)
      {
        Console.WriteLine(planet);
      };
    }
  }
}