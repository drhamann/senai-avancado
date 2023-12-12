// See https://aka.ms/new-console-template for more information
public class AprendendoLambda 
{
    public delegate string Reverse(string s);

    public void Executar()
    {
        Reverse rev = s => new string(s.Reverse().ToArray());
        Console.WriteLine(rev("a string"));
    }
}