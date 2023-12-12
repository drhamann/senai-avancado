// See https://aka.ms/new-console-template for more information
using Aula07;
using System;

Console.WriteLine("Aprendendo sobre exceções");

Exercicio01 exercicio01 = new Exercicio01();
Exercicio02 exercicio02 = new Exercicio02();

try
{
    exercicio01.Executar();
    exercicio02.Executar();

} // Onde executa o código
catch (ExceptionA ex) 
{
    //Onde trata erro do tipo específico que tentou no try
    Console.WriteLine(ex.ToString());
}

catch (ExceptionC ex) 
{
    try
    {
        // Trata qualquer tipo de exceção e lança ela novamente para o código superior
        Console.WriteLine(ex.StackTrace);
        throw ex;
    }
    catch (ExceptionC exc2)
    {
        Console.WriteLine(ex.InnerException);
    }
} 
catch(ExcecaoPersonalizadaException exP)
{
    Console.WriteLine(exP.Message);
}
catch (Exception ex) 
{
    // Trata qualquer tipo de exceção
    Console.WriteLine(ex.Source);
}
finally 
{
    // Sempre executa mesmo com erro
    Console.WriteLine("Sempre vou executar");
}


