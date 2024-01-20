namespace CreateAttributes;

[NameValidation(5)]
public class Employee
{
    public string Name {get;set;}

    public Employee(string name)
    {
        Name = name;
    }
}