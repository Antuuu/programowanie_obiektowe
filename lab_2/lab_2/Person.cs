namespace lab_2;

public class Person
{
    protected string name;
    protected int age;

    public int Age
    {
        get => age;
        set => age = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Person (string name, int age)
    {
        this.age = age;
        this.name = name;
    }

    public bool Equal(Person Person)
    {
        return this.age == Person.age && this.name == Person.name;
    }

    public override string ToString()
    {
        return Name + " " + Age;
    }
}
