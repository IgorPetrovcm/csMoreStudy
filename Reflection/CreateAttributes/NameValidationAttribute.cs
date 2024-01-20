namespace CreateAttributes;


public class NameValidationAttribute : Attribute
{
    public int NameLength {get; private set;}

    public NameValidationAttribute(int length)   
    {
        NameLength = length;
    }
}