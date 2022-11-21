
namespace RMS
{
    internal class FoodClass
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }


        public void ChangePrice()
        {
           
            Console.WriteLine("Enter A Price");
            int Price = 0;
            Price = int.Parse(Console.ReadLine());

            FoodPrice = Price;

            Console.WriteLine($"{FoodId} {FoodName}  {FoodPrice}");  

            
        }

    }
}
