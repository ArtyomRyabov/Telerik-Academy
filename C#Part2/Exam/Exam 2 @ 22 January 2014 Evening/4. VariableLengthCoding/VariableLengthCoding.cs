namespace P4.VariableLengthCoding
{
    using System;
    using System.Text;

    class VariableLengthCoding
    {
        static void Main()
        {   
            //Reading the input:
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int numberOfLines = int.Parse(Console.ReadLine());
            string[] codes = new string[numberOfLines];

            for (int i = 0; i < codes.Length; i++)
            {
                string line = Console.ReadLine();
                int index = int.Parse(line.Substring(1));
                codes[index - 1] = line.Substring(0, 1);
            }
            
            StringBuilder textToBinary = new StringBuilder();
            StringBuilder result = new StringBuilder();

            //Converting text to binary :
            for (int i = 0; i < text.Length; i++)
            {
                textToBinary.Append(Convert.ToString(Convert.ToInt32(text[i]), 2).PadLeft(8, '0'));
            }

            textToBinary.Append(0);
            int counter = 0;

            //Decoding data:
            for (int i = 0; i < textToBinary.Length; i++)
            {
                if (textToBinary[i] == '1')
                {
                    counter++;
                }
                else if (textToBinary[i] == '0' && textToBinary[i - 1] == '1')
                {
                    result.Append(codes[counter - 1]);
                    counter = 0;
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
