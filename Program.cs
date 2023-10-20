using System.Reflection.Metadata;
using System.Security.AccessControl;

try
{
   bool test = typeof(Exception) == typeof(ArgumentException);
   
    int.Parse("");

    if(false)
    {

    }
    else if(false)
    {

    }
    int x = 5;
    int y = 3;
    int result = x + y;
    Console.WriteLine(result);

    throw new ArgumentException("First");
}
catch (ArgumentException ex)
{
    throw new FormatException("Second");
}