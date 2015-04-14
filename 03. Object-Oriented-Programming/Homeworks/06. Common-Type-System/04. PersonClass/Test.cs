namespace PersonClass
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Person peter = new Person("Peter");
            Person pavel = new Person("Pavel", 30);

            Console.WriteLine(peter);
            Console.WriteLine(pavel);
        }
    }
}
