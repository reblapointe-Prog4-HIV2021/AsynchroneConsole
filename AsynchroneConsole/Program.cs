using System;
using System.Threading.Tasks;

namespace AsynchroneConsole
{
    public class Pain { }

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await new Program().FaireDuPainAsync();
        }

        private async Task LeverAsync()
        {
            await Task.Delay(3000);
        }

        private async Task<Pain> FaireDuPainAsync()
        {
            Console.WriteLine("Je mélange les ingrédients\n");
            Console.WriteLine("Je pétris la pâte\n");
            Task leveeTask = LeverAsync();


            Console.WriteLine("Je lave le bol\n");

            await leveeTask;
            Console.WriteLine("Je mets le pain au four\n");
            return new Pain();
        }
    }
}



