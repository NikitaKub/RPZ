using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class ReplaceInheritanceWithDelegation
    {
        public void Example()
        {
            PlaceHolder placeHolder = new PlaceHolder();
            placeHolder.X = 1;
        }

        public void RefactoredExample()
        {
            RefactoredPlaceHolder placeHolder = new RefactoredPlaceHolder();
            placeHolder.PositionXY = new int[] { 2, 4, };
        }
    }

    //<----------- Ex 4 ----------->

    // Replace Inheritance with Delegation

    class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void PositionMark()
        {
            Console.WriteLine("Position " + X + " " + Y);
        }
    }

    class PlaceHolder : Position
    {
        public bool IsHold(bool hold)
        {
            return hold == true;
        }
    }

    //<----------- Refactored ----------->

    class RefactoredPosition
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void PositionMark()
        {
            Console.WriteLine("Position " + X + " " + Y);
        }
    }

    class RefactoredPlaceHolder
    {
        public RefactoredPosition refactoredPosition = new RefactoredPosition();

        public int[] PositionXY
        {
            get { return [refactoredPosition.X, refactoredPosition.Y]; }
            set { refactoredPosition.X = value[0]; refactoredPosition.Y = value[1]; }
        }

        public void PositionMark()
        {
            refactoredPosition.PositionMark();
        }

        public bool IsHold(bool hold)
        {
            return hold == true;
        }
    }
}
