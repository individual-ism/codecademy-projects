using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[]
            {
                "Two American presidents have served non-consecutive terms.",
                "The longest serving leader of the Soviet Communist Party was Josef Stalin.",
                "Q.E.D. is the abbreviation for Quid Est Deus.",
                "The first fifteen decimal places of Euler's Number are 718281828459045."
            };
            bool[] answers = new bool[] { false, true, false, true };
            bool[] responses = new bool[4];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine(
                    $"The number of questions does not match the number of answers.\nQuestions: {questions.Length}\nAnswers: {answers.Length}"
                );
            }

            int askingIndex = 0;

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Console.Write("True or false: ");
                string input = Console.ReadLine();
                bool inputBool;
                bool isBool = Boolean.TryParse(input, out inputBool);
                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool res = responses[scoringIndex];
                Console.WriteLine($"Input: {res} | Answer: {answer}");
                if (res == answer)
                {
                    score++;
                }
                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {answers.Length} correct!");
        }
    }
}
