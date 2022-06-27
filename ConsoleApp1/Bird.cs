using System;
using System.Collections.Generic;

public class Bird
{
    public Bird(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void Fly()
    {
        Console.WriteLine("Bird is flying");
    }

    public virtual void Sing()
    {
        Console.WriteLine("Bird is singing");
    }

    public void Eggs()
    {
        Console.WriteLine("Bird is sitting eggs");
    }

    public virtual void Child()
    {
        Console.WriteLine("Bird is sitting baby-birds");
    }

    
}


public class Cuckoo : Bird
{
    public Cuckoo(string name) : base(name)
    {
    }

    public override void Child()
    {
        Console.WriteLine("Bird is sitting baby-birds");
    }
}

public class Chicken : Cuckoo
{
    public Chicken(string name) : base(name)
    {
    }

    public override void Sing()
    {
        Console.WriteLine("Bird is singing");
    }

}

public class Sitter : Chicken
{
    public Sitter(string name) : base(name)
    {
    }

    public override void Child()
    {
        Console.WriteLine("Bird is sitting baby-birds");
    }
}

public class Birds
{
    public List<Bird> List_of_Birds;
    public Birds(List<Bird> birds)
    {
        List_of_Birds = birds;
    }

  
}
