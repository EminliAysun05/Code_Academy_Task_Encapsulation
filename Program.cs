namespace Code_Academy_Task_Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];

           
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("Fullname: ");
                string Fullname = Console.ReadLine();

                Console.WriteLine("Email: ");
                string Email = Console.ReadLine();

                string password;
                bool IsValidPassWord = false;
                while (!IsValidPassWord)
                {
                    Console.WriteLine("Password: ");
                    string Password = Console.ReadLine();

                    IsValidPassWord = User.PassWordChecker(Password);
                    if (!IsValidPassWord)
                    {
                        Console.WriteLine("Error password");
                    }
                    else
                    {
                        users[i] = new User(Fullname, Email, Password);
                        Console.WriteLine();
                    }
                }
            }

            bool program = false;
            while(program)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Show all students: ");
                Console.WriteLine("2. Get info by id: ");
                Console.WriteLine("0. Program terminated");
                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    Console.WriteLine("All students: ");
                    foreach (var user in users)
                    {
                        Console.WriteLine(user.GetInfo());
                    }
                }
                else if(choice == 2) {
                    Console.WriteLine("Enter the Id: ");
                    int id = int.Parse(Console.ReadLine()); 

                    User user = User.FindUserById(id,users);
                    if(user != null) {
                        Console.WriteLine(user.GetInfo());
                    }
                    else
                    {
                        Console.WriteLine("user not found");
                    }
                }

                else if(choice == 0) {
                    Console.WriteLine("Program termianted...");
                    program = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. ");
                }
            }
            
        }
    }
}
