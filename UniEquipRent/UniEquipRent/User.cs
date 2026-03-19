namespace UniEquipRent;

public abstract class User
{
    public int Id { get; }
    public string Name { get; }
    public string Surname { get; }
    public abstract int MaxActiveRentals { get; }

    protected User(int id, string name, string surname)
    {
        Id = id;
        Name = name;
        Surname = surname;
    }
    
}