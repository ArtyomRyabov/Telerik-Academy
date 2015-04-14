namespace GenericList
{
    using System;

    public class Test
    {
        public static void Main()
        {
            GenericList<string> list = new GenericList<string>();              // Problem 5
            Console.WriteLine("Empty GenericList"); 
            Console.WriteLine(list);
            Console.WriteLine("List capacity: {0}\n", list.Capacity);

            Console.WriteLine("Adding elements to GenericList");
            list.AddElement("first");           
            list.AddElement("second");
            list.AddElement("third");
            list.AddElement("fourth");
            list.AddElement("fifth");
            Console.WriteLine(list);

            Console.WriteLine("Removing an element at index [1]:");
            list.RemoveElementAt(1);           
            Console.WriteLine(list);

            Console.WriteLine("Inserting an element \"inserted\"");
            list.InsertElementAt(2, "inserted");      
            Console.WriteLine(list);

            Console.WriteLine("Element \"{0}\" is at index {1}\n", "fifth", list.FindElement("fifth"));
            Console.WriteLine("List capacity: {0}\n", list.Capacity);

            Console.WriteLine("Getting an element at index [2] -> \"{0}\"\n", list[2]);

            Console.WriteLine("Getting the minimal element: \"{0}\"\n", list.Min());      // Problem 7
            Console.WriteLine("Getting the maximal element: \"{0}\"\n", list.Max());      // Problem 7

            Console.WriteLine("Clearing the list...");
            list.ClearGenericList();
            Console.WriteLine(list);
            Console.WriteLine("List capacity: {0}\n", list.Capacity);
        }
    }
}
