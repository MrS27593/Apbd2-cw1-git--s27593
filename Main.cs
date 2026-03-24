class Main
{
    static void Main(string[] args)
    {
        try{
        Console.WriteLine("Hello World!");
        //4 Users added 2 admins as employees and 2 students as users 2 laptops and 2 cameras.
        var student1 = new Student("Jan", "Kowalski");
        var student2 = new Student("Anna", "Nowak");
        var employee1 = new Employee("Adam", "Smith");
        var employee2 = new Employee("Ewa", "Jankowska");
        // 2 laptops and 2 cameras added to the system
        var laptop1 = new Laptop("Dell XPS 15", "Dell", 150000, 2, 16, 15);
        var laptop2 = new Laptop("MacBook Pro 16", "Apple", 200000, 2.5, 32, 16);
        var camera1 = new Camera("Canon EOS R5", "Canon", 200000, 0.7, true, 45); 
        var camera2 = new Camera("Sony A7 III", "Sony", 150000, 0.6, true, 24);
        // sout the equipments
        Console.WriteLine("\n=== Available Equipment ===");
        foreach (var equipment in Equipment.equipmentsList)
        {
            Console.WriteLine($"ID: {equipment.Id}, Name: {equipment.Name}, Producer: {equipment.Producer}, Price: {equipment.Price}, Weight: {equipment.Weight}, Status: {equipment.Status}");
        }
        // renting some equipment
        student1.RentEquipment(laptop1, DateTime.Now);
        student2.RentEquipment(camera1, DateTime.Now);
        }catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}