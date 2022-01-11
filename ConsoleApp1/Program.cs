using System;
using System.IO;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootPath = @"C:\Users\opilane\samples\";
            string[] heroes = GetDataFromFile(rootPath + "heroes.txt");
            string[] villains = GetDataFromFile(rootPath + "villains.txt");


            string randomHero = GetRandomCharacter(heroes);
            string randomVillains = GetRandomCharacter(villains);
            Console.WriteLine($"Your random hero is {randomHero}");
            Console.WriteLine($"Your random villain is {randomVillains}");

            string randomWeapon = GetWeapon();
            string randomWeapons = GetWeapon();
            Console.WriteLine($"Your weapon Hero {randomWeapon}");
            Console.WriteLine($"Your weapon Villain {randomWeapons}");
        }

        public static string GetRandomCharacter(string[] someArray)
        {

            return someArray[GetRandomIndexForArray(someArray)];
        }

        public static string GetWeapon()
        {
            string[] weapon = { "AWP", "Desert Eagle", "AK-47", "Knife", "Pen" };
            return weapon[GetRandomIndexForArray(weapon)];
        }
        public static int GetRandomIndexForArray(string[] someArray)
        {
            Random rnd = new Random();
            return rnd.Next(0, someArray.Length);
        }

        public static string[] GetDataFromFile(string filePath)
        {
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }

    
    }
}
