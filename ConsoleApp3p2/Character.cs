using System;

namespace GameEncapsulationDemo
{
    public class Character
    {
        // Atribut dengan berbagai access modifier
        public string characterID ="";
        public string characterName ="";
        public string characterClass ="";
        public float health;
        public int level;


        private static int totalCharacterCount = 0;

        public static int GetTotalCharacterCount()
        {
            return totalCharacterCount;
        }

       

        // Method
        public void Start()
        {
            level = 1;
            health = 100;

            Console.WriteLine(
                $"Karakter {characterName} (Level {level}) memulai petualangan!"
            );
        }

        private void LevelUp()
        {
            level++;

            Console.WriteLine(
                $"{characterName} naik level! Level sekarang: {level}"
            );
        }

        public void TakeDamage(float dmg)
        {
            health -= dmg;

            Console.WriteLine(
                $"{characterName} menerima {dmg} damage. Health tersisa: {health}"
            );

            if (health <= 0)
            {
                Console.WriteLine($"{characterName} telah gugur!");
            }
        }

        public void Heal(float healAmt)
        {
            health += healAmt;

            Console.WriteLine(
                $"{characterName} sembuh sebesar {healAmt}. Health sekarang: {health}"
            );
        }

        public void ShowStats()
        {
            Console.WriteLine("=== STATS KARAKTER ===");
            Console.WriteLine($"ID      : {characterID}");
            Console.WriteLine($"Nama    : {characterName}");
            Console.WriteLine($"Class   : {characterClass}");
            Console.WriteLine($"Level   : {level}");
            Console.WriteLine($"Health  : {health}");
            Console.WriteLine("======================");
        }
         public Character()
       {
         characterID = "UNKNOWN";
         characterName = "Hero";
         characterClass = "valkryie";
         health = 100;
         level = 1;
         totalCharacterCount++;
         Console.WriteLine($"Objek Character Dibuat Dengan Konstruktor Default.");
       }

        public Character(string id, string name)
       {
         characterID = id;
         characterName = name;
         characterClass = "orc";
         health = 100;
         level = 1;
         totalCharacterCount++;
         Console.WriteLine($"Objek Character Dibuat Dengan Konstruktor Berparameter (ID & Nama).");
       }

        public Character(string id, string name, string classType)
       {
         characterID = id;
         characterName = name;
         characterClass = classType;
         health = 100;
         level = 1;
         totalCharacterCount++;
         Console.WriteLine($"Objek Character Dibuat Dengan Konstruktor Berparameter (ID & Nama, & Class).");
       }

        
    }
}
