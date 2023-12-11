using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    public class Exercicio02
    {
        public void Executar()
        {
            Console.WriteLine("Bem-vindo ao programa de manipulação de arquivos!");
            try
            {
                // Solicita ao usuário o caminho do arquivo a ser lido
                Console.Write("Digite o caminho do arquivo: ");
                string caminhoArquivo = Console.ReadLine();
                // Tenta ler o conteúdo do arquivo
                string conteudo = LerArquivo(caminhoArquivo);
                // Exibe o conteúdo do arquivo
                Console.WriteLine($"Conteúdo do arquivo:\n{conteudo}");
            }
            catch (ArquivoNaoEncontradoException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
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
        static string LerArquivo(string caminho)
        {
            // Resolver

            return string.Empty;
        }


    }

    public class ArquivoNaoEncontradoException : Exception
    {
        public ArquivoNaoEncontradoException(string mensagem) : base(mensagem)
        {
        }
    }

}
