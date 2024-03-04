using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class CollapseHierarchy
    {
        public void Example()
        {
            Engine engine = new Engine();
            VSixEnginePower engine1 = new VSixEnginePower();
            engine.CalculateMaxSpeed();
        }

        public void RefactoredExample()
        {
            RefactoredEngine engine = new RefactoredEngine();
            engine.CalculateMaxSpeed();
        }
    }

    //<----------- Ex 2 ----------->

    // Collapse Hierarchy

    class Engine
    {
        private int power;

        public int CalculateMaxSpeed()
        {
            return power / 100;
        }
    }

    class VSixEnginePower
    {
        private int power;
    }

    //<----------- Refactored ----------->

    class RefactoredEngine
    {
        private int power;

        public int CalculateMaxSpeed()
        {
            return power / 100;
        }
    }
}
