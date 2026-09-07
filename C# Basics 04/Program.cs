#region 5st answer
/*
5-Given string title = "Clean Code"; and int pages = 464;, build the sentence 
"Book: Clean Code, Pages: 464" using the + operator. .*/
#endregion

using System.Text;

class program 
{
    static void Main(string[] args)
    {
        string title = "Clean Code ";
        int pages = 464;
        Console.WriteLine(title + pages);
    }
}
