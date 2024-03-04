using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class ReplaceConstructorWithFactoryMethod
    {
        public void Example()
        {
            Sweet sweet = new Sweet(0);
            sweet.Eat();
        }

        public void RefactoredExample()
        {
            RefactoredSweet refactoredSweet = RefactoredSweet.Create(0);
            refactoredSweet.Eat();
        }
    }

    //<----------- Ex 4 ----------->

    // Replace Constructor with Factory Method

    class Sweet
    {
        private int type;

        public const int ICECREAM = 0;
        public const int CANDY = 1;
        public const int CAKE = 2;

        public Sweet(int type)
        {
            this.type = type;
        }

        public void Eat()
        {
            if (type == ICECREAM)
            {
                Console.WriteLine("Eat some icecream");
            }
            else if (type == CAKE)
            {
                Console.WriteLine("Eat some cake");
            }
            else
            {
                Console.WriteLine("Eat some candy");
            }
        }
    }

    //<----------- Refactored ----------->

    class RefactoredSweet
    {
        public const int ICECREAM = 0;
        public const int CANDY = 1;
        public const int CAKE = 2;

        public static RefactoredSweet Create(int type)
        {
            switch (type)
            {
                case ICECREAM:
                    return new Icecream();
                case CANDY:
                    return new Candy();
                case CAKE:
                    return new Cake();
                default:
                    throw new Exception("None of type");
            }
        }

        public virtual void Eat()
        {
            Console.WriteLine("Eat something");
        }
    }

    class Icecream : RefactoredSweet
    {
        public override void Eat()
        {
            Console.WriteLine("Eat some Icecream");
        }
    }

    class Candy : RefactoredSweet
    {
        public override void Eat()
        {
            Console.WriteLine("Eat some Candy");
        }
    }

    class Cake : RefactoredSweet
    {
        public override void Eat()
        {
            Console.WriteLine("Eat some Cake");
        }
    }
}
