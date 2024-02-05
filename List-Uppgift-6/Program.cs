using System;

namespace Uppgift_6
{
    class Program
    {
        static void Main()
        {

            try
            {
                Dictionary<string, int> katalog = new();
                List<string> varor = new();
                List<int> priser = new();

                Console.WriteLine("Skriv in namn på matvaror:");
                string[] input = Console.ReadLine().Split(" ");

                foreach (string vara in input)
                {
                    varor.Add(vara);
                }

                Console.WriteLine("Skriv in priser i samma ordnign:");
                string[] input2 = Console.ReadLine().Split(" ");

                foreach (string pris in input2)
                {
                    priser.Add(int.Parse(pris));
                }

                for (int i = 0;  i < priser.Count; i++)
                {
                    katalog.Add(varor[i], priser[i]);
                }

                Console.WriteLine("Skriv ut de varor som ska handlas:");
                string[] input3 = Console.ReadLine().Split(" ");
                int sum = 0;

                foreach (string vara in input3)
                {
                    sum += katalog[vara];
                }

                Console.WriteLine($"Det kommer att kosta {sum}");
                Console.ReadKey();
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Du skrev in samma vara två gånger, klicka för att starta om programmet");
                Console.ReadKey();
                Main();
            }

            catch (FormatException)
            {
                Console.WriteLine("Tyvärr, fel format på input, klicka för att starta om programmet");
                Console.ReadKey();
                Main();
            }

            catch
            {
                Console.WriteLine("Något gick snett, klicka för att gå vidare");
                Console.ReadKey();
                Main();
            }
        }
    }
}