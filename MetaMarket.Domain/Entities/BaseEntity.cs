namespace MetaMarket.Domain.Entities;

public class BaseEntity
{
    /// <summary>
    /// Id da entidade em questao (primary key)
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nome da entidade em questao
    /// </summary>
    public string Name { get; set; }
}
