
using Adventure_Quest_RPG_;
using Adventure_Quest_RPG_.Classes;
namespace AdventureQuestRPGTest
{
    public class UnitTest1
    {
     
        [Fact]
        public void PLayerAttack()
        {
            //Act
            
           Player player = new Player("PLayer" , 100 , 0 , 0);
            clsMonster monster = new clsMonster("Monster" , 100 , 0 , 0);
            //Arange
            BattleSystem battleSystem = new BattleSystem();
            int MonsterHealthBefore = monster.MonstorHealth;
            battleSystem.Attack(ref player,ref monster);
            int MonsterHealthAfter = monster.MonstorHealth;
            //Assert

            Assert.True(MonsterHealthBefore > MonsterHealthAfter);

        }
        [Fact]
        public void MonstorAttacker()
        {
            //Act
            Player player = new Player("PLayer", 100, 0, 0);
            clsMonster monster = new clsMonster("Monster", 100, 0, 0);
            //Arange
            BattleSystem battleSystem = new BattleSystem();
            int PlayerHealthBefore = player.PlayerHealth;
            battleSystem.Attack(ref monster, ref player);
            int playerHealthAfter = player.PlayerHealth ;
            //Assert

            Assert.True(PlayerHealthBefore > playerHealthAfter);
        }
        [Fact]
        public void HealthAfterEndBattle()
        {
             //Act
            Player player = new Player("PLayer", 100, 0, 0);
            clsMonster monster = new clsMonster("Monster", 100, 0, 0);
             //Arange
            BattleSystem battleSystem = new BattleSystem();
            battleSystem.StartBattle(player, monster);
            int HealthWenner = 0;
            HealthWenner =  player.PlayerHealth > monster.MonstorHealth ?  player.PlayerHealth :  monster.MonstorHealth;
            int HealthLoser = 0;
            HealthLoser = player.PlayerHealth < monster.MonstorHealth ? player.PlayerHealth : monster.MonstorHealth;
            //Asser
            Assert.True(HealthWenner > 0);
            Assert.True(HealthLoser == 0);
        }
    }
}