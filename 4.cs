using System;

public enum EquipmentType
{
    Mobile,
    Immobile
}
public abstract class Equipment
{
    public string Name;
    public string Description;
    public double DistanceMovedTillDate = 0;
    public double MaintenanceCost = 0;
    public EquipmentType TypeOfEquipment;

    public abstract double Maintenancecost(double distanceMoved);
    public virtual void MoveBy(double distanceMoved)
    {
        DistanceMovedTillDate += distanceMoved;
        MaintenanceCost += Maintenancecost(distanceMoved);
    }
}

public class MobileEquipment : Equipment
{
    public int NumberOfWheels;

    public MobileEquipment(int numberOfWheels)
    {
        NumberOfWheels = numberOfWheels;
    }

    public override double Maintenancecost(double distanceMoved)
    {
        return NumberOfWheels * distanceMoved;
    }
}

public class ImmobileEquipment : Equipment
{
    public double Weight;

    public ImmobileEquipment(double weight)
    {
        Weight = weight;
    }

    public override double Maintenancecost(double distanceMoved)
    {
        return Weight * distanceMoved;
    }
}

public class Program
{
    public static void Main()
    {
        Equipment mobileEquipment = new MobileEquipment(4);
        mobileEquipment.Name = "Mobile Equipment 1";
        mobileEquipment.Description = "This is a mobile equipment";
        mobileEquipment.TypeOfEquipment = EquipmentType.Mobile;
        mobileEquipment.MoveBy(22);

        Console.WriteLine("Name: "+mobileEquipment.Name);
    Console.WriteLine("Description: "+mobileEquipment.Description);
    Console.WriteLine("Distance Moved: "+mobileEquipment.DistanceMovedTillDate+" km"); 
Console.WriteLine("Maintenance Cost: "
+mobileEquipment.MaintenanceCost);
    Console.WriteLine("Type: "+mobileEquipment.TypeOfEquipment);

        Equipment immobileEquipment = new ImmobileEquipment(5);
        immobileEquipment.Name = "Immobile Equipment 1";
        immobileEquipment.Description = "This is an immobile equipment";
        immobileEquipment.TypeOfEquipment = EquipmentType.Immobile;

        immobileEquipment.MoveBy(21);
        Console.WriteLine("Name: "+immobileEquipment.Name);
    Console.WriteLine("Description: "+immobileEquipment.Description);
    Console.WriteLine("Distance Moved: "+immobileEquipment.DistanceMovedTillDate+" km"); 
Console.WriteLine("Maintenance Cost: "
+immobileEquipment.MaintenanceCost);
    Console.WriteLine("Type: "+immobileEquipment.TypeOfEquipment);

    }
}
