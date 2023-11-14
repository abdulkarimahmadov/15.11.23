class Program
{
    static void Main()
    {
        try
        {
           
            User validUser = new User("Ahmad Chalabi", "chalabi@mail.com", "Passkodu999");
            validUser.ShowInfo();

           
            User invalidUser = new User("Ahmad Chalabi", "chalabi@mail.com", "Passkodu999");

    
            invalidUser.ShowInfo();
        }
        catch (IncorrectPasswordException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
