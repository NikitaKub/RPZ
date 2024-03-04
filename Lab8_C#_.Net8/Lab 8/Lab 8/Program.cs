//<----------- Ex 4 ----------->

//Introduce Assertion

var file = "C:/file.txt";
var crashFile = "C:/crashDump.txt";

VerifiCationFile(file, crashFile);

string VerifiCationFile(string file, string crashfile)
{
    return (file != string.Empty) ? file : crashFile; 
}

//<----------- Refactored ----------->

RefactoredVerifiCationFile(file, crashFile);

string RefactoredVerifiCationFile(string file, string crashfile)
{
    if (file != string.Empty && crashFile != string.Empty)
    {
        throw new Exception("No Files");
    }

    return (file != string.Empty) ? file : crashfile;
}