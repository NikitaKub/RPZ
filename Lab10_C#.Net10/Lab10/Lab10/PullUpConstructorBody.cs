using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class PullUpConstructorBody
    {
        public void Example()
        {
            Cube cube = new Cube(0, "Red", 4, 4);
        }

        public void RefactoredExample()
        {
            RefactoredCube cube = new RefactoredCube(0, "Red", 4, 4);
        }
    }

    //<----------- Ex 1 ----------->

    // Pull Up Constructor Body

    class Figure
    {
        public int ID { get; set; }
        public string Color { get; set; }
    }

    class Cube : Figure
    {
        public int a;
        public int b;

        public Cube(int id, string color, int a, int b)
        {
            ID = id;
            Color = color;
            this.a = a;
            this.b = b;
        }
    }

    //<----------- Refactored ----------->

    class RefactoredFigure
    {
        public int ID { get; set; }
        public string Color { get; set; }

        protected RefactoredFigure(int id, string color)
        {
            ID = id;
            Color = color;
        }
    }

    class RefactoredCube : RefactoredFigure
    {
        public int a;
        public int b;

        public RefactoredCube(int id, string color, int a, int b) : base(id, color)
        {
            this.a = a;
            this.b = b;
        }
    }
}
