using OnionCQRS.Domain.Common;

namespace OnionCQRS.Domain.Entities;

public class Category : EntityBase
{
    public int ParentId { get; set; }
    public string Name { get; set; }
    public int Priorty { get; set; }
    public ICollection<Detail> Details { get; set; }
}