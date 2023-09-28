using ConsoleApp2;

class Program
{
    static void Main()
    {
        // Приклад використання класу Address
        Address userAddress = new Address
        {
            Index = "965",
            Country = "Ukraine",
            City = "Kyiv",
            Street = "Shevchenka",
            House = "5",
            Apartment = "18"
        };

        Console.WriteLine("Adress");
        Console.WriteLine("Index:" + userAddress.Index);
        Console.WriteLine("Country:" + userAddress.Country);
        Console.WriteLine("City:" + userAddress.City);
        Console.WriteLine("Street:" + userAddress.Street);
        Console.WriteLine("House:" + userAddress.House);
        Console.WriteLine("Apartment;" + userAddress.Apartment);
        Console.WriteLine();

        Converter converter = new Converter(39, 45, 10);
        double uahAmount = 100;

        double usdAmount = converter.ConvertToUsd(uahAmount);
        Console.WriteLine("100 hrivnyas equal" + usdAmount + "USA dollars");
        double eurAmount = converter.ConvertToEur(uahAmount);
        Console.WriteLine("100 hrivnyas equal" + eurAmount + "Euro");
        double plnAmount = converter.ConvertToPln(uahAmount);
        Console.WriteLine("100 hrivnyas equal" + plnAmount + "Polish zlotys");
        Console.WriteLine();

        Employee employee = new Employee("Dronov", "Denys");
        employee.CalculateSalary("Percussion", 4);
        employee.CalculateSalary("Programmer", 6);
        Console.WriteLine();

        User user = new User("user", "Denys", "Dronov", 18);
        user.DisplayUserInfo();
    }
}