using System;
using System.Linq;

namespace Array8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Uppgift 8
 • Slumpa 1000 heltal(1 – 100) i en array numbers.
 • Dela sedan upp alla jämna och udda tal i två nya arrayer. Ex oddNumbers och
 evenNumbers
 • Skriv sedan ut udda och jämna tal i två kolumner med de udda talen i första
 kolumnen och de jämna i andra kolumnen
            */

            //hur ska jag tänka - har under tiden jag skrivit denna kod lagt till massa console.writeline för att felsöka.
            //men tar jus edan bort dom för att snygga upp koden. lägga till kommentarer i efterhand eller?
            Random rnd = new Random();
            int[] rndNumbers = new int[1000];
            int oddCounter = 0;
            int evenCounter = 0;


            for (int i = 0; i< rndNumbers.Length; i++)
            {
                rndNumbers[i] = rnd.Next(1, 101);
                if (rndNumbers[i] % 2 == 0)
                {
                    evenCounter++;
                }
                else
                {
                    oddCounter++;
                }
            }
            try
            {

                int[] oddNumbers = new int[oddCounter];
                int[] evenNumbers = new int[evenCounter];

                int oddIndex = 0;
                int evenIndex = 0;
                for (int i = 0; i < rndNumbers.Length; i++)
                {
                    if (rndNumbers[i] % 2 == 0)
                    {
                        evenNumbers[evenIndex++] = rndNumbers[i];
                    }
                    else
                    {
                        oddNumbers[oddIndex++] = rndNumbers[i];
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("något snett hände");
               // throw;
            }


            //foreach (int i in oddNumbers)
            //{
            //    Console.Write("oddNumbers: {0}", i);
            //}


        }
    }
}
