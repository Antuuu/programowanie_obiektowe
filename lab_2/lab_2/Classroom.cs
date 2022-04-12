using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace lab_2;

public class Classroom
{
    private string name;
    protected Array persons;
    
    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Classroom(string name, Person[] persons)
    {
        this.name = name;
        this.persons = persons;
    }

    public override string ToString()
    {
        Console.WriteLine("Classroom: " + Name + "\n");
        foreach (var person in persons)
        {
             Console.WriteLine(person.ToString() + "\n" );
        }

        return null;
    }
}