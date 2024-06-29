using Adventure_Quest_RPG_.Classes;

namespace Adventure_Quest_RPG_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Player player = new Player("Player",100,0,-1);

            BattleSystem battleSystem = new BattleSystem();
            
            battleSystem.StartBattle();           
        }

    }
}
