
// Abstract Class & Inheritance & Polymorfism & Overriding & Type-Checking & Type-Convertion

List<Animal> animals = new();
Cat cat = new();
Dog dog = new();
Spider spider = new();
animals.Add(dog);
animals.Add(cat);
animals.Add(spider);

foreach (var animal in animals)
{
    animal.Sound();
}

foreach (var animal in animals)
{
    if (animal is Spider)
    {
        spider.PoisionousBite();
    }
    else if (animal is Dog)
    {
        dog.Fetch();
    }
}

// Find all Spiders and add them to their own List because no one likes them, but if any dogs are found play fetch with them because they are nice. 
List<Spider> spiderList = new();
foreach (var animal in animals)
{
    if (animal is Spider)
    {
        Spider newSpider = animal as Spider;
        spiderList.Add(newSpider);

    }
    else if (animal is Dog)
    {
        dog.Fetch();
    }
}


public abstract class Animal {
    public int NumberOfLegs { get; set; }
    public string ProduceOffspringMechanic { get; set; } 
    public bool IsAlive { get; set; } = true;
    public Animal(int numberOfLegs, string produceOffspringMechanic)
    {
        NumberOfLegs = numberOfLegs;
        ProduceOffspringMechanic = produceOffspringMechanic;
    }
    public abstract void Sound();

    public string GetHomePlanet() {
        return "Earth";
    }
}

public class Cat : Animal
{
    public Cat() : base(4,"Live Birth")
    {
    }
    public override void Sound() 
    {
        Console.WriteLine("Meeoow");
    }
}

public class Dog : Animal
{
    public Dog() : base(4, "Live Birth")
    {
    }
    public override void Sound()
    {
        Console.WriteLine("WOFF!!");
    }
    public void Fetch()
    {
        Console.WriteLine("*Runs and picks up a twig*");
    }
}

public class Spider : Animal
{
    public Spider() : base(8,"Eggs")
    {   
    }
    public void PoisionousBite()
    {
        Console.WriteLine("*CRUNCH*");
    }
    public override void Sound()
    {
        Console.WriteLine("*skittering creepy crawly sound*"); 
    }
}