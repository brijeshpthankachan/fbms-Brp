

namespace LMS
{
    internal class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public void SetCredentials()
        {
            Console.WriteLine("Enter UserNAme");
            string username= Console.ReadLine();
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("UserName Cannot be Empty");
                return;
            }
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            if (string.IsNullOrEmpty(password)) {
                Console.WriteLine("Password Cannot Be Empty");
                return;
            }
            UserName= username;
            Password= password; 
        }

        public void GetCredentials() {

            Console.WriteLine($"{UserName} {Password}");
        
        }

    }
}
