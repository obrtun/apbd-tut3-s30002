namespace UniEquipRent;

public class Employee : User
{
    public override int MaxActiveRentals => 5;

    public Employee(int id, string name, string surname)
        : base(id, name, surname)
    {
    }
}