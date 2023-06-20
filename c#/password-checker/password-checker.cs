// Program.cs on Codecademy

using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "!@#$%^&*()";
      int score = 0;

      Console.WriteLine("Please provide a password: ");
      string password = Console.ReadLine();

      if (password.Length >= minLength) 
      {
        score++;
      }
      if (Tools.Contains(password, uppercase)) 
      {
        score++;
      }
      if (Tools.Contains(password, lowercase)) 
      {
        score++;
      }
      if (Tools.Contains(password, digits)) 
      {
        score++;
      }
      if (Tools.Contains(password, specialChars)) 
      {
        score++;
      }

      if (password.ToLower() == "password" || password == "1234")
      {
        score = 0;
      }
      
      Console.WriteLine(score);


      switch (score) 
      {
        case 5:
        case 4:
          Console.WriteLine("Extremely Strong");
          break;
        case 3:
          Console.WriteLine("Strong");
          break;
        case 2:
          Console.WriteLine("Medium");
          break;
        case 1:
          Console.WriteLine("Weak");
          break;
        default:
          Console.WriteLine("Password does not meet any criteria for a strong password.");
          break;

      }

    }
  }
}


// Tools.cs on Codecademy
using System;
namespace PasswordChecker
{
  public class Tools
  {
    public Tools()
    {
    }

    public static bool Contains(string target, string list)
    {
      return target.IndexOfAny(list.ToCharArray()) != -1;
    }

    public static void ContainsTest()
    {
      string loudWord = "LASDAD";
      string quietWord = "pssst";
      string mixedWord = "lkaAWEkasfkEW";

      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";

      Console.WriteLine("Running \"tests...\"");
      Console.WriteLine($"Should be true: {Contains(loudWord, uppercase)}");
      Console.WriteLine($"Should be false: {Contains(loudWord, lowercase)}");
      Console.WriteLine($"Should be false: {Contains(quietWord, uppercase)}");
      Console.WriteLine($"Should be true: {Contains(quietWord, lowercase)}");
      Console.WriteLine($"Should be true: {Contains(mixedWord, uppercase)}");
      Console.WriteLine($"Should be true: {Contains(mixedWord, lowercase)}");
    }
  }
}



// PasswordChecker.csproj on Codecademy
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
    <RootNamespace>PasswordChecker</RootNamespace>
  </PropertyGroup>

</Project>
