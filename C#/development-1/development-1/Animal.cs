

namespace development_1
{
    internal class Animal
    {

        private string? _Name;

        public string? Name  { get { return _Name; } set { 
            
                _Name = value;  
            
            } }

        public int MaxLifeTime; 

        private string? _Food;

        public string? Food
        {
            get { return _Food; }
            set
            {

                _Food = value;

            }
        }

        public void GetAnimal()
        {
            Console.WriteLine($"{_Name} {_Food} {MaxLifeTime}");
        }
    }
}
