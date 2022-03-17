using System;


public interface IPerson
{
    public Guid ID { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Fullname { get; }
}


public class Person : IPerson
{ 
    public Guid ID { get; } =  Guid.NewGuid();
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Fullname { get => $"{Name} {Surname}"; }

    public Person()
    {

    }

    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
}
