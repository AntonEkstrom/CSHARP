namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Julbord Show = new();

            Console.WriteLine("\r\n \r\n");
            Console.WriteLine("            Välkommen till julbordet! \r\n");
            Console.WriteLine("            Välj ett alternativ:");
            Console.WriteLine(@"
                Lägg till                  Lägg till en besökare i listan
                Ta bort                    Ta bort en besökare från listan
                Visa                       Visar alla besökare i listan
                Rabatt <3                  Få din rabattkod
                Meny                       Se Menyvalen
                Avsluta                    Avslutar programmet");

            Console.Write("\r\n \r\n >");

            string UserInput = Console.ReadLine();

            while (!UserInput.Equals("") && !UserInput.ToLower().Equals("exit"))
            {
                if (UserInput.StartsWith("Lägg till") || UserInput.StartsWith("lägg till"))
                {
                    Julbord.AddVisitor();
                }
                else if (UserInput.StartsWith("Ta bort") || UserInput.StartsWith("ta bort"))
                {
                    Show.Remove();
                }
                else if (UserInput.StartsWith("Visa") || UserInput.StartsWith("visa"))
                {
                    Julbord.Visitors();
                }
                else if (UserInput.StartsWith("Rabatt <3") || UserInput.StartsWith("rabatt <3") || UserInput.StartsWith("Rabatt") || UserInput.StartsWith("rabatt"))
                {
                    Show.Discount();
                }
                else if (UserInput.StartsWith("Menu") || UserInput.StartsWith("meny"))
                {
                    Show.Menu();
                }
                else if (UserInput.StartsWith("Avsluta") || UserInput.StartsWith("avsluta"))
                {
                    Show.Exit();
                }
                else
                {
                    Console.WriteLine("Ogiltigt kommando, försök igen!");
                }
                Console.Write("\r\n \r\n >");
                UserInput = Console.ReadLine();
            }
        }
    }
}
