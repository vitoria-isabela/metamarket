namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa a categoria de um produto do MetaMarket
/// </summary>
public class ProductCategory
{
    /// <summary>
    /// Codigo que representa uma categoria de produto
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nome da categoria em que um produto se enquadra
    /// </summary>
    public string Name { get; set; }

    // <summary>
    /// Preço de um produto
    /// </summary>
    public float Price { get; set; }

    /// <summary>
    /// Uma lista de produtos
    /// </summary>
    public ICollection<Product>? Products { get; set; }

    /// <summary>
    /// Construtor da categoria que recebe o nome de uma categoria
    /// </summary>
    /// <param name="name"></param>
    public ProductCategory(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Construtor da categoria que recebe o id e nome de uma categoria
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    public ProductCategory(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
