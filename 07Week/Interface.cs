using System;

public class Program
{
	public static void Main()
	{
        House myhouse;
        ContractorA contractorA = new ContractorA();
        ContractorB contractorB = new ContractorB();

        if (contractorA.Estimate() < contractorB.Estimate())
        {
            myhouse = new House(contractorA);

        }
        else
        {
            myhouse = new House(contractorB);
        }

        myhouse.StartRenovation();

        Console.WriteLine($"The contractor that is going to renovate my house is {myhouse.WhoGotHired()}");
        Console.WriteLine($"This contractor charged me {myhouse.HowMuchContractorCharged()}");

        Console.WriteLine($"The kitchen will be done on {myhouse.Kitchen}");
        Console.WriteLine($"The bathroom will be done on {myhouse.Bathroom}");
        Console.WriteLine($"The bedbroom will be done on {myhouse.Bedbroom}");

        Console.ReadLine();
    }
}

// Contract
public interface IRenovactionContract
{
    DateTime RenovateKitchen(string color);
    DateTime RenovateBedroom(string color);
    DateTime RenovateBathroom(string color);

    int Estimate();
}

// Contractor A
public class ContractorA : IRenovactionContract
{
    public int Estimate()
    {
        Random r = new Random();
        return r.Next(2000, 7000);
    }

    public DateTime RenovateBathroom(string color)
    {
        // TODO - Working on renovating the bathroom.

        return DateTime.Now.AddDays(5);
    }

    public DateTime RenovateBedroom(string color)
    {
        // TODO - Workingon renovating the bedroom.

        return DateTime.Now.AddDays(4);
    }

    public DateTime RenovateKitchen(string color)
    {
        // TODO - Working on renovating kitchen

        return DateTime.Now.AddDays(9);

    }
}


// Contractor B
public class ContractorB : IRenovactionContract
{
    public int Estimate()
    {
        Random r = new Random();
        return r.Next(3000, 10000);
    }

    public DateTime RenovateBathroom(string color)
    {
        // TODO - Working on renovating the bathroom.

        return DateTime.Now.AddDays(4);
    }

    public DateTime RenovateBedroom(string color)
    {
        // Working on renovating the bedroom.

        return DateTime.Now.AddDays(3);
    }

    public DateTime RenovateKitchen(string color)
    {
        // TODO - Working on renovate kitchen.

        return DateTime.Now.AddDays(7);

    }
}

// House
public class House
{
    // Dependency
   private IRenovactionContract _contract;

    public DateTime Kitchen { get; set; }
    public DateTime Bathroom { get; set; }
    public DateTime Bedbroom { get; set; }
    //Constructor
    public House(IRenovactionContract contract) // Inject dependency
    {
        _contract = contract;

    }

    public void Renovation() { }

    public void StartRenovation()
    {
        Bedbroom = _contract.RenovateBedroom("grey");
        Bathroom = _contract.RenovateBathroom("white");
        Kitchen = _contract.RenovateKitchen("yellow");

    }

    public string WhoGotHired()
    {
        return _contract.ToString();
    }

    public int HowMuchContractorCharged()
    {
        return _contract.Estimate();

    }
}