namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa um funcionário/vendedor do MetaMarket
/// </summary>
public class Salesperson
{
    /// <summary>
    /// Codigo que representa o vendedor
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Caixa de operação do vendedor
    /// </summary>
    public string OperationTeller { get; set; }
}
