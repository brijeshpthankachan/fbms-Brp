
namespace development_1
{
    internal class Company
    {
        public string Cname;
        public string Type_;

    }

    class Emp:Company
    {
        string Name;
        string Designation;
        

        public void Set(string cname,string type,string name,string designation)
        {

            Cname = cname;
            Type_ = type;
            Name = name;
            Designation = designation;
            
        }

        public void GetEmployeeInfo()
        {
            Console.WriteLine($"{Cname} {Type_} {Name} {Designation} ");
        }


    }
}
