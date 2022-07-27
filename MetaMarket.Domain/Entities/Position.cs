namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa o cargo de um funcionario do MetaMarket
/// </summary>
public class Position
{
    /// <summary>
    /// Nome do cargo
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Representa uma lista de vendedores
    /// </summary>
    public ICollection<Salesperson> Salespeople { get; set; }
}