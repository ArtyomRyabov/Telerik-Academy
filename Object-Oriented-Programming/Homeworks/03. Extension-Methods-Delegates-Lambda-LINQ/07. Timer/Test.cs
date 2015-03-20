namespace TimerProblem
{
    using System;

    public class Test
    {
        private static void PrintMethod()
        {
            Console.WriteLine(" another test line");
        }

        public static void Main()
        {
            Timer timer = new Timer(300, 20);
            timer.TDelegate += PrintMethod;

            Console.WriteLine("--- Start Test ----");
            timer.Execute();
            Console.WriteLine("--- Finish Test ---");
        }
    }
}
