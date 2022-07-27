namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa uma Compra/Venda no MetaMarket
/// </summary>
public class SalePurchase
{
    /// <summary>
    /// Valor da Compra/Venda
    /// </summary>
    public float Amount { get; set; }

    /// <summary>
    /// Data e hora da compra/venda
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Endereço do supermercado MetaMarket
    /// </summary>
    public float Address { get; set; }

    /// <summary>
    /// CNPJ do supermercado MetaMarket
    /// </summary>
    public string Cnpj { get; set; }
}
