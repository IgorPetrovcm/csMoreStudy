using System.Globalization;

namespace Task1;

using CsvHelper;

class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"../../../employees.csv"))
        {
            using (CsvReader csvReader = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                IEnumerable<Employee> employees = csvReader.GetRecords<Employee>();
                foreach (Employee employee in employees)
                {
                    Console.WriteLine($"{employee.Id} - {employee.Last_Name} - {employee.First_Name} - {employee.Age}");
                }
            }
        }
    }
}