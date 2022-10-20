using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making Music at Home Mad Lib");

            Console.WriteLine("\nBelow here, you will fill in all the blank spaces provided.\n");

            Console.WriteLine("While I've stayed at home. I've practiced the _____ for ___ hours every _____.");
            Console.WriteLine("My favorite key signature to play and practice in is _____ _____.");
            Console.WriteLine("It has ___ flats and ___ sharps.");
            Console.WriteLine("I like this key signature because it is _____.");
            Console.WriteLine("I've also gotten awesome at counting time signatures.");
            Console.WriteLine("The time signature I love is ___, because it is _____ to count");
            Console.WriteLine("One instrument I want to learn how to play while I'm at home is _____, because it is _____ and sounds like a _____.");
            Console.WriteLine("My _____ likes it when I play _____, and always gives me a round of applause after my performances!");
            Console.WriteLine("When I return to school, my teacher will be _____ of how great I am at playing my instrument.");
            Console.WriteLine("My teacher might even think I sound like _____!");

            Console.WriteLine("\nBut before we start, let us know your name.");
            Console.Write("You are? (Please input your name): ");
            string name = Console.ReadLine();
            Console.WriteLine($"Okay {name}. Let's begin.");
            Console.WriteLine("Please enter to continue . . . ");
            Console.ReadLine();

            Console.Write("Enter an instrument (you've practice): ");
            string instrument1 = Console.ReadLine();
            Console.Write("Enter a number (how many hours you spent playing the instrument): ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a day/week (on what day do you usually play the instrument): ");
            string day = Console.ReadLine();
            Console.Write("Enter a letter (the chord you're using): ");
            char chord = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a scale (major/minor)");
            string scale = Console.ReadLine();
            Console.Write("Enter a number (how many flats): ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number (how many sharps): ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an adjective (why do you like this signature): ");
            string adjective1 = Console.ReadLine();
            Console.Write("Enter a number (your time signature): ");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an adjective (why do you love this time signature): ");
            string adjective2 = Console.ReadLine();
            Console.Write("Enter an instrument (the one that you want to learn): ");
            string instrument2 = Console.ReadLine();
            Console.Write("Enter an adjective (why you want to learn that instrument): ");
            string adjective3 = Console.ReadLine();
            Console.Write("Enter a noun (what it is sound): ");
            string noun = Console.ReadLine();
            Console.Write("Enter a name (family members)");
            string family_name = Console.ReadLine();
            Console.Write("Enter a song (name of a song): ");
            string song = Console.ReadLine();
            Console.Write("Enter an adjective (reaction of your teacher): ");
            string adjective4 = Console.ReadLine();
            Console.Write("Enter a name (favorte artist/composer): ");
            string artist_name = Console.ReadLine();

            Console.WriteLine($"\nWhile I've stayed at home. I've practiced the {instrument1} for {number1} hours every {day}.");
            Console.WriteLine($"My favorite key signature to play and practice in is {chord} {scale}.");
            Console.WriteLine($"It has {number2} flats and {number3} sharps.");
            Console.WriteLine($"I like this key signature because it is {adjective1}.");
            Console.WriteLine($"I've also gotten awesome at counting time signatures.");
            Console.WriteLine($"The time signature I love is {number4}, because it is {adjective2} to count");
            Console.WriteLine($"One instrument I want to learn how to play while I'm at home is {instrument2}, because it is {adjective3} and sounds like a {noun}.");
            Console.WriteLine($"My {family_name} likes it when I play {song}, and always gives me a round of applause after my performances!");
            Console.WriteLine($"When I return to school, my teacher will be {adjective4} of how great I am at playing my instrument.");
            Console.WriteLine($"My teacher might even think I sound like {artist_name}!");

            Console.WriteLine($"\nWell there you have it {name}. I hope you had fun.");
        }
    }
}
