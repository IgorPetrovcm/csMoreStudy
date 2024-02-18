namespace Entities;

using System.ComponentModel.DataAnnotations;

public class User
{
    [Required]
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    public Company Company { get; set; }
}