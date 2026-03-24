// class Service
// {
//     private List<Person> people;
//     private List<Equipment> equipment;

//     public Service()
//     {
//         people = new List<Person>();
//         equipment = new List<Equipment>();
//     }

//     public void AddPerson(Person person)
//     {
//         people.Add(person);
//     }

//     public void AddEquipment(Equipment equip)
//     {
//         equipment.Add(equip);
//     }

//     public void RentEquipment(Person person, Equipment equip)
//     {
//         if (equip.Status != Status.Available)
//         {
//             throw new EquipmentNotAvailable();
//         }

//         if (person is IRentalPosibility rentalPerson && !rentalPerson.CanRent())
//         {
//             throw new Exception("Person cannot rent more equipment.");
//         }

//         equip.Status = Status.Rented;
//         if (person is IRentalPosibility rental)
//         {
//             rental.Wypozyczenia.Add(new Wypozyczenie { Person = person, Equipment = equip });
//         }
//     }
// }