using static System.Console;

var passwordVault = new Dictionary<string, string>();

int option = Option();


//methods
static int Option()
{
    WriteLine("Choose an option from below, 4 to quit");
    WriteLine("1.Add a new password");
    WriteLine("2.View saved passwords");
    WriteLine("3. Delete a password");
    WriteLine("4. Exit");
    Write("What would you like to do? ");
    int choice = int.Parse(ReadLine());
    
    return choice;
}

//Adding a password method.

//Viewing a password method.

//Deleting a password method.