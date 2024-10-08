using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] info;
        
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("How old are you?");
        string age = Console.ReadLine();
        Console.WriteLine("What color are your eyes?");
        string eyeColor = Console.ReadLine();
        Console.WriteLine("What color is your hair?");
        string hairColor = Console.ReadLine();
        Console.WriteLine("What is your shoe size?");
        string shoeSize = Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
        string favoriteColor = Console.ReadLine();
        Console.WriteLine("What is your Favorite TV Show?");
        string favoriteTV = Console.ReadLine();
        Console.WriteLine("Who is your favorite teacher?");
        string favoriteTeacher = Console.ReadLine();
        Console.WriteLine("What is your favorite class?");
        string favoriteClass = Console.ReadLine();
        Console.WriteLine("What is your favorite holiday?");
        string favoriteHoliday = Console.ReadLine();
        Console.WriteLine("What is your favorite season?");
        string favoriteSeason = Console.ReadLine();
        Console.WriteLine("What is your dream job");
        string dreamJob = Console.ReadLine();
        //Console.WriteLine(int.Parse(age) + 5);
        Console.WriteLine("How many siblings do you have?");
        string siblings = Console.ReadLine();

        Console.WriteLine($"\n\nMy friend's name is {name}. {name} is {age} years old. {name}'s eye color is {eyeColor} and their shoe size is {shoeSize}. {name}'s hair color is {hairColor}. {name}'s favorite color is {favoriteColor}, their favorite TV show is {favoriteTV}, their favorite teacher is {favoriteTeacher}, their favorite class is {favoriteClass}, their favorite holiday is {favoriteHoliday}, and their favorite season is {favoriteSeason}. Their dream job is {dreamJob}. In five years they will they be {int.Parse(age) + 5}. {name} has {siblings} siblings");
    }
}