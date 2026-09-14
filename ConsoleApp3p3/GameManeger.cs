using System;

namespace GameEncapsulationDemo
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("=== Demo keren ===\n");

            Console.WriteLine($"Total Karakter Saat Ini: {Character.GetTotalCharacterCount()}");

            Character hero1 = new Character();
            hero1.ShowStats();

             Character hero2 = new Character("C-002", "laila");
            hero2.ShowStats();

             Character hero3 = new Character("C-003", "Burger", "goblin");
            hero3.ShowStats();

             Console.WriteLine($"Total Karakter yang Telah Dibuat: {Character.GetTotalCharacterCount()}");


            Console.ReadKey();
        

        }
    }
}