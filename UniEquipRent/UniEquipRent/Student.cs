namespace UniEquipRent;

public class Student : User
{
    public override int MaxActiveRentals => 2;
    
    public Student(int id, string name, string surname) 
        : base(id, name , surname)
    {
    }
    
}