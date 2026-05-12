using System;

namespace ConsoleApplication1_csharp1
{
    internal class MyConsole
    {
        public static string Ask(string question)
        {
            Console.WriteLine(question + " ");
            return Console.ReadLine();
        }

        public static int AskForInt(string ball)
        {
            var answerStr = Ask(ball);
            return Convert.ToInt32(answerStr);
        }

        public static double AskForDouble(string weather)   // to this we have to reply with a comma , not with a full stop .
        {
            var answerStr = Ask(weather);
            return Convert.ToDouble(answerStr);
        }
        
        public static bool AskForBool(string bDayYet)
        {
            var answerStr = Ask(bDayYet + " y/n");
            return answerStr.ToLower().StartsWith("y");
        }

    }
}