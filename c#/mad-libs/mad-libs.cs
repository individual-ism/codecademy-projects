using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is the Mad Libs project of the C# Codecademy course
      Author: Codecademy & Alex
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Let the Mad Libs begin...\n");

      // Give the Mad Lib a title:
      string title = "A Codecademy and Alex Mad Libs Story";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Enter a name: ");
      string name = Console.ReadLine();

      Console.WriteLine("Please provide an adjective: ");
      string primaryAdjective = Console.ReadLine();
      Console.WriteLine("Please provide a second adjective: ");
      string secondaryAdjective = Console.ReadLine();
      Console.WriteLine("Please provide a tertiary adjective: ");
      string tertiaryAdjective = Console.ReadLine();
      Console.WriteLine("Please enter a verb: ");
      string verb = Console.ReadLine();
      Console.WriteLine("Please provide a noun: ");
      string primaryNoun = Console.ReadLine();
      Console.WriteLine("Please provide another noun: ");
      string secondaryNoun = Console.ReadLine();
      Console.WriteLine("Please provide an animal: ");
      string animal = Console.ReadLine();
      Console.WriteLine("Please provide an food: ");
      string food = Console.ReadLine();
      Console.WriteLine("Please provide an fruit: ");
      string fruit = Console.ReadLine();
      Console.WriteLine("Please provide an superhero: ");
      string superhero = Console.ReadLine();
      Console.WriteLine("Please provide an country: ");
      string country = Console.ReadLine();
      Console.WriteLine("Please provide an dessert: ");
      string dessert = Console.ReadLine();
      Console.WriteLine("Please provide an year: ");
      string year = Console.ReadLine();


      // The template for the story:

      string story = $"This morning {name} woke up feeling {primaryAdjective}. 'It is going to be a {secondaryAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {primaryNoun}, which made all the {fruit}s very {tertiaryAdjective}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondaryNoun}s ruled the world.";


      // Print the story:
      Console.Write(story);
    }
  }
}
