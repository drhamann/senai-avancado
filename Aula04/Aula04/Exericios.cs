using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aula04;

public class Exericios
{

}

/// <summary>
/// Escreva um programa, para saber como as pessoas estão, com as seguintes regras:
/// 1 Pergunte o nome de quem está digitando
/// 2 Pergunte como ela está
/// 3 Grave as respostas em arquivo dividindo em datas
/// 4 O nome do arquivo deve ser no formato  “”
/// </summary>
public class Exercicio01
{
    public string ArquivoSentimento { get; set; }
    public Exercicio01()
    {
        string formatoDataArquivo = DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss");
        ArquivoSentimento = $"como_esta_vc_{formatoDataArquivo}.txt";

    }
    public void EscrevaOSentimento(string nome, string comoVcEsta)
    {
        if (File.Exists(ArquivoSentimento) is false)
        {
            using (File.Create(ArquivoSentimento)) { };
        }
        Sentimento sentimento = new Sentimento()
        {
            Nome = nome,
            ComoVcEsta = comoVcEsta
        };

        File.AppendAllText(ArquivoSentimento, sentimento.ToString());
    }
}

/// <summary>
/// Escreva outro programa que leia o arquivo feito no primeiro programa e tenha a seguintes regras:
// 1 Mostrar os nomes
// 2 Busque as respostas por data
// 3 Busque as respostas por nome
// 4 Gera uma versão do arquivo em json
/// </summary>
public class Exercicio02 : IExercicio02
{
    public List<Sentimento> sentimentos { get; set; }

    public Exercicio02()
    {
        sentimentos = new List<Sentimento> { };
        var valorBase = "como_esta_vc_";

        var arquivos = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, $"{valorBase}*");
        foreach (var arquivo in arquivos)
        {
            var date = arquivo.Split(valorBase);
            var conteudoArquivo = File.ReadAllText(arquivo);
            Sentimento sentimento = new Sentimento();
            sentimento.ConverterString(conteudoArquivo);
            sentimentos.Add(sentimento);
        }
    }

    public string MostreOsNomes()
    {
        string Nomes = string.Empty;

        foreach (var sentimento in sentimentos)
        {
            Nomes += $"\r\n {sentimento.Nome}";
        }
        return Nomes;
    }

    public string RespostaPorData(string dataInicial, string dataFinal)
    {
        string sentimentos = string.Empty;

        foreach (var sentimento in this.sentimentos)
        {
            //Todo validar se está na data
            sentimentos += $"\r\n {sentimento}";
        }
        return sentimentos;
    }

    public string RespostaPorNome(string nome)
    {
        string sentimentos = string.Empty;

        foreach (var sentimento in this.sentimentos)
        {
            if (sentimento.Nome == nome)
                sentimentos += $"\r\n {sentimento}";
        }
        return sentimentos;
    }

    public string ConverterSentimentosEmJson()
    {
        throw new NotImplementedException();
    }
}

public class Sentimento
{
    public string Nome { get; set; }
    public string HoraDoRegistro { get; set; }
    public string ComoVcEsta { get; set; }

    const string delimitador = ";";

    public Sentimento()
    {
        Nome = string.Empty;
        HoraDoRegistro = DateTime.Now.ToString("hh_mm_ss");
        ComoVcEsta = string.Empty;
    }

    public override string ToString()
    {

        return $"{Nome}{delimitador}{ComoVcEsta}{delimitador}{HoraDoRegistro}\r\n";
    }

    public Sentimento ConverterString(string texto)
    {
        string[] sentimentoEmPartes = texto.Split(delimitador);

        Nome = sentimentoEmPartes[0];
        ComoVcEsta = sentimentoEmPartes[1];
        HoraDoRegistro = sentimentoEmPartes[2];

        return this;
    }
}