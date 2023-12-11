using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Console.WriteLine("Bem-vindo ao programa de divisão!");
            try
            {
                // Solicita ao usuário dois números
                Console.Write("Digite o numerador: ");
                int numerador = int.Parse(Console.ReadLine());
                Console.Write("Digite o denominador: ");
                int denominador = int.Parse(Console.ReadLine());
                // Realiza a divisão e exibe o resultado
                double resultado = RealizarDivisao(numerador, denominador);
                Console.WriteLine($"Resultado da divisão: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Certifique-se de digitar números válidos.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("O programa foi encerrado.");
            }
        }
        static double RealizarDivisao(int numerador, int denominador)
        {
            return (double)numerador / denominador;
        }
    }

    public class DivideByZeroException : Exception
    {
        public DivideByZeroException(string mensagem) : base(mensagem)
        {
        }
    }



}
