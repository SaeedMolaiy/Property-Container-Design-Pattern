using System;
using PropertyContainer.Models;

namespace PropertyContainer
{
    internal class Program
    {
        static void Main()
        {
            var context = new Context();
            context.AddProperty("FullName", "Saeed Molaiy");

            Console.WriteLine(context.GetProperty("FullName").ToString());

            Console.ReadKey();
        }
    }
}
