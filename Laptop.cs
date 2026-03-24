class Laptop : Equipment
{
    int RamMemory { get; set; }
    int inches { get; set; }
    public Laptop(string name, string producer, int price, int weight, int ramMemory, int inches) 
    : base(name, producer, price, weight)
    {
        RamMemory = ramMemory;
        this.inches = inches;
        Console.WriteLine("Laptop has just been created");
    }
}