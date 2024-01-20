namespace  CreateAttributes;


public class Program 
{
    static void Main()
    {
        Employee employee = new Employee("hfsefi");

        System.Console.WriteLine(Validate(employee));
    }

    static bool Validate(Employee employee)
    {
        Type type = typeof(Employee);

        var attribut = type.GetCustomAttributes(typeof(NameValidationAttribute), true)
                            .First() as NameValidationAttribute;

        return attribut.NameLength < employee.Name.Length ? false : true;
    }
}