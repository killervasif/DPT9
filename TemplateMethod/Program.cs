//  This Abstract Class defines a set of abstract methods that need to be implemented by the Concrete sub Classes.
//  But if you want you can also provide a default implementation for the above methods and the child class can optionally override the implementation.
//  It also provides one concrete method (i.e. template method) which defines the order in which those abstract operations occur. 
public abstract class HouseTemplate
{
    // Template method defines the sequence for building a house
    public void BuildHouse()
    {
        BuildFoundation();
        BuildPillars();
        BuildWalls();
        BuildWindows();
        Console.WriteLine("House is built");
    }
    // Methods to be implemented by subclasses
    protected abstract void BuildFoundation();
    protected abstract void BuildPillars();
    protected abstract void BuildWalls();
    protected abstract void BuildWindows();
}

// The Concrete Class implements the operations defined by the Abstract Class.
// As we are going to create two types of house i.e. Concrete and Wooden
// so we are going to create two concrete classes by implementing the abstract HouseTemplate class.

public class ConcreteHouse : HouseTemplate
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building foundation with cement, iron rods and sand");
    }
    protected override void BuildPillars()
    {
        Console.WriteLine("Building Concrete Pillars with Cement and Sand");
    }
    protected override void BuildWalls()
    {
        Console.WriteLine("Building Concrete Walls");
    }
    protected override void BuildWindows()
    {
        Console.WriteLine("Building Concrete Windows");
    }
}

public class WoodenHouse : HouseTemplate
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building foundation with cement, iron rods, wood and sand");
    }
    protected override void BuildPillars()
    {
        Console.WriteLine("Building wood Pillars with wood coating");
    }
    protected override void BuildWalls()
    {
        Console.WriteLine("Building Wood Walls");
    }
    protected override void BuildWindows()
    {
        Console.WriteLine("Building Wood Windows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Build a Concrete House\n");
        HouseTemplate houseTemplate = new ConcreteHouse();
        // call the template method
        houseTemplate.BuildHouse();
        Console.WriteLine();
        Console.WriteLine("Build a Wooden House\n");
        houseTemplate = new WoodenHouse();
        // call the template method
        houseTemplate.BuildHouse();
        Console.Read();
    }
}