

namespace development_1
{
    internal class Mobile
    {

        private string? Name;
        private string? Model;
        private string? Company;
        private int Price;


        public void Set(string name,string model,string comp,int price)
        {

            Name = name;
            Model = model;
            Company = comp; 
            Price = price;
        }

        public void Set(string name, string model, int price)
        {

            Name = name;
            Model = model;
            Company = "default";
            Price = price;
        }

        public void Get()
        {
            Console.WriteLine($"{Name} {Model} {Company} {Price}");
        }

    }

 
}
