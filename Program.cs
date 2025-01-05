namespace SystemZarzadzaniaPracownikami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IEmplojee> employees = new List<IEmplojee>();

            
            employees.Add(new Manager(12000));  
            employees.Add(new Developer(50, 160));  

            
            foreach (var employee in employees)
            {
                employee.Work(); 
                Console.WriteLine($"Pensja: {employee.GetSalary()} PLN\n"); 
            }
        }
    }
}
