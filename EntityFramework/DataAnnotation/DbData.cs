namespace DataAnnotation;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Column("user_id")]
    public int Id {get;set;}

    public string Name {get; set;}

    public int Age {get; set;}

    public Company Company {get;set;}

    public Country Country {get;set;}
}

[NotMapped]
public class Company
{
    public int Id {get; set;}

    public string Name {get; set;}
}

public class Country
{
    public int Id {get;set;}

    public string Name {get;set;}
}