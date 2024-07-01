using Adventure_Quest_RPG_.Classes;
using System.Text.RegularExpressions;

namespace Adventure_Quest_RPG_
{
    public class Program
    {
        
        static void Main(string[] args)
        {



            Player player = new Player("Player", 100, 0, 0);

            clsMonster monster = new clsMonster("Monster", 100, 0, 0);

            BattleSystem battleSystem = new BattleSystem();

            battleSystem.StartBattle(player, monster);


        }

    }
}
