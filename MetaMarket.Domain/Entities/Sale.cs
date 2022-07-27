namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa uam promoção no MetaMarket
/// </summary>
public class Sale
{
    /// <summary>
    /// Nome do promoção
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Emails que receberão a promoção
    /// </summary>
    public ICollection<string> Emails { get; set; }
}
