namespace MobilePhone
{
    using System;

    public class GSMCallHistoryTest                  // Problem 12
    {
        private static GSM test = new GSM();

        private static Call[] calls = 
        { 
            new Call(DateTime.Now, "0888888888", 30),
            new Call(DateTime.Now, "0899999999", 60),
            new Call(DateTime.Now, "0877777777", 100) 
        };

        public static void CallsHistoryTest()
        {
            foreach (Call call in calls)
            {
                test.AddCall(call);
            }

            Console.WriteLine("\n\nPresenting information about three calls:");
            Console.WriteLine(new string('=', 41));

            foreach (Call call in test.CallHistory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine("\nTotal price of the calls: {0}", test.CallsTotalPrice(0.37m));

            Call longestCall = test.CallHistory[0];

            for (int i = 1; i < test.CallHistory.Count; i++)
            {
                if (test.CallHistory[i].Duration > longestCall.Duration)
                {
                    longestCall = test.CallHistory[i];
                }
            }

            test.CallHistory.Remove(longestCall);

            Console.WriteLine("\nRemoving the longest call:");
            Console.WriteLine(longestCall);
            Console.WriteLine("\nTotal price of the calls (after the removing): {0}", test.CallsTotalPrice(0.37m));

            test.ClearCallHistory();

            Console.WriteLine("\nClearing the call history...");
            Console.WriteLine("\nTotal price of the calls: {0}", test.CallsTotalPrice(0.37m));
            Console.WriteLine(new string('=', 34));
        }
    }
}
