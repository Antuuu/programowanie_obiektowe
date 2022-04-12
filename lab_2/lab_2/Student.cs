using System.Text;

namespace lab_2;

public class Student : Person 
{
    protected string group;
    protected List<Task> tasks = new List<Task>();
    
    public string Group
    {
        get => group;
        set => group = value;
    }

    public Student (string name, int age, string group) : base(name, age)
    {
        this.age = age;
        this.name = name;
        this.group = group;
    }
    
    public Student(string name, int age, string group, TaskStatus taskStatus) : base(name, age)
    {
        this.age = age;
        this.name = name;
        this.group = group;
    }

    public void AddTask(string taskName, TaskStatus taskStatus)
    {
        tasks.Add(new Task(taskName, TaskStatus.Waiting));
    }
    
    public void UpdateTask(int index, TaskStatus taskStatus)
    {
        tasks[index].Status = taskStatus;
    }
    
    public void RemoveTask(int index)
    {
        tasks.RemoveAt(index);
    }

    public override string ToString()
    {
        return Name + " " + Age + " (y.o.)" + "\n" + "Group: " + Group + "\n" + "Tasks: " + "\n" + RenderTasks("\t");
    }

    public string RenderTasks(string prefix)
    {
        var builder = new StringBuilder();
        if (tasks.Count > 0)
        {
            for(int i = 0; i < tasks.Count; i++) 
                builder.AppendLine($"{prefix}{i+1}. {tasks[i].Name} [{tasks[i].Status}]");
        }
        return builder.ToString();

    }


    public bool Equals(Student student)
    {
        return this.name == student.name && this.age == student.age && this.group == student.group;
    }
    
    public bool SubsequenceEqual(Student student)
    {
        return this.tasks.SequenceEqual(student.tasks);
    }
}