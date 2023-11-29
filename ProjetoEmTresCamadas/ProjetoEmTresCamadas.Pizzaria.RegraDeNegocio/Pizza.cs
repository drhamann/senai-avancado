namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio;


public class Pizza
{
    public int Id { get; set; }
    public string Sabor { get; set; }
    public TamanhoDePizza TamanhoDePizza { get; set; }
    public string Descricao { get; set; }
    public Pizza() 
    { 
        Descricao = string.Empty;    
    }

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
