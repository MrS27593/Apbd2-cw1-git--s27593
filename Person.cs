using System.ComponentModel.DataAnnotations;

class Person
{
    static int id = 1;
    [MaxLength(50)]
    public string FirstName { get; set; } = null;
    [MaxLength(50)]
    public string LastName { get; set; } = null;
    UserType UserType { get; set; }
    int Userid{get;set;}
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Userid = id++;
    }
    public void rentEquipment(Equipment equipment)
    {
        if (equipment.Status != Status.Available)
        {
            throw new EquipmentNotAvailable();
        }
        equipment.Status = Status.Rented;
        new Rental(this, equipment, DateTime.Now);
    }

    public void returnEquipment(Equipment equipment)
    {
        if (equipment.Status != Status.Rented)
        {
            throw new Exception("Equipment is not rented. So You cannot return it.");
        }
        equipment.Status = Status.Available;
    }
}