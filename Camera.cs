class Camera : Equipment
{
    Boolean HDQuality{ get; set; }
    int MPX{ get; set; }
    public Camera(string name, string producer, int price, int weight, Boolean HDQuality, int MPX)
    : base(name, producer, price, weight)
    {
        this.HDQuality = HDQuality;
        this.MPX = MPX;
        Console.WriteLine("Camera has just been created");
    }
}