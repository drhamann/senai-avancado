// See https://aka.ms/new-console-template for more information

public class AprendendoAsyncrono
{
    public object EmExecucao { get; set; }
    public AprendendoAsyncrono()
    {
        EmExecucao = new object();
    }
    public Task Executar()
    {
        return Task.Run(async () =>
        {
            var resultadoDaSoma = await ImprimaAteDez();
            ImprimaDezAteCem();
        });
    }

    private Task<int> ImprimaAteDez()
    {
        var soma = 0;

            for (int i = 0; i < 10; i++)
            {
              soma += i;
            }
        return Task.FromResult(soma);
    }

    private Task ImprimaDezAteCem()
    {
        return Task.Run(() =>
        {
            for (int i = 10; i < 100; i++)
            {
                Console.WriteLine("Tread B" + i);
                Thread.Sleep(100);
            }
        });
    }
}