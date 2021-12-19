using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Julbord
    {
        public static void AddVisitor()
        {
            Visitor Visitor = new Visitor();

            Console.WriteLine("Förnamn:");
            Visitor.FirstName = Console.ReadLine();
            Console.WriteLine("\r");

            Console.WriteLine("Efternamn:");
            Visitor.LastName = Console.ReadLine();
            Console.WriteLine("\r");

            Console.WriteLine("Epost:");
            Visitor.Email = Console.ReadLine();
            Console.WriteLine("\r");

            Console.WriteLine("Ålder:");
            Visitor.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r");

            File.AppendAllText(@"visitors.txt", $"{Visitor.FirstName} {Visitor.LastName}, {Visitor.Email}, {Visitor.Age} {Environment.NewLine}");

        }


        public void Remove()
        {
            Visitors();
            Console.WriteLine("\r");

            Console.WriteLine("Skriv Förnamn och Efternamn på besökaren du vill ta bort.:");
            string strFilePath = "visitors.txt";
            string strSearchText = Console.ReadLine();
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(path: strFilePath);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(strFilePath, n);
            Console.WriteLine("\r");

            Console.WriteLine(strSearchText + " Har blivit bortplockad från julbordet </3 :(");
        }

        public static void Visitors()
        {
            string file = @"visitors.txt";

            if (File.Exists(file))
            {
                string text = File.ReadAllText(file);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Inga besökare registrerade på julbordet");
            }
        }

        public void Discount()
        {
            Console.WriteLine("Med denna får du 20% på valfri dryck eller rätt");
            Console.WriteLine(@"Rabattkoden är" + " " + Guid.NewGuid() + ".");
        }

        readonly string menu = @"
                Lägg till                  Lägg till en besökare i listan
                Ta bort                    Ta bort en besökare från listan
                Visa                       Visar alla besökare i listan
                Rabatt <3                  Få din rabattkod
                Meny                       Se Menyvalen
                Avsluta                    Avslutar programmet";

        public void Menu()
        {
            Console.WriteLine(menu);
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}

