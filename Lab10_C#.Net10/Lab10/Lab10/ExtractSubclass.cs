using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class ExtractSubclass
    {
        public void Example()
        {
            Crafter crafter = new Crafter();
            crafter.CraftAxe();
            crafter.CraftCup();
        }

        public void RefactoredExample()
        {
            RefactoredCrafter refactoredCrafter = new RefactoredCrafter();
            refactoredCrafter.CraftAxe();
            refactoredCrafter.CraftCup();

            SubCrafterWood subCrafterWood = new SubCrafterWood();
            subCrafterWood.CraftAxe();
            subCrafterWood.CraftCup();
        }
    }

    //<----------- Ex 4 ----------->

    // Push Down Method

    class Crafter
    {
        public void CraftAxe()
        {
            Console.WriteLine("Craft Axe");
        }

        public void CraftCup()
        {
            Console.WriteLine("Craft Cup");
        }
    }

    //<----------- Refactored ----------->

    class RefactoredCrafter
    {
        public void CraftAxe()
        {
            Console.WriteLine("Craft Axe");
        }

        public virtual void CraftCup()
        {
            Console.WriteLine("Craft Cup");
        }
    }

    class SubCrafterWood : RefactoredCrafter
    {
        public override void CraftCup()
        {
            Console.WriteLine("Craft wooden Cup");
        }
    }
}
