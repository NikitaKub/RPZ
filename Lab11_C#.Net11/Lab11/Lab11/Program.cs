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
    
    public int[] PositionXY {
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