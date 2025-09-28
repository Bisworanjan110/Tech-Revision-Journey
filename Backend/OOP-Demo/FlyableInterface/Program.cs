namespace FlyableInterface
{
    interface IFlyable
    {
        void Fly() { }
    }
    class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }
    class Aeroplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Aeroplane is flying.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Aeroplane a = new Aeroplane();

            bird.Fly();
            a.Fly();
        }
    }
}
