public class User : Account
{
    private static int nextId = 1;

    public int Id { get; }
    public string Fullname { get; set; }
    public string Email { get; set; }

    private string password;
    public string Password
    {
        get { return password; }
        set
        {
            if (PasswordChecker(value))
            {
                password = value;
            }
            else
            {
                throw new IncorrectPasswordException("Password does not meet the requirements.");
            }
        }
    }

    public User(string fullname, string email, string password)
    {
        Id = nextId++;
        Fullname = fullname;
        Email = email;
        Password = password;
    }

    public override bool PasswordChecker(string password)
    {
        // Password conditions
        if (password.Length >= 8 &&
            password.Any(char.IsUpper) &&
            password.Any(char.IsLower) &&
            password.Any(char.IsDigit))
        {
            return true;
        }
        return false;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"User ID: {Id}");
        Console.WriteLine($"Fullname: {Fullname}");
        Console.WriteLine($"Email: {Email}");
    }
}
