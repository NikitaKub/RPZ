using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class IntroduceAssertion
    {
        //<----------- Ex 4 ----------->

        //Introduce Assertion

        public void Example()
        {
            var file = "C:/file.txt";
            var crashFile = "C:/crashDump.txt";

            VerifiCationFile(file, crashFile);

            string VerifiCationFile(string file, string crashfile)
            {
                return (file != string.Empty) ? file : crashfile;
            }
        }

        //<----------- Refactored ----------->

        public void RefactoredExample()
        {
            var file = "C:/file.txt";
            var crashFile = "C:/crashDump.txt";

            RefactoredVerifiCationFile(file, crashFile);

            string RefactoredVerifiCationFile(string file, string crashfile)
            {
                if (file != string.Empty && crashFile != string.Empty)
                {
                    throw new Exception("No Files");
                }

                return (file != string.Empty) ? file : crashfile;
            }
        }
    }
}
