namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa os produtos do MetaMarket
/// </summary>
public class Product
{
    /// <summary>
    /// Codigo que representa o produto
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nome do produto
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Estoque armazenado do produto
    /// </summary>
    public int Stock { get; set; }

    /// <summary>
    /// Quantidade/Peso de um produto
    /// </summary>
    public float AmountWeight { get; set; }

    // <summary>
    /// Preço de um produto
    /// </summary>
    public float Price { get; set; }

    /// <summary>
    /// Foreign Key de uma categoria de produto
    /// </summary>
    public int ProductCategoryId { get; set; }

    /// <summary>
    /// Representa a categoria de um produto
    /// </summary>
    public ProductCategory ProductCategory { get; set; }
}
