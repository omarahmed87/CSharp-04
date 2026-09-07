#region 7st answer
//7 - Build the same sentence again, but using string.Format().
#endregion
class program 
{
    static void Main(string[] args)
    {
        string title = "Clean Code ";
        int pages = 464;
        Console.WriteLine(string.Format("Book: {0}\npages {1}", title, pages));
    }
}
