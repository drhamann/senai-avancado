// See https://aka.ms/new-console-template for more information

public class AprendendoAsyncrono 
{

    public void Executar()
    {
        Thread threadA = new Thread(ImprimaAteDez);

        Thread threadB = new Thread(ImprimaDezAteCem);

        threadA.Start();
        threadB.Start();

        Console.ReadLine();
    }

    private void ImprimaAteDez(object? obj)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Tread A" i);
        }
    }

    private void ImprimaDezAteCem(object? obj)
    {
        for (int i = 10; i < 100; i++)
        {
            Console.WriteLine("Tread A" i);
        }
    }
}