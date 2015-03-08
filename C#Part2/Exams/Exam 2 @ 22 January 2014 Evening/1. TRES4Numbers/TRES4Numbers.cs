namespace P1.TRES4Numbers
{
    using System;

    class TRES4Numbers
    {
        static void Main()
        {
            ulong decimalNumber = ulong.Parse(Console.ReadLine());

            Console.WriteLine(ConvertToTRresnum4(decimalNumber));
        }

        static string ConvertToTRresnum4(ulong decimalNumber)
        {
            string tresnum4 = string.Empty;

            if (decimalNumber == 0)
            {
                tresnum4 = "LON+";
            }

            while (decimalNumber > 0)
            {
                byte remainder = (byte)(decimalNumber % 9);
                decimalNumber /= 9;
                tresnum4 = Tresnum4Numbers(remainder) + tresnum4;
            }

            return tresnum4;
        }

        static string Tresnum4Numbers(byte remainder)
        {
            switch (remainder)
            {
                case 0: return "LON+";
                case 1: return "VK-";
                case 2: return "*ACAD";
                case 3: return "^MIM";
                case 4: return "ERIK|";
                case 5: return "SEY&";
                case 6: return "EMY>>";
                case 7: return "/TEL";
                case 8: return "<<DON";
                default: throw new ArgumentException();
            }
        }
    }
}
