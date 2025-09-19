using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämnings_uppgift;

public class Enemy
{
    public string Name = string.Empty;
    public int MaxHp = 0;
    public int Hp = 0;
    public int EnemyDamage = 0;
    public int EvilGold = 0;
    

    public Enemy(string enemyName)
    {
        Name = enemyName;

        if (enemyName == "Akaza")
        {
            
            MaxHp = 100;
            Hp = MaxHp;
            EnemyDamage = 20;
            EvilGold = 5;
        }
        else if (enemyName == "Douma")
        {
            MaxHp = 110;
            Hp = MaxHp;
            EnemyDamage = 25;
            EvilGold = 10;
        }
        else if (enemyName == "Kokushibo")
        {
            MaxHp = 120;
            Hp = MaxHp;
            EnemyDamage = 30;
            EvilGold = 20;
        }
    }

   

    public static string[] enemyNames = { "Akaza", "Douma" };

    public static Enemy getRandomEnemy()
    {
        Random random = new Random();
        int enemyIndex = random.Next(enemyNames.Length);
        string randomEnemyName = enemyNames[enemyIndex];

        Enemy enemy = new Enemy(randomEnemyName);
        return enemy;
    }


    //public Enemy(string name, int hp, int damage, int goldDrop)
    //{
    //    Name = name;
    //    MaxHp = hp;
    //    Hp = MaxHp;
    //    EnemyDamage = damage;
    //    EvilGold = goldDrop;

    //}


    //public Enemy getBoss()
    //{
    //    Enemy enemy = new Enemy("Koukushibo", 110, 30, 20);
    //    return enemy;
    //}

}

