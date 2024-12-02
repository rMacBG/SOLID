namespace Liskov
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Company company = new Company();

            company.Workers.Add(new Programmer());
            company.EmployedWorkers.Add(new Programmer());
            company.Workers.Add(new Robot());

            company.Work();
            company.TakeBreak();
        }
    }
}
