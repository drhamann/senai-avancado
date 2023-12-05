
using Aula04;

ExemploTimeSpan exemploTimeSpan = new ExemploTimeSpan();

exemploTimeSpan.ShowTimeSpan();


ExemploFile exemploFile = new ExemploFile();

string caminhoDoArquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\meuarquivo.txt";

exemploFile.CriarArquivo(caminhoDoArquivo);

exemploFile.EscreverEmArquivo("olá arquivo em c#", caminhoDoArquivo);

string conteudoArquivo = exemploFile.LerArquivo(caminhoDoArquivo);

ExemploDirectory exemploDirectory = new ExemploDirectory();
string[] arquivosDaminhaPasta = exemploDirectory.TrazerTodosOsArquivos("C:\\");

Console.ReadKey();
