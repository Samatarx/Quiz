using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
         

            // Type your code below
            string[] questions = { "Sharks are mammals", "The human body comprises four lungs", "Carnivores are animal eaters" };
            bool[] answers = { false, false, true };
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning!!");
            }

            int askingIndex = 0;

            foreach (string question in questions)
            {

                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or False");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'");
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
                bool matchingResponse = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {matchingResponse} | Answer: {answer}");
                if (matchingResponse == answer)
                {
                    score++;
                }
                scoringIndex++;

            }
            Console.WriteLine($"Your score is: {score} out of {answers.Length}");
        }
    }
}
