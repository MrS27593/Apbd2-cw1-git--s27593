class Rental
{
    static List<Rental> Rentals { get; } = new();
    private Student Student { get; set; }
    private Equipment Equipment { get; set; }
    private DateTime RentDate { get; set; }
    private DateTime ReturnDate { get; set; }
    private DateTime ActualReturnDate { get; set; }
    float Fee { get; set; }

    public Rental(Student student, Equipment equipment, DateTime rentDate)
    {
        Student = student;
        Equipment = equipment;
        RentDate = rentDate;
        ReturnDate = rentDate + TimeSpan.FromDays(14);
        ActualReturnDate = new DateTime();
        Fee = 0;
        Rentals.Add(this);
        Console.WriteLine("Rental has just been created");
    }

}