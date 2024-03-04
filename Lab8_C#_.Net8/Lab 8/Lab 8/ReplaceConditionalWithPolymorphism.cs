using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class ReplaceConditionalWithPolymorphism
    {
        public void Example()
        {
            Management management = new Management(100);
            management.SetCostForSell(Management.NODISCOUNTS);
        }

        public void RefactoredExample()
        {
            RefactoredManagement management = new NoDiscounts(100);
            management.SetCostForSell();
        }
    }

    //<----------- Ex 2 ----------->

    //Replace Conditional with Polymorphism

    class Management
    {
        private float baseCost;
        public const int NODISCOUNTS = 1;
        public const int CHRISTMAS = 50;
        public const int BLACKFRIDAY = 0;

        public Management(float baseCost)
        {
            this.baseCost = baseCost;
        }

        public float SetCostForSell(int discount)
        {
            switch (discount)
            {
                case NODISCOUNTS:
                    return baseCost * NODISCOUNTS;
                case CHRISTMAS:
                    return (baseCost / 100) * CHRISTMAS;
                case BLACKFRIDAY:
                    return (baseCost / 100) * BLACKFRIDAY;
                default:
                    throw new Exception("No Type");
            }
        }
    }

    //<----------- Refactored ----------->

    abstract class RefactoredManagement
    {
        protected float baseCost;
        public const int NODISCOUNTS = 1;
        public const int CHRISTMAS = 50;
        public const int BLACKFRIDAY = 0;

        public abstract float SetCostForSell();
    }

    class NoDiscounts : RefactoredManagement
    {
        public NoDiscounts(float baseCost)
        {
            this.baseCost = baseCost;
        }

        public override float SetCostForSell()
        {
            return baseCost * NODISCOUNTS;
        }
    }

    class Christmas : RefactoredManagement
    {
        public Christmas(float baseCost)
        {
            this.baseCost = baseCost;
        }

        public override float SetCostForSell()
        {
            return (baseCost / 100) * CHRISTMAS;
        }
    }

    class BlackFriday : RefactoredManagement
    {
        public BlackFriday(float baseCost)
        {
            this.baseCost = baseCost;
        }

        public override float SetCostForSell()
        {
            return (baseCost / 100) * BLACKFRIDAY;
        }
    }
}
