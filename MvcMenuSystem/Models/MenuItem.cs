using System.ComponentModel.DataAnnotations;

namespace MvcMenuSystem.Models;

public class MenuItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public bool IsVegetarian { get; set; }

    [DataType(DataType.Date)]
    public DateTime AvailableUntil { get; set; }
}