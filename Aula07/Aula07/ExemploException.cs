using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    public class ExemploException
    {
    }

    public class ExceptionA : Exception
    {
        
    }

    public class ExceptionC : Exception
    {

    }

    public class ExcecaoPersonalizadaException : Exception
    {
        public ExcecaoPersonalizadaException(string mensagem) : base(mensagem)
        {
        }
    }

}
