using System;

public class Person
{ 
    public Guid ID { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Fullname { get => $"{Name} {Surname}"; }

    public Person(string name, string surname)
    {
        ID = Guid.NewGuid();
        Name = name;
        Surname = surname;
    }
}
