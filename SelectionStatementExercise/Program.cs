using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        public static string GuessFavNUm()
        {
            var r = new Random();
            var favNum = r.Next(1, 100);
            Console.WriteLine("Guess my favorite number: ");
            var userInput = int.Parse(Console.ReadLine());
            while (userInput != favNum )
            {
                if (userInput < favNum) { Console.WriteLine( "Too Low"); }
                else if (userInput > favNum) { Console.WriteLine("Too High"); }
                else { break; }
                userInput = int.Parse(Console.ReadLine());
            }
            return "You got it!";
        }

        //I just wanted to also try it a for loop, I tried several different ways and thought they didnt work because I made a dumb mistake so am retrying to varify
        public static string GuessBetter()
        {
            var r = new Random();
            var favNum = r.Next(1, 100);
            Console.WriteLine("Guess my favorite number: ");
            for (var userInput = int.Parse(Console.ReadLine()); userInput != favNum; userInput = int.Parse(Console.ReadLine())) 
            {
                if (userInput < favNum) { Console.WriteLine("Too Low"); }
                else if (userInput > favNum) { Console.WriteLine("Too High"); }
                else { break; }
            }
            return "You got it!";
        }

        public static string FaveSubject()
        {
            Console.WriteLine("What's your favorite subject to study? ");
            string sub = Console.ReadLine().ToLower();
            switch (sub) 
            {
                case "math":
                    return "Oh cool, my brother does that for a living, you must be a smart cookie";
                    
                case "science":
                    Console.WriteLine("fascinating, what's what kind?");
                    string subScience = Console.ReadLine().ToLower();
                    switch (subScience)
                    {
                        case "biology": return "Neat! I love animals and thats all I'll say"; 
                        case "chemistry": return "Oof, that's hard, moving on...";
                        case "anstronomy": return "Awesome, very interesting!";
                        case "physics": return "Ohhh very cool.";
                        case "psychology": return "I love psychology!";
                        default: return "Pfff that's not a real science";
                    }
                case "history":
                    return "Oh nice! I'd ask you what's your favorite era but that's a lot of switch cases";
                case "english":
                    return "Nice, always loved those classes";
                case "social studies":
                    return "I dont know a ton about that, but I have many friends that went into that and love it";
                default:
                    return "Umm.. ok... sure.";
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(GuessFavNUm());
            //Console.WriteLine(GuessBetter());
            Console.WriteLine(FaveSubject());
        }
    }
}
