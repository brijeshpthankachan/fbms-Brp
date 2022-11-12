
//Create a class furniture with datamembrs type, wood, price,. Overload the
//constructor to create an object with and with out passing wood and passing no
//arguments.

namespace development_1
{
    internal class Furniture
    {
        string? Type;
        string? Wood;
        int Price;

        public Furniture(string wood = "default", string type = "default", int price = 0)
        {
            Type = type;
            Wood = wood;
            Price = price;
        }

        public void GetFurnitureInfo()
        {
            Console.WriteLine($"{Type} {Wood} {Price}");
        }
       
    
    }
  
}
