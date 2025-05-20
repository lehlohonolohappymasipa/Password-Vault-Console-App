using static System.Console;

var passwordVault = new Dictionary<string, string>();

WriteLine("Password Vault Console App");

int option = Option();
while (option != 4)
{
    switch (option)
    {
        case 1:
            AddPassword(passwordVault);
            break;
        case 2:
            break;
        case 3:
            break;
        default:
            WriteLine("Invalid option.");
            break;
    }
    option = Option();
}
WriteLine("Exiting app, Goodbye.");
ReadLine();

//methods
static int Option()
{
    WriteLine();
    WriteLine("Choose an option from below, 4 to quit");
    WriteLine("1. Add a new password.");
    WriteLine("2. View saved passwords.");
    WriteLine("3. Delete a password.");
    WriteLine("4. Exit.");
    Write("What would you like to do? ");
    int choice = int.Parse(ReadLine());
    
    return choice;
}

//Adding a password method.
static void AddPassword (Dictionary<string, string> vault)
{
    WriteLine();
    Write("What service is this password for: ");
    string passKey = ReadLine();
    Write("Enter password: ");
    string password = ReadLine();

    vault.Add(passKey, password);
    WriteLine("Password added successfully.");
}

//Viewing a password method.

//Deleting a password method.