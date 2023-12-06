using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Entidades
{
    public class Pedido : EntidadeBase
    {
        public int ClienteId { get; set; }
        public int PizzaId { get; set; }
    }
}
