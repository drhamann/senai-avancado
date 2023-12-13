using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    internal class FizzBuzzAssincrono
    {
        static object lockObject = new object();
        static int currentNumber = 1;
        static int maxNumber = 100;
        public Task Executar()
        {
            Thread fizzThread = new Thread(Fizz);
            Thread buzzThread = new Thread(Buzz);
            Thread fizzBuzzThread = new Thread(FizzBuzz);

            fizzThread.Start();
            buzzThread.Start();
            fizzBuzzThread.Start();

            fizzThread.Join();
            buzzThread.Join();
            fizzBuzzThread.Join();

            return Task.CompletedTask;
        }
        static void Fizz()
        {
            while (true)
            {
                lock (lockObject)
                {
                    if (currentNumber > maxNumber)
                        break;
                    if (currentNumber % 3 == 0 
                        && currentNumber % 5 != 0)
                    {
                        Console.WriteLine(currentNumber + " Fizz");
                        currentNumber++;
                    }
                }
                
                Thread.Sleep(10);
            }
        }
        static void Buzz()
        {
            while (true)
            {
                lock (lockObject)
                {
                    if (currentNumber > maxNumber)
                        break;
                    if (currentNumber % 3 != 0
                        && currentNumber % 5 == 0)
                    {
                        Console.WriteLine(currentNumber + " Buzz");
                        currentNumber++;
                    }
                }
                Thread.Sleep(10);
            }
        }

        static void FizzBuzz()
        {
            while (true)
            {
                lock (lockObject)
                {
                    if (currentNumber > maxNumber)
                        break;
                    if (currentNumber % 3 == 0
                        && currentNumber % 5 == 0)
                    {
                        Console.WriteLine(currentNumber + " FizzBuzz");
                        currentNumber++;
                        continue;
                    }
                    Console.WriteLine(currentNumber);
                    currentNumber++;
                }

                Thread.Sleep(10);
            }
        }
    }


}

