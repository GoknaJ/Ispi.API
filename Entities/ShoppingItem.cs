using System.ComponentModel.DataAnnotations;

namespace Ispi.API.Entities;

public class ShoppingItem
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(150)]
    public string Name { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required, StringLength(50)]
    public string Manufacturer { get; set; }
}
