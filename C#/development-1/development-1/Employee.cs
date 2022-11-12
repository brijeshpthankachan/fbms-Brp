
namespace development_1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }

        private int _Salary;
        public int sal { get { return _Salary; }
            set
            {
                if (Designation == "Trainee")
                {
                            value = 5000;
                }
              
                    _Salary = value;
                
            } }
    }
}
