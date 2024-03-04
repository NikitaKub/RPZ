using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class PushDownField
    {
        public void Example()
        {
            TextField textField = new TextField("C:/file.txt", 5);
            ImageField imageField = new ImageField("C:/file.txt");
        }

        public void RefactoredExample()
        {
            RefactoredTextField refactoredTextField = new RefactoredTextField("C:/file.txt", 5);
            RefactoredImageField refactoredImageField = new RefactoredImageField("C:/file.txt");
        }
    }

    //<----------- Ex 2 ----------->

    // Push Down Field

    class Field
    {
        public int textMaxSize;
        public string dataPath;

        public Field(string dataPath, int textMaxSize = 0)
        {
            this.textMaxSize = textMaxSize;
            this.dataPath = dataPath;
        }
    }

    class TextField : Field
    {
        public TextField(string dataPath, int textMaxSize) : base(dataPath, textMaxSize)
        {
            Console.WriteLine("Path: " + this.dataPath + " Max Text Size: " + this.textMaxSize);
        }
    }

    class ImageField : Field
    {
        public ImageField(string dataPath) : base(dataPath)
        {
            Console.WriteLine("Path: " + this.dataPath + " Max Text Size: " + this.textMaxSize);
        }
    }

    //<----------- Refactored ----------->

    class RefactoredField
    {
        public string dataPath;

        public RefactoredField(string dataPath)
        {
            this.dataPath = dataPath;
        }
    }

    class RefactoredTextField : RefactoredField
    {
        private int textMaxSize;

        public RefactoredTextField(string dataPath, int textMaxSize) : base(dataPath)
        {
            this.textMaxSize = textMaxSize;
            Console.WriteLine("Path: " + this.dataPath + " Max Text Size: " + this.textMaxSize);
        }
    }

    class RefactoredImageField : RefactoredField
    {
        public RefactoredImageField(string dataPath) : base(dataPath)
        {
            Console.WriteLine("Path: " + this.dataPath);
        }
    }
}
