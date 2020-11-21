using System;
using PriceMLConsoleML.Model;


namespace PriceMLConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput();

            ModelOutput output = ConsumeModel.Predict(input);
            Console.WriteLine($"Input Info");
        }
    }
}
