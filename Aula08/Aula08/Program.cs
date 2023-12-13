
using Aula08;

AprendendoDelegate aprendendoDelegate = new AprendendoDelegate();
AprendendoLambda aprendendoLambda = new AprendendoLambda();
AprendendoAsyncrono aprendendoAsyncrono = new AprendendoAsyncrono();
CalculoInss calculoInss = new CalculoInss();


//aprendendoDelegate.Executar();
//aprendendoLambda.Executar();
//await aprendendoAsyncrono.Executar();
//calculoInss.Executar();

FizzBuzzAssincrono fizzBuzzAssincrono = new FizzBuzzAssincrono();
await fizzBuzzAssincrono.Executar();

Console.ReadKey();