namespace Entities;

using System.ComponentModel.DataAnnotations;

public class Company 
{
    [Required]
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }
}