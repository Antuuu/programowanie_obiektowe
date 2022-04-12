namespace lab_2;

public class Task
{
    private string name;
    private TaskStatus status;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public TaskStatus Status
    {
        get => status;
        set => status = value;
    }

    public Task(string name, TaskStatus status)
    {
        this.name = name;
        this.status = status;
    }

    public bool Equals(Task task)
    {
        return this.name == task.name;
    }

    public override string ToString()
    {
        return name;
    }
}