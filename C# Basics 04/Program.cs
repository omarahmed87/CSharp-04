#region 3st answer
/*
3-Create a StringBuilder, Append() the text "Book List", then Append() 
" - Updated" onto the same object. Print the final result. 
  */
#endregion

using System.Text;

class program 
{
    static void Main(string[] args)
    {
        StringBuilder update =new StringBuilder("Book List");
        update.Append(" _ Updated");
        Console.WriteLine(update);
    }
}
