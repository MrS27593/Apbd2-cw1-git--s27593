public interface IRentalPosibility
{
    int MaxWypozyczen { get; }
    List<Wypozyczenie> Wypozyczenia { get; }
    bool CanRent();
}