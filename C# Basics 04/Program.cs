#region 6st answer
/*
6-Build the same sentence as above, but using string interpolation ($"...").*/
#endregion

using System.Text;

class program 
{
    static void Main(string[] args)
    {
        string title = "Clean Code ";
        int pages = 464;
        Console.WriteLine($"Book:{title}\nPages:{pages}");
    }
}
