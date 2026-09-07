#region 4st answer
/*
4-Using the StringBuilder from the question above, use Replace() to change "Book List" 
into "Library". Print the result.*/
#endregion

using System.Text;

class program 
{
    static void Main(string[] args)
    {
        StringBuilder update =new StringBuilder("Book List");
        update.Append(" _ Updated");
        update.Replace("Book List", "Libraray");
        Console.WriteLine(update);
    }
}
