// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Aula03.Stack<DateTime> stackDate = new Aula03.Stack<DateTime>();

stackDate.Push(DateTime.Now);
stackDate.Push(
    new DateTime(2023, 12, 01, 19, 12, 00));

Aula03.Stack<string> stackString = new Aula03.Stack<string>();

stackString.Push("Ola");
stackString.Push("Generico");

var a = stackDate.data[0];
var b = stackDate.data[1];

Aula03.StackMethod.Swap<DateTime>(ref a, ref b);

var a1 = stackString.data[0];
var b1 = stackString.data[1];

Aula03.StackMethod.Swap<string>(ref a1, ref b1);


List<string> colecaoDePalavras 
    = new List<string>();

colecaoDePalavras.Add("Ola");
colecaoDePalavras.Remove("Ola");

Dictionary<string, string> keyValuePairs 
    = new Dictionary<string, string>();