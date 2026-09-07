#region 1st answer
/*
1-Declare string title = "clean code";. Call title.ToUpper()and store it in a new variable
upperTitle. Print both title and upperTitle to show that title did not change.
  */
#endregion

class program 
{
    static void Main(string[] args)
    {
        string title = "clean code";
        string upperTitle = title.ToUpper();
        Console.WriteLine($"Original title: {title}");
        Console.WriteLine($"Uppercase title: {upperTitle}");
    }
}
