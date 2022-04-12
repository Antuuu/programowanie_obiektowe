using System.Text.RegularExpressions;

namespace lab_2;

public class Teacher : Person
{
    public Teacher(string name, int age) : base(name, age)
    {
        
    }

    public override string ToString()
    {
        return "Treacher: " + Name + " " + Age + " (y.o.)" ;
    }
}