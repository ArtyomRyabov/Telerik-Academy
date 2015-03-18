namespace MobilePhone
{
    using System;

    public class GSMTest                         // Problem 7
    {
        private static GSM[] phones = 
        { 
            new GSM("I9195 Galaxy S4 Mini Black", "Samsung", 455m, "", new Battery("", 130, 14, BatteryType.LiIon), new Display(4.3, 16000000)),
            new GSM("HTC ONE M8", "HTC", 935m, "", new Battery("", 496, 20, BatteryType.LiIon), new Display(5, 16000000)),
            new GSM("NEXUS 5 D821", "LG", 579m, "", new Battery("", 300, 17, BatteryType.LiPo), new Display(4.95, 16000000))
        };

        public static void PrintPhones()
        {
            Console.WriteLine("Presenting information about several mobile phones:");
            Console.WriteLine(new string('=', 51));

            foreach (GSM phone in phones)
            {
                Console.Write(phone);
                Console.WriteLine(new string('-', 30));
            }

            Console.Write(GSM.IPhone4S);
            Console.WriteLine(new string('-', 30));
        }
    }
}
