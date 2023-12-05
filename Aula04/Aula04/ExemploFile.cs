using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class ExemploFile
    {

        public void CriarArquivo(string caminhoDoArquivo)
        {
            if (File.Exists(caminhoDoArquivo) is false)
            {
                File.Create(caminhoDoArquivo).Dispose();
            }
        }

        public void EscreverEmArquivo(string texto, string caminhoDoArquivo)
        {
            File.AppendAllText(caminhoDoArquivo, texto);
        }

        public string LerArquivo(string caminhoDoArquivo)
        {
            string conteudoArquivo = File.ReadAllText(caminhoDoArquivo);
            return conteudoArquivo;
        }
    }
}
