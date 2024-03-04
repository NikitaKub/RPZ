using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class SeparateQueryFromModifier
    {
        public void Example()
        {
            Movement movement = new Movement();
            movement.SetPositionAndChangePosture(1, 2);
        }

        public void RefactoredExample()
        {
            RefactoredMovement movement = new RefactoredMovement();
            movement.Move(0, 2);
        }
    }

    //<----------- Ex 1 ----------->

    // Separate Query from Modifier

    class Movement
    {
        private const int STAND = 0;
        private const int LEAN = 1;

        private int x;
        private int y;

        private int posture;

        public void SetPositionAndChangePosture(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.posture = STAND;
        }
    }

    //<----------- Refactored ----------->

    class RefactoredMovement
    {
        private const int STAND = 0;
        private const int LEAN = 1;

        private int x;
        private int y;

        private int posture;

        public void Move(int x, int y)
        {
            SetPosition(x, y);
            ChangePosture(STAND);
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ChangePosture(int posture)
        {
            this.posture = posture;
        }
    }
}
