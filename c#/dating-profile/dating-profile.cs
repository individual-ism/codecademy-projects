// From Profile.cs on Codecdemy
using System;

namespace DatingProfile
{ 
  class Profile
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies = new string[0];

    private string Name
    { 
      get {return name;}
      set {name = value;}
    }
    private int Age
    { 
      get {return age;}
      set {
        if (age >= 18)
        {
          age = value;
        }
        else 
        {
          Console.WriteLine("User must be 18 years of age or older to use this application.");
        }
      }
    }
    private string City
    { 
      get {return city;}
      set {city = value;}
    }
    private string Country
    { 
      get {return country;}
      set {country = value;}
    }
    private string Pronouns
    { 
      get {return pronouns;}
      set {pronouns = value;}
    }
    private string[] Hobbies
    { 
      get {return hobbies;}
      set {hobbies = value;}
    }

    public Profile(string name, int age, string city = "N/A", string country = "N/A", string pronouns = "they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
    }

    public string ViewProfile()
    {
      string strHobbies = "";
      if (hobbies.Length == 0)
      {
        strHobbies = "None";
      }
      else {
        foreach (string hobby in hobbies)
        {
          strHobbies += $"{hobby} ; ";
        }
      }
      return ($"Name: {name} | Age: {age} | City: {city} | Country: {country} | Pronouns: {pronouns} | Hobbies: {strHobbies}");
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
  }
}


// From Program.cs on Codecademy
using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
      // sam.SetHobbies(new string[] {"listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns"});
      Console.WriteLine(sam.ViewProfile());
    }
  }
}
