using Adventure_Quest_RPG_.Classes;
using System.Text.RegularExpressions;

namespace Adventure_Quest_RPG_
{
    public class Program
    {
        public static bool HasOnlyLetters(string input)
        {
            // Use a regular expression to check if the input contains only letters
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
        public static void isValidName(string PlayerName)
        {

            while (true)
            {
                Console.Write("Please enter your name (letters only): ");
                PlayerName = Console.ReadLine();

                // Check if the input contains only letters
                if (HasOnlyLetters(PlayerName))
                {
                    Console.WriteLine($"Hello, {PlayerName}!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a name with only letters.");
                }
            }

        }
        public static string ReadNamePlayer()
        {
            string UserName;
            Console.Write("Please enter your name (letters only): ");
            UserName = Console.ReadLine();
            isValidName(UserName);
            return UserName;
        }


        static void Main(string[] args)
        {



            Player player = new Player("Player", 100, 0, 0);

            clsMonster monster = new clsMonster("Monster", 100, 0, 0);

            BattleSystem battleSystem = new BattleSystem();

            battleSystem.StartBattle(player, monster);
        }

    }
}
