namespace ProjetoEmTresCamadas.Pizzaria.DAO.ValueObjects;

public class PizzaVo : EntidadeBaseVo
{
    public string Sabor { get; set; }
    public int TamanhoDePizza { get; set; }
    public string Descricao { get; set; }
    public double Valor { get; set; }
}
