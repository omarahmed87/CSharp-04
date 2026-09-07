#region 2st answer
/*
2-Declare two separate string variables, both set to the literal "Clean Code".
Use ReferenceEquals() to check if they point to the same object in memory.
  */
#endregion

class program 
{
    static void Main(string[] args)
    {

        string name1 = "Clean Code";
        string name2 = "Clean Code";

        Console.WriteLine(object.ReferenceEquals(name1, name2)); //true
    }
}
