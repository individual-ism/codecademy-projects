using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Do you want to create your own monster or have one generated on your behalf?");
      Console.Write("Type CREATE or RANDOM: ");
      string createOrRandom = Console.ReadLine().ToUpper();
      if (createOrRandom == "RANDOM")
      {
        RandomMode();
      }
      else 
      {
        Console.WriteLine("What type of head do you want it to have?");
        Console.Write("Type GHOST, MONSTER, or BUG: ");
        string headType = Console.ReadLine().ToUpper();
        Console.WriteLine("What type of body do you want it to have?");
        Console.Write("Type GHOST, MONSTER, or BUG: ");
        string bodyType = Console.ReadLine().ToUpper();
        Console.WriteLine("What type of feet do you want it to have?");
        Console.Write("Type GHOST, MONSTER, or BUG: ");
        string feetType = Console.ReadLine().ToUpper();
        

        BuildACreature(headType, bodyType, feetType);
      }
    }

    static void BuildACreature(string head, string body, string feet)
    {
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);
      SwitchCase(headNum, bodyNum, feetNum);
    }

    static void SwitchCase(int headNum, int bodyNum, int feetNum)
    {
     switch (headNum)
      {
        case 1:
          GhostHead();
          break;
        case 2:
          MonsterHead();
          break;
        case 3:
          BugHead();
          break;
      }
      switch (bodyNum)
      {
        case 1:
          GhostBody();
          break;
        case 2:
          MonsterBody();
          break;
        case 3:
          BugBody();
          break;
      }
      switch (feetNum)
      {
        case 1:
          GhostFeet();
          break;
        case 2:
          MonsterFeet();
          break;
        case 3:
          BugFeet();
          break;
      }
    }

    static int TranslateToNumber(string creature)
    {
      switch (creature)
      {
        case "GHOST":
          return 1;
        case "MONSTER":
          return 2;
        case "BUG":
          return 3;
        default:
          return 1;
      }
    }

    static void RandomMode()
    {
      Random randomNumber = new Random();
      int head = randomNumber.Next(1, 4);
      int body = randomNumber.Next(1, 4);
      int feet = randomNumber.Next(1, 4);
      SwitchCase(head, body, feet);
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }

  }
}
