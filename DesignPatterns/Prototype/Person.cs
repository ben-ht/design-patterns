namespace DesignPatterns.Prototype;
internal class Person
{
    public Id Id { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }

    public Person(Id id, int age, string name) 
    {
        Id = id;
        Age = age;
        Name = name;
    }

    public Person(Person person)
    {
        Id = new Id(person.Id.IdNumber);
        this.Name = person.Name;
        this.Age = person.Age;
    }

    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }

    public Person DeepClone()
    {
        return new Person(this);
    }

    public override string ToString()
    {
        return $"[Id : {Id.IdNumber}, Age: {Age}, Name: {Name}]";
    }
}
