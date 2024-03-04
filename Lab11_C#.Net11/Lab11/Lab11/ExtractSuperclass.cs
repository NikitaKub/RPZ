using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class ExtractSuperclass
    {
        public void Example()
        {
            Enemy enemy = new Enemy();
            enemy.Harm();
            Friend friend = new Friend();
            friend.Heal();
        }

        public void RefactoredExample()
        {
            Entity entity = new Entity();
            entity.ID = 1;
            RefactoredEnemy refactoredEnemy = new RefactoredEnemy();
            refactoredEnemy.Harm();
            RefactoredFriend refactoredFriend = new RefactoredFriend();
            refactoredFriend.Heal();
        }
    }

    //<----------- Ex 3 ----------->

    // Extract Superclass

    class Enemy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }

        public void Harm()
        {
            Console.WriteLine("Harm!");
        }
    }

    class Friend
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Shields { get; set; }

        public void Heal()
        {
            Console.WriteLine("Heal!");
        }
    }

    //<----------- Refactored ----------->

    class Entity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class RefactoredEnemy : Entity
    {
        public int HP { get; set; }
        
        public void Harm()
        {
            Console.WriteLine("Harm!");
        }
    }

    class RefactoredFriend : Entity
    {
        public int Shields { get; set; }
        
        public void Heal()
        {
            Console.WriteLine("Heal!");
        }
    }
}
