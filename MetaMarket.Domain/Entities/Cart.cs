namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa o carrinho de compras do MetaMarket
/// </summary>
public class Cart
{
    /// <summary>
    /// Lista de compras do carrinho
    /// </summary>
    public ICollection<Product> ShoppingList { get; set; }
}
