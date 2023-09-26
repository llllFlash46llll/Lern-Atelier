using System;
namespace NameFrageProgramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hii du bist also der User der sich das Programm von meinem Meister anguckt? Freut mich dich kennenzulernen, wie ist denn dein Name? ");
            string name = Console.ReadLine();

            Console.WriteLine($" Ah wie cool, also {name} ist dein Name. Ich wünschte Ich hätte so einen coolen Namen aber ich heisse leider nur ConsoleApp 1, Menoo.");
            Console.Write($" und was ist deine lieblingsfarbe {name}?");
            string lieblingsfarbe = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta; // Ändern Sie die Textfarbe auf Lieblingsfarbe
            Console.WriteLine($"Ah wie cool, ich finde Eine Mischung von Lila und schwarz besser, aber {lieblingsfarbe} ist auch eine ziemlich coole Farbe");
            Console.ForegroundColor = ConsoleColor.Magenta; // Ändern Sie die Textfarbe auf Lieblingsfarbe
            Console.Write($" Könntest du mir nochh eine Frage beantworten {name} (Ja/Nein): ");
            string antwort = Console.ReadLine();

            if (antwort.Equals("Ja", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Magenta; // Ändern Sie die Textfarbe auf Lieblingsfarbe
                Console.Write($"Was ist den dein Traumjob {name}?");
                string Traumjob = Console.ReadLine();
                switch (Traumjob.ToLower())
                {
                    case "informatiker":
                        Console.ForegroundColor = ConsoleColor.Magenta; // Ändern Sie die Textfarbe auf Lieblingsfarbe
                        Console.WriteLine($"WOOOOW wie cool, der Job Informatiker hat mich schon immer fasziniert, Schade das ich keine Zukunft habe und ich nur Mittel zum Zweck bin");
                        break;
                    case "mediamatiker":
                        Console.ForegroundColor = ConsoleColor.Magenta; // Ändern Sie die Textfarbe auf Lieblingsfarbe
                        Console.WriteLine(" ah cool cool, ich denke aber das du hier nicht ganz richtig bist, aber ich halte mich raus und wünsche dir viel Spass... Mediamatiker was ein ungewohnter job..");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Magenta; // Ändern Sie die Textfarbe auf Lieblingsfarbe
                        Console.WriteLine($"Ah verstehe.. also {Traumjob} hätte ich jetzt wirklich nicht erwartet.. Aufjedenfall wünsche ich dir alles gute {name}");
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta; // Ändern Sie die Textfarbe auf Lieblingsfarbe
                Console.WriteLine($"oh, das ist aber nicht wirklich sehr nett {name}, naja alles gut");


            }

        }
    }
}
