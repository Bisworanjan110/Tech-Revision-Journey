namespace CarInformation
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Corolla";
            car1.Year = 2020;

            // Create second car object
            Car car2 = new Car();
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.Year = 2022;

            car1.DisplayInfo();
            car2.DisplayInfo();

        }
    }
}
