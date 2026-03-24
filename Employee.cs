class Employee : Person, IRentalPosibility
{
    // int EmployeeId { get; set; }

    public Employee(string firstName, string lastName) 
    : base(firstName, lastName)
    {
        // EmployeeId = id++;
        userType = UserType.Admin;
    }

    public int MaxWypozyczen => 5;

    public bool MozeWypozyczyc()
    {
        return Wypozyczenia.Count < MaxWypozyczen;
    }
}