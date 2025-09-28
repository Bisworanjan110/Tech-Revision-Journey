namespace EmpMngInheritance
{
    class Employee
    {
        public string Name {  get; set; }
        public double Salary { get; set; }

        public void Work()
        {
            Console.WriteLine("Employee is Working");
        }
    }
    class Manager : Employee
    {
        public void ConductMeeting()
        {
            Console.WriteLine("Manager is conducting the meeting");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Work();
            manager.ConductMeeting();
        }
    }
}
