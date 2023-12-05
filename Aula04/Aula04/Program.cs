
using Aula04;

//ExemploTimeSpan exemploTimeSpan = new ExemploTimeSpan();

//exemploTimeSpan.ShowTimeSpan();


//ExemploFile exemploFile = new ExemploFile();

//string caminhoDoArquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\meuarquivo.txt";

//exemploFile.CriarArquivo(caminhoDoArquivo);

//exemploFile.EscreverEmArquivo("olá arquivo em c#", caminhoDoArquivo);

//string conteudoArquivo = exemploFile.LerArquivo(caminhoDoArquivo);

//ExemploDirectory exemploDirectory = new ExemploDirectory();
//string[] arquivosDaminhaPasta = exemploDirectory.TrazerTodosOsArquivos("C:\\");

//Console.ReadKey();

Exercicio01 exercicio01 = new Exercicio01();

Console.WriteLine("Qual seu nome ?");
string nome = Console.ReadLine();

Console.WriteLine("Como vc esta?");
string comoVcEsta = Console.ReadLine();

exercicio01.EscrevaOSentimento(nome, comoVcEsta);


Exercicio02 exercicio02 = new Exercicio02();

var opcao = string.Empty;

do
{
    Console.WriteLine(
    @" Escolha uma das opções ?
1-Mostrar os nomes
2-Busque as respostas por data
3-Busque as respostas por nome
4-Gera uma versão do arquivo em json
5-Sair
");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.WriteLine(exercicio02.MostreOsNomes());
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        default:
            break;
    }

} while (opcao != "5");