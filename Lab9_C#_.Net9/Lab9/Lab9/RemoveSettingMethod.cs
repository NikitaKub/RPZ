using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class RemoveSettingMethod
    {
        public void Example()
        {
            FakeSingleton fakeSingleton = FakeSingleton.GetInstance();
        }

        public void RefactoredExample()
        {
            RefactoredFakeSingleton refactoredFakeSingleton = RefactoredFakeSingleton.GetInstance();
        }
    }

    //<----------- Ex 3 ----------->

    // Remove Setting Method

    class FakeSingleton
    {
        private static FakeSingleton _instance;

        private FakeSingleton() { }

        public static FakeSingleton GetInstance()
        {
            if (_instance == null)
            {
                SetInstance(new FakeSingleton());
            }
            return _instance;
        }

        private static void SetInstance(FakeSingleton instance)
        {
            _instance = instance;
        }
    }

    //<----------- Refactored ----------->

    class RefactoredFakeSingleton
    {
        private static RefactoredFakeSingleton _refactoredInstance;

        private RefactoredFakeSingleton() { }

        public static RefactoredFakeSingleton GetInstance()
        {
            if (_refactoredInstance == null)
            {
                _refactoredInstance = new RefactoredFakeSingleton();
            }

            return _refactoredInstance;
        }
    }
}
