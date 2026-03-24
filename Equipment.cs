class Equipment{
    public static List<Equipment> equipmentsList = new List<Equipment>();
    static int id = 1;
    public string Name { get; set; }
    public string Producer { get; set; }
    public int Price { get; set; }
    public int Weight { get; set; }
    public int Id { get; set; }
    public Status Status { get; set; }
    
    public Equipment(string name, string producer, int price, int weight)
    {
        Name = name;
        Producer = producer;
        Price = price;
        Weight = weight;
        Id = id++;
        Status = Status.Available;
        equipmentsList.Add(this);
    }
}