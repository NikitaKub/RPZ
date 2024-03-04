using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class RemoveControlFlag
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

    //<----------- Ex 1 ----------->

    //Remove Control Flag

    class Collider
    {
        private bool isOverZone = false;

        private List<string> objects = new List<string>() { "cube", "zone", "circle" };

        public void CheckCollide()
        {
            foreach (var obj in objects)
            {
                if (!isOverZone)
                {
                    if (obj == "zone")
                    {
                        isOverZone = true;
                        Console.WriteLine("Collided with " + obj);
                    }
                }
            }
        }
    }

    //<----------- Refactored ----------->

    class RefactoredCollider
    {
        private List<string> objects = new List<string>() { "cube", "zone", "circle" };

        public void CheckCollide()
        {
            foreach (var obj in objects)
            {
                if (obj == "zone")
                {
                    Console.WriteLine("Collided with " + obj);
                    break;
                }
            }
        }
    }
}
