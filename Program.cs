using System;
using Models;

class Program
{
    static void Main(string[] args)
    {
        var stock = new Stock("EUR", 100m);
        var displayChange = new DisplayChange(stock);

        while(true)
        {
            Console.WriteLine("Insert a number");
            string userInput = Console.ReadLine();
            decimal decimalInput;

            if(decimal.TryParse(userInput, out decimalInput))
                stock.Price = decimalInput;
            else
                Console.WriteLine("Unable to parse '{0}'", userInput);
        }
    }
}