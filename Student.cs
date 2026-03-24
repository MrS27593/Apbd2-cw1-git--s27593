class Student : Person
{
    // static int index = 1;
    String IndexNumber { get; set; }
    public Student(string firstName, string lastName) : base(firstName,  lastName)
    {
        // IndexNumber = $"s{index++:00000}";
        userType = UserType.User;
    }

    public List<Wypozyczenie> Wypozyczenia { get; set; } = new();

    public int MaxWypozyczen => 2;

    public bool MozeWypozyczyc()
    {
        return Wypozyczenia.Count < MaxWypozyczen;
    }
}