
namespace Aula04
{
    public interface IExercicio02
    {
        List<Sentimento> sentimentos { get; set; }

        string MostreOsNomes();
        string RespostaPorData(string dataInicial, string dataFinal);
        string RespostaPorNome(string nome);

        string ConverterSentimentosEmJson();
    }
}