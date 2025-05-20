using System.ComponentModel;
using static System.Console;

var passwordVault = new Dictionary<string, string>();
int nrEl = passwordVault.Count;

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
            ViewPasswords(passwordVault);
            break;
        case 3:
            DeletePassword(passwordVault);
            break;
        default:
            WriteLine("Invalid option.");
            break;
    }
    option = Option();
}
WriteLine("Exiting app, Goodbye.");


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

static void ViewPasswords(Dictionary<string, string> vault)
{
    WriteLine();
    if (vault.Count == 0)
        WriteLine("There are no saved passwords");
    else
        foreach (var password in vault)
        {
            WriteLine($"Service: {password.Key}, Password: {password.Value}");
        }
}

static void DeletePassword(Dictionary<string, string> vault)
{
    WriteLine();
    if (vault.Count == 0)
        WriteLine("There are no saved passwords");
    else
    {
        Write("Enter the service for the password you want to delete: ");
        string passKey = ReadLine();

        bool isKeyFound = vault.ContainsKey(passKey);
        if (isKeyFound)
        {
            vault.Remove(passKey);
            WriteLine("Password deleted successfully.");
        }
        else
            WriteLine("Password not found.");
    }
}