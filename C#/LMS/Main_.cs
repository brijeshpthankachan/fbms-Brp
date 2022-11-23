using LMS;
using System.ComponentModel.Design;

internal class Main_
{


    static Dictionary<string, User> SignInInfo = new Dictionary<string, User>()
    {
        { "Admin",new () { UserName="Admin", Password = "Admin" }},
    };
    static Dictionary<int, Books> Book = new Dictionary<int, Books>() { };
    private static void Main(string[] args)
    {



        while (true)
        {
            Console.Clear();
            Console.WriteLine($"1.   SigIn\n2.   Create New Account");
            int op = 0;
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Option");
                Thread.Sleep(500);
                Console.Clear();
                Main(args);
            }
            switch (op)
            {
                case 1:
                    SignIn();
                    break;
                case 2:
                    SignUP();
                    break;
                default:
                    break;
            }
        }

    }

    private static void SignUP()
    {
        User obj = new();
        obj.SetCredentials();
        SignInInfo[obj.UserName] = obj;
        Console.WriteLine("New User Added Succesfully");
        Thread.Sleep(1000);  
    }

    private static void SignIn()
    {
        Console.WriteLine("Enter UserName");
        string UserName = Console.ReadLine();  
        if(!SignInInfo.ContainsKey(UserName))
        {
            Console.WriteLine("No Such User Exits");
            SignIn();  
        }
        authpass();
        void authpass()
        {
            Console.WriteLine("Enter Password");
            string Password = Console.ReadLine();
            if (SignInInfo[UserName].Password == Password)
            {
                Console.WriteLine("Logged In SuccesFully");
                Thread.Sleep(1000);
                LMS();
            }
            else
            {
                Console.WriteLine("Invalid UserName Or Password");
                authpass();
            }
        }


    }

    static void  LMS()
    {
        Console.Clear();
        Console.WriteLine("1.   View Books\n2.   Add book\n3.   Update Book\n4.   Delete Record");
        int Option = 0;
        while (true)
        {
            try
            {

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Option Exiting To Home");
                Main(new string[] { });
            }

            switch (Option)
            {
                case 1:
                    ViewBooks();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

        }
    }

    static void ViewBooks()
    {

    }

}




