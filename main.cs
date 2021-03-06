class Employee
{
    public string name;
    public int age;
    public int salary;

    public Employee(string name, int age, int salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public virtual void Info()
    {
        Console.WriteLine($"???: {name}\n" +
                          $"???????: {age}\n" +
                          $"??: ${salary}\n");
    }
}


class Janitor : Employee
{
    public string area;
    public string zabod;

    public Worker(string name, int age, int salary, string zavod, string area) : base(name, age, salary)
    {
        this.zavod = zavod;
        this.area = area;
    }

    public override void Info()
    {
        Console.WriteLine("???????? ??????:");
        Console.WriteLine($"???: {name}\n" +
                        $"???????: {age}\n" +
                        $"???? ??????: {area}\n" +
                        $"??: ${salary}");
        Console.WriteLine($"?????: {zavod}\n");
    }
}

class Worker : Employee
{
    public string zavod;

    public Worker(string name, int age, int salary, string zavod) : base(name, age, salary)
    {
        this.zavod = zavod;
    }

    public override void Info()
    {
        Console.WriteLine("???????? ??????:");
        Console.WriteLine($"???: {name}\n" +
                          $"???????: {age}\n" +
                          $"??: ${salary}");
        Console.WriteLine($"?????: {zavod}\n");
    }
}

class Manager : Employee
{
    public string permission;
    public string zabod;

    public Manager(string name, int age, int salary, string zavod, string permission) : base(name, age, salary)
    {
        this.zavod = zavod;
        this.permission = permission;
    }

    public override void Info()
    {
        Console.WriteLine("???????? ??????:");
        Console.WriteLine($"???: {name}\n" +
                        $"???????: {age}\n" +
                        $"?????: {permission}\n" +
                        $"??: ${salary}");
        Console.WriteLine($"?????: {zavod}\n");
    }
}