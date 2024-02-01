namespace FirstLesson;


public class Program 
{
    static void Main()
    {
        Numbers numbers = new Numbers();

        foreach (int a in numbers)
        {
            System.Console.WriteLine(a);
        }

        List<Person> persons = new List<Person>()
        {
            new Person("1"),
            new Person("2"),
            new Person("3"),
            new Person("4")
        };

        Persons metaPersons = new Persons(persons);

        foreach (string name in metaPersons.GetPersonsName())
        {
            System.Console.WriteLine(name);
        }
    }
}
public class Numbers
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 7; i++)
        {
            yield return i;
        }
    }
}

public class Persons
{
    Person[] persons;

    public Persons(List<Person> persons)
    {
        this.persons = persons.ToArray();
    }

    public IEnumerable<string> GetPersonsName()
    {
        for (int i = 0; i < persons.Length; i++)
        {
            yield return persons[i].name;
        }
    }
}

public class Person
{
    public string name;

    public Person(string name)
    {
        this.name = name;
    }
}