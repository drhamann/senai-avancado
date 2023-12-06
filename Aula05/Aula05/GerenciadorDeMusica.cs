using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{

    //    ** Exercício: Sistema de Gerenciamento de Música**
    //Você está desenvolvendo um sistema de gerenciamento de música e precisa implementar a
    //funcionalidade de salvar e carregar dados de músicas usando JSON.
    //Para isso, você deve utilizar a biblioteca `System.Text.Json` do C#.
    //1. **Crie uma classe `Music`**:
    //   - A classe deve ter propriedades como `Title`, `Artist`, `Album`, `Genre`, `Year`, etc.
    //   - Inclua anotações de atributo para personalizar a serialização/desserialização.
    //2. **Crie uma classe `MusicLibrary`**:
    //   - A classe deve conter uma lista de músicas (`List<Music>`).
    //   - Implemente métodos para adicionar e listar músicas na biblioteca.
    //3. ** Serialização**:
    //   - Crie um método que recebe uma lista de músicas e serializa para JSON.
    //   - Salve o JSON resultante em um arquivo chamado "musicLibrary.json".
    //4. ** Desserialização**:
    //   - Crie um método que lê um arquivo JSON("musicLibrary.json") e desserializa as músicas de volta para uma lista.
    //5. ** Teste**:
    //   - Crie algumas instâncias de músicas e adicione-as à sua biblioteca.
    //   - Serialize a biblioteca para JSON e salve no arquivo.
    //   - Limpe a biblioteca e depois desserialize as músicas do arquivo.
    //   - Liste as músicas para verificar se a desserialização foi bem-sucedida.

    //** Dicas:**
    //- Use a biblioteca `System.Text.Json.JsonSerializer`.
    //- Utilize o `File.WriteAllText` e `File.ReadAllText` para salvar e ler arquivos.
    //** Desafio Adicional:**
    //- Implemente um menu simples no console para permitir que o usuário adicione, liste e salve músicas através do programa.

    public class Musica
    {

    }
    public class GerenciadorDeMusica
    {

    }
}
