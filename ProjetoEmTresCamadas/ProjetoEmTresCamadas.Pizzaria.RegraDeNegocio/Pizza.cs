using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio
{
    public enum TamanhoDePizza
    {
        Pequena = 0,
        Media = 1,
        Grande = 2
    }

    public class Pizza
    {
        public string Sabor { get; set; }
        public TamanhoDePizza TamanhoDePizza { get; set; }
        public string Descricao { get; set; }
        public Pizza() { }

        public string DefinirSabor(string sabor)
        {
            if (sabor == "C")
            {
                Sabor = "Calabresa";
            }
            else if (sabor == "F")
            {
                Sabor = "Frango";
            }
            return Sabor;
        }

        public string DefinirTamanho(string tamanho)
        {
            switch (tamanho)
            {
                case "P":
                    {
                        TamanhoDePizza = TamanhoDePizza.Pequena;
                        break;
                    }
                case "M":
                    {
                        TamanhoDePizza = TamanhoDePizza.Media;
                        break;
                    }
                case "G":
                    {
                        TamanhoDePizza = TamanhoDePizza.Grande;
                        break;
                    }
                default:
                    {
                        throw new Exception("Tamanho não defenido");
                    }
            }

            return Enum.GetName(TamanhoDePizza);
        }

        public override string ToString()
        {
            return $"Sua Pizza é de sabor {Sabor} e tamanho {TamanhoDePizza}";
        }
    }
}
