// See https://aka.ms/new-console-template for more information
public class AprendendoDelegate 
{
    public delegate string Reverse(string s);

    static string ReverseString(string s)
    {
        return new string(s.Reverse().ToArray());
    }

    public void Executar()
    {
        Reverse rev = ReverseString;
        Console.WriteLine(rev("a string"));
    }
}
