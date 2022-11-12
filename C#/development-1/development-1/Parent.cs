

// create a class parent with feature family name and create anothe class child
//which inherits from basr class parent and has its own featurs name, age, and
//occupation.create a function set to give values to datamembers and anothe r
//function diasply to print values.



namespace development_1
{
    internal class Parent
    {

        public string FamilyName;



    }

    class Child : Parent
    {
        public int Age;
        public string Name;


        public void Set(int age,string name,string family)
        {
            Age = age;  
            Name = name;    
            FamilyName = family;    

        }

        public void GetFamilyInfo()
        {
            Console.WriteLine($"{Age}  {Name} {FamilyName}");
        }
    }

}
